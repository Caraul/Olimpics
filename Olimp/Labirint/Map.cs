using System;
using System.Collections.Generic;
using System.Linq;

namespace Labirint
{
    public class Map
    {
        public Tunnel[] tunnels;
        public Room1[] rooms1;
        public Room2[] rooms2;
        public Map(string descriptionOfMap)
        {
            var descriptionOfMapArray = descriptionOfMap.Split(" ").Select(part => int.Parse(part)).ToArray();
            tunnels = new Tunnel[descriptionOfMapArray[2]];
            rooms1 = new Room1[descriptionOfMapArray[0]];
            rooms2 = new Room2[descriptionOfMapArray[1]];
            for (var index = 0; index != tunnels.Length; index++)
            {
                tunnels[index] = new Tunnel();
                if (index <= descriptionOfMapArray[3] && index != 0)
                {
                    tunnels[index].HasExit = true;
                }
            }
        }
    }
}
