using System;
using System.Collections.Generic;
using System.Linq;

namespace Labirint
{
    public class Room2
    {
        int IndexOfTunnelPigWillGoToThroughPositive, IndexOfTunnelPigWillGoToThroughNegative, IndexOfTunnelPigWillGoToThroughNull;
        public int IndexOfTunnelPigCameFrom { get; set; }
        int[] PostfixVariables;
        public Room2(string descriptionOfRoom)
        {
            var descriptionOfRoomArray = descriptionOfRoom.Split(" ").Select(part => int.Parse(part)).ToArray();
            IndexOfTunnelPigCameFrom = descriptionOfRoomArray[0];
            IndexOfTunnelPigWillGoToThroughPositive = descriptionOfRoomArray[1];
            IndexOfTunnelPigWillGoToThroughNegative = descriptionOfRoomArray[2];
            IndexOfTunnelPigWillGoToThroughNull = descriptionOfRoomArray[3];
            PostfixVariables = descriptionOfRoomArray.Skip(5).ToArray();
        }
        public int IndexOfTunnelWhichPigGo(int[] variables)
        {
            var exprNum = new Expr(PostfixVariables).CountExprNum(variables);
            if (exprNum > 0)
            {
                return IndexOfTunnelPigWillGoToThroughPositive;
            }
            else if (exprNum < 0)
            {
                return IndexOfTunnelPigWillGoToThroughNegative;
            }
            return IndexOfTunnelPigWillGoToThroughNull;
        }
    }
}
