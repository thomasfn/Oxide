using System;
using System.IO;

using Oxide.Catalyst.Agent;
using Oxide.Catalyst.Agent.Modules;
using Oxide.Catalyst.Agent.Commands;

namespace Oxide.Catalyst.Terminal
{
    /// <summary>
    /// The core program class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // Setup output device
            ConsoleOutputDevice outputDevice = new ConsoleOutputDevice();

            // Setup engine
            CommandEngine engine = new CommandEngine(outputDevice);
            engine.Context = new CommandContext
            {
                WorkingDirectory = Path.GetFullPath("."),
                Terminate = false
            };

            // Register all modules
            foreach (IModule module in ModuleRegistry.Modules)
            {
                module.RegisterCommands(engine);
                module.PrintInfo(outputDevice, true);
            }

            // Core input loop
            while (!engine.Context.Terminate)
            {
                // Input prompt
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"${Path.GetFileName(engine.Context.WorkingDirectory)}/");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": ");
                string line = Console.ReadLine();

                // Write
                outputDevice.WriteStaticLine($"$cyan${Path.GetFileName(engine.Context.WorkingDirectory)}/$white: {line}");

                // Handle command
                if (!engine.HandleCommand(line))
                {
                    outputDevice.WriteStaticLine("$redUnknown command!");
                }
                
            }
        }
    }
}
