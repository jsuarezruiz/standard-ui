﻿using System.Collections.Generic;

namespace Microsoft.StandardUI.Media
{
    [UIModelObject]
    public interface IPathGeometry : IGeometry
    {
        IUICollection<IPathFigure> Figures { get; }

        [DefaultValue(FillRule.EvenOdd)]
        FillRule FillRule { get; set; }
    }
}
