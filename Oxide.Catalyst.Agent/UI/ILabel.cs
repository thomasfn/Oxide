﻿using System;

namespace Oxide.Catalyst.Agent.UI
{
    /// <summary>
    /// Represents a mutable label
    /// </summary>
    public interface ILabel : IUIComponent
    {
        /// <summary>
        /// Gets or sets the text stored within this label
        /// </summary>
        string Text { get; set; }
    }
}
