using System;
using System.Collections.Generic;

namespace Labirint
{
    public class Tunnel
    {
        public bool HasExit { get; set; } = false;
        public int[] IndexOfRoom1TunnelGo { get; set; }
        public int[] IndexOfRoom2TunnelGo { get; set; }
    }
}
