﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace com.spacepuppy.Graphs
{
    public interface IHeuristic<T> where T : INode
    {
        float Distance(T x, T y);
    }
}