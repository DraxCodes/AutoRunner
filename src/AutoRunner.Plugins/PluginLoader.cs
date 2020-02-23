using AutoRunner.Plugins.Commands;
using System;
using System.IO;
using System.Reflection;

namespace AutoRunner.Plugins
{
    public class PluginLoader
    {
        public void Load()
        {
            var pluginPath = Path.Combine(Directory.GetCurrentDirectory(), "AutoRunner.SamplePlugin.dll");
            var plugin = Assembly.LoadFile(pluginPath);

            foreach(var type in plugin.GetExportedTypes())
            {
                if (ImplementsCommandInterface(type))
                {
                    var instance = Activator.CreateInstance(type);
                    InvokeExecuteCommand(type, instance);
                }
            }
        }

        private void InvokeExecuteCommand(Type type, object instance)
            => type.InvokeMember(nameof(IAutoCommand.Execute), BindingFlags.InvokeMethod, null, instance, new object[0]);

        private static bool ImplementsCommandInterface(Type type)
            => typeof(IAutoCommand).IsAssignableFrom(type);
    }
}
