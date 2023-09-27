using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tic_Tac_Toe
{
    internal class Player1
    {
         public string printresult(int player)
         {
            if(player > 0 && player <= 9)
            {
                return "X";
;           }
            else
            {
                return "Something WRONG";
            }
         }
    }
}
