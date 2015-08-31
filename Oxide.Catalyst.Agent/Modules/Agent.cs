﻿using System;

using Oxide.Catalyst.Agent.UI;

namespace Oxide.Catalyst.Agent.Modules
{
    /// <summary>
    /// The core agent module
    /// </summary>
    public sealed class Agent : IModule
    {
        /// <summary>
        /// Gets the name of this module
        /// </summary>
        public string Name { get { return "Core Agent"; } }

        /// <summary>
        /// Gets the version of this module
        /// </summary>
        public string Version { get { return "dev 0.0.1"; } }

        /// <summary>
        /// Prints this module's info to the specified output device
        /// </summary>
        /// <param name="outputDevice">The device to write to</param>
        /// <param name="init">Is the session just starting?</param>
        public void PrintInfo(IOutputDevice outputDevice, bool init)
        {
            if (init)
            {
                outputDevice.WriteStaticLine($"Oxide Catalyst $green{Name} $whiteversion $yellow{Version}");
            }
            else
            {
                outputDevice.WriteStaticLine($"$whiteModule $green{Name} $whiteversion $yellow{Version}");
            }
        }

        /// <summary>
        /// Registers all commands
        /// </summary>
        /// <param name="commandEngine"></param>
        public void RegisterCommands(CommandEngine commandEngine)
        {

        }
    }
}
