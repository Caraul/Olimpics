using System;
using System.Collections.Generic;

namespace Labirint
{
    public class Tunnel
    {
        public bool HasExit { get { return HasExit; } set { HasExit = value; } }
        public int[] IndexOfRoom1TunnelGo;
        public int[] IndexOfRoom2TunnelGo;
    }
}
