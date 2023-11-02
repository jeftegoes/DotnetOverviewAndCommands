using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ProjectMonitorSitesWorkerService.Core.Models;
using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMonitorSitesWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;
        private readonly ServiceConfigurations _serviceConfigurations;

        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            this._configuration = configuration;
            this._logger = logger;

            _serviceConfigurations = new ServiceConfigurations();

            new ConfigureFromConfigurationOptions<ServiceConfigurations>
                (
                    _configuration.GetSection("ServiceConfigurations")
                )
                .Configure(_serviceConfigurations);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker executando as: {time}", DateTimeOffset.Now);

                foreach (var host in _serviceConfigurations.Hosts)
                {
                    _logger.LogInformation($"Verificando a disponibilidade do host { host }");

                    var resultMonitor = new ResultMonitor()
                    {
                        Time = DateTime.Now.ToString("yyy-Mm-dd HH:mm:ss"),
                        Host = host
                    };

                    try
                    {
                        using (var p = new Ping())
                        {
                            var response = p.Send(host);
                            resultMonitor.Status = response.Status.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        resultMonitor.Status = "Exception";
                        resultMonitor.Exception = ex;
                    }

                    var jsonResult = JsonConvert.SerializeObject(resultMonitor);

                    if (resultMonitor.Exception == null)
                        _logger.LogInformation(jsonResult);
                    else
                        _logger.LogError(jsonResult);
                }

                await Task.Delay(_serviceConfigurations.Interval, stoppingToken);
            }
        }
    }
}
