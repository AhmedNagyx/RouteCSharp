﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    [Flags]
    public enum Permissons : byte
    {
       Read = 1, Write = 2, Delete = 4, Execute = 8
    }
}
