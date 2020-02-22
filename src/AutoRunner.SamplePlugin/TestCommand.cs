using AutoRunner.Plugins.Commands;
using System;
using System.Threading.Tasks;

namespace AutoRunner.SamplePlugin
{
    public class TestCommand : IAutoCommand
    {
        public Task Execute()
        {
            Console.WriteLine("Hello from a sample Plugin!");
            return Task.CompletedTask;
        }
    }
}
