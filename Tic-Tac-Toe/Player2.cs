using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Player2
    {
        public string printresult(int player)
        {
            if (player > 0 && player <= 9)
            {
                return "O";
                ;
            }
            else
            {
                return "Wrong number";
            }
        }
    }
}
