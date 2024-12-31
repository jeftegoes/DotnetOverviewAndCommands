using System;
using MethodBoundaryAspect.Fody.Attributes;

namespace ExampleAopFody.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class LogAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs arg)
        {
            Console.WriteLine($"OnEntry -> {arg.Method.Name}");
        }

        public override void OnExit(MethodExecutionArgs arg)
        {
            Console.WriteLine($"OnExit -> {arg.Method.Name}");
        }

        public override void OnException(MethodExecutionArgs arg)
        {
            Console.WriteLine($"OnException -> {arg.Method.Name}");
        }
    }
}