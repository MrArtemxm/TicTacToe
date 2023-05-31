using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class AI
    {
        public int doMove(char[] checkedFields, byte chosenFigure)
        {
            Random aiRandom = new Random();
            int[] possibleIndexes = new int[9];
            for(int i = 0; i<=8; i++)
            {
                if (checkedFields[i] == '?')
                {
                    possibleIndexes[i] = i;
                }
                
            }

            return possibleIndexes[aiRandom.Next(0,possibleIndexes.Length)];
        }
    }
}
