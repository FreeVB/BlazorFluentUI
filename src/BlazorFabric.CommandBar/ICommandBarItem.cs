﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorFabric
{
    public interface ICommandBarItem : IContextualMenuItem
    {
        //buttonStyles
        string CacheKey { get; set; }
        //commandBarButtonAs
        bool IconOnly { get; set; }
        bool RenderedInOverflow { get; set; }
        //tooltipHostProps
    }
}
