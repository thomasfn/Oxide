using System;
using System.Collections.Generic;

namespace Oxide.Catalyst.Agent.Modules
{
    /// <summary>
    /// The module registry
    /// </summary>
    public static class ModuleRegistry
    {
        public static readonly IEnumerable<IModule> Modules = new IModule[]
        {
            new Agent(), // Core agent module
            new FileSystem() // File system module
        };

    }
}
