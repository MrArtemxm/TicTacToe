using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameStatus
    {
        public byte turns = 0;
        public char[] checkedField = { '?', '?', '?', '?', '?', '?', '?', '?', '?' };
        public bool gameIsStarted = false;
        public int currentPlayer = 0;
        public byte crossZeroChosenByNow = 0;
        public bool againstAiNow = true;

        public int checkForWin()
        {
            if ((checkedField[0] == 'x' && checkedField[3] == 'x' && checkedField[6] == 'x') || (
                checkedField[1] == 'x' && checkedField[4] == 'x' && checkedField[7] == 'x')
                || (checkedField[2] == 'x' && checkedField[5] == 'x' && checkedField[8] == 'x')
                || (
                checkedField[0] == 'x' && checkedField[1] == 'x' && checkedField[2] == 'x') || (
                checkedField[3] == 'x' && checkedField[4] == 'x' && checkedField[5] == 'x') || (
                checkedField[6] == 'x' && checkedField[7] == 'x' && checkedField[8] == 'x')
                || (
                checkedField[0] == 'x' && checkedField[4] == 'x' && checkedField[8] == 'x') || (
                checkedField[6] == 'x' && checkedField[4] == 'x' && checkedField[2] == 'x'))
            {
                return this.currentPlayer;
            } 

            if ((checkedField[0] == 'o' && checkedField[3] == 'o' && checkedField[6] == 'o') || (
                checkedField[1] == 'o' && checkedField[4] == 'o' && checkedField[7] == 'o')
                || (checkedField[2] == 'o' && checkedField[5] == 'o' && checkedField[8] == 'o')
                || (
                checkedField[0] == 'o' && checkedField[1] == 'o' && checkedField[2] == 'o') || (
                checkedField[3] == 'o' && checkedField[4] == 'o' && checkedField[5] == 'o') || (
                checkedField[6] == 'o' && checkedField[7] == 'o' && checkedField[8] == 'o')
                || (
                checkedField[0] == 'o' && checkedField[4] == 'o' && checkedField[8] == 'o') || (
                checkedField[6] == 'o' && checkedField[4] == 'o' && checkedField[2] == 'o'))
            {
                return this.currentPlayer;
            }

            return 0;

        }
        
        public bool checkForFigure(char testSymbol)
        {
            if(testSymbol == '?')
            {
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
