using AutoRunner.Plugins;
using System;

namespace AutoRunner.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new PluginLoader();
            loader.Load();
        }
    }
}
