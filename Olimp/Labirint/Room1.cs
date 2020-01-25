using System;
using System.Collections.Generic;
using System.Linq;

namespace Labirint
{
    public class Room1
    {
        public int IndexOfTunnelPigCameFrom, IndexOfTunnelPigWillGoTo, IndexOfVariable;
        int[] PostfixVariables;
        public Room1(string descriptionOfRoom)
        {
            var descriptionOfRoomArray = descriptionOfRoom.Split(" ").Select(part => int.Parse(part)).ToArray();
            IndexOfTunnelPigCameFrom = descriptionOfRoomArray[0];
            IndexOfTunnelPigWillGoTo = descriptionOfRoomArray[1];
            IndexOfVariable = descriptionOfRoomArray[2];
            PostfixVariables = descriptionOfRoomArray.Skip(4).ToArray();
        }
        public int[] WalkedThrough(int[] variables)
        {
            variables[IndexOfVariable] = new Expr(PostfixVariables).CountExprNum(variables);
            return variables;
        }
    }
}
