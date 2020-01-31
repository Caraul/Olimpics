using System;
using System.Collections.Generic;
using System.Linq;

namespace Labirint
{
    public class Map
    {
        public Tunnel[] tunnels { get; set; }
        public Room1[] rooms1 { get; set; }
        public Room2[] rooms2 { get; set; }
        public Map(string descriptionOfMap)
        {
            var descriptionOfMapArray = descriptionOfMap.Split(" ").Select(part => int.Parse(part)).ToArray();
            tunnels = new Tunnel[descriptionOfMapArray[2]];
            rooms1 = new Room1[descriptionOfMapArray[0]];
            rooms2 = new Room2[descriptionOfMapArray[1]];
            for (var index = 0; index != tunnels.Length; index++)
            {
                tunnels[index] = new Tunnel();
                tunnels[index].HasExit = index <= descriptionOfMapArray[3] && index != 0;
            }
        }
    }
}
