using System;

namespace Oxide.Catalyst.Agent.UI
{
    /// <summary>
    /// Represents a generic UI component
    /// </summary>
    public interface IUIComponent
    {
        /// <summary>
        /// Gets the height of this UI component in text rows
        /// </summary>
        int Height { get; }
    }
}
