﻿using Graphing.Position.Generic;

namespace Graphing.Planet
{
    public class PlatePoly
        : PositionPoly<PlatePoly, PlateEdge, PlateNode>
    {
        public PlatePoly()
        {
            Height = 0;
        }

        public int Height { get; set; }

        public bool Oceanic
        {
            get { return Height < 0; }
        }
    }
}