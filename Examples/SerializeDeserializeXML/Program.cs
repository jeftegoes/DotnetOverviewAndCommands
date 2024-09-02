using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using ExampleDotnetSerializeDeserializeXML.Models;

namespace ExampleDotnetSerializeDeserializeXML
{
    class Program
    {
        public static string Serialize<T>(T value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));

                // This is useful for surpress XSI and XSD namespaces.
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                using (var stringWriter = new StringWriter())
                {
                    using (var writer = XmlWriter.Create(stringWriter))
                    {
                        xmlSerializer.Serialize(writer, value, ns);

                        return stringWriter.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static T DeserializeXML<T>(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml))
            {
                return default(T);
            }

            try
            {
                using (var stringReader = new StringReader(xml))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(stringReader);
                }
            }
            catch
            {
                return default(T);
            }
        }

        public static void ExampleDeserializeObject()
        {
            var returnXml = @"  <post-method xmlns:S=""X"">
                                    <response-code>200</response-code>
                                    <response-desc>OK</response-desc>
                                    <entity>
                                        <content-type>text/xml</content-type>
                                        <content>
                                            <S:Body>
                                                <S:execSyncResponse>
                                                    <S:return>
                                                        <S:errorType>U</S:errorType>
                                                        <S:serviceStatus>1</S:serviceStatus>
                                                        <S:serviceDescription/>
                                                        <S:serviceException>OK</S:serviceException>
                                                    </S:return>
                                                </S:execSyncResponse>
                                            </S:Body>
                                        </content>
                                    </entity>
                                </post-method>";

            var objectXML = DeserializeXML<PostMethod>(returnXml);

            Console.WriteLine(@"errorType: {0} 
serviceStatus: {1}
serviceDescription: {2}
serviceException: {3}", objectXML.entity.Content.Body.ExecSyncResponse.Return.ErrorType,
objectXML.entity.Content.Body.ExecSyncResponse.Return.ServiceStatus,
objectXML.entity.Content.Body.ExecSyncResponse.Return.ServiceDescription,
objectXML.entity.Content.Body.ExecSyncResponse.Return.ServiceException);
        }

        public static void ExampleSerializeObject()
        {   
            var request = new Envelope();
            request.body.Order.NumberOrder =
            request.body.Order.NumberOrder = 10;
            request.body.Order.ItemsOrdered.Item = "Banana";

            var xml = Serialize<Envelope>(request);

            Console.WriteLine("\n {0}", xml);
        }

        static void Main(string[] args)
        {
            ExampleDeserializeObject();

            ExampleSerializeObject();
        }
    }
}
