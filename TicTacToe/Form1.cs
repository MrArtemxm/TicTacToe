using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        GameInfo gameInfo = new GameInfo();
        GameStatus gameStatus = new GameStatus();
        AI ai = new AI();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            player1Selection.Text = "Крестики";
            player2Selection.Text = "Нолики";
            gameInfo.againstAi = true;
            gameInfo.crossZeroChosenBy = 12;
            gameStatus.turns = 0;

        }
        private void beginButton_Click(object sender, EventArgs e)
        {
            toDefault();
        }

        private void panelOnClick(object sender, MouseEventArgs e)
        {
            Hashtable panelFigure = new Hashtable();
            panelFigure.Add("panel1", "0");
            panelFigure.Add("panel2", "1");
            panelFigure.Add("panel3", "2");
            panelFigure.Add("panel4", "3");
            panelFigure.Add("panel5", "4");
            panelFigure.Add("panel6", "5");
            panelFigure.Add("panel7", "6");
            panelFigure.Add("panel8", "7");
            panelFigure.Add("panel9", "8");
            if (gameStatus.gameIsStarted)
            {
                if ((gameStatus.currentPlayer == 1 || (gameStatus.currentPlayer == 2 && gameStatus.againstAiNow)) && (gameStatus.checkedField[Convert.ToInt32(panelFigure[(sender as Panel).Name])] =='?'))
                {
                    if (gameStatus.currentPlayer == 1)
                    {
                        onFigureSet(12, Convert.ToInt32(panelFigure[(sender as Panel).Name]), 2, sender as Panel);

                    }

                    if (gameStatus.againstAiNow && gameStatus.checkForWin() == 0)
                    {
                        switch (ai.doMove(gameStatus.checkedField,gameStatus.crossZeroChosenByNow))
                        {
                            case 0:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel1 as Panel);
                                break;
                            case 1:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel2 as Panel);
                                break;
                            case 2:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel3 as Panel);
                                break;
                            case 3:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel4 as Panel);
                                break;
                            case 4:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel5 as Panel);
                                break;
                            case 5:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel6 as Panel);
                                break;
                            case 6:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel7 as Panel);
                                break;
                            case 7:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel8 as Panel);
                                break;
                            case 8:
                                onFigureSet(21, ai.doMove(gameStatus.checkedField, gameStatus.crossZeroChosenByNow),
                                1, panel9 as Panel);
                                break;
                        }

                        
                    } else
                    {
                        gameStatus.currentPlayer = 2;
                    }

                }

                if (gameStatus.currentPlayer == 2 && !gameStatus.againstAiNow)
                {
                    onFigureSet(21, Convert.ToInt32(panelFigure[(sender as Panel).Name]), 1, sender as Panel);
                }

            }

            gameStatus.checkForWin();
            

            if (gameStatus.checkForWin() == 1 || gameStatus.checkForWin() == 2)
            {
                if(gameStatus.checkForWin() == 2)
                {
                    gameInfo.player1Score +=1;
                    playerOneScoreField.Text = Convert.ToString(gameInfo.player1Score);
                    MessageBox.Show("Победа игрока 1", "Конец игры", MessageBoxButtons.OK);
                    toDefault();                    
                }

                if (gameStatus.checkForWin() == 1)
                {
                    gameInfo.player2Score += 1;
                    playerTwoScoreField.Text  = Convert.ToString(gameInfo.player2Score);
                    MessageBox.Show("Победа игрока 2", "Конец игры", MessageBoxButtons.OK);
                    toDefault();
                }
            }

            if (gameStatus.turns == 9)
            {
                MessageBox.Show("Ничья", "Конец игры", MessageBoxButtons.OK);
                toDefault();
                gameInfo.drawsScore += 1;
                drawsScoreField.Text = Convert.ToString(gameInfo.drawsScore);
            }

        }

        private void player2OnChange(object sender, EventArgs e)
        {
            if (player2Selection.Text == "Крестики")
            {
                player1Selection.Text = "Нолики";
                gameInfo.crossZeroChosenBy = 21;
            }
            else
            {
                player1Selection.Text = "Крестики";
                gameInfo.crossZeroChosenBy = 12;
            }
        }

        private void player1OnChange(object sender, EventArgs e)
        {
            if(player1Selection.Text == "Крестики")
            {
                player2Selection.Text = "Нолики";
                gameInfo.crossZeroChosenBy = 12;
            } else
            {
                player2Selection.Text = "Крестики";
                gameInfo.crossZeroChosenBy = 21;
            }
        }

        private void againstChanged(object sender, EventArgs e)
        { 
            if ((sender as RadioButton).Name =="radioButton1" )
            {
                gameInfo.againstAi = true;
            } else
            {
                gameInfo.againstAi = false;
            }
        }

        private void toDefault()
        {
            panel1.BackgroundImage = null;
            panel1.BackColor = Color.White;
            panel2.BackgroundImage = null;
            panel2.BackColor = Color.White;
            panel3.BackgroundImage = null;
            panel3.BackColor = Color.White;
            panel4.BackgroundImage = null;
            panel4.BackColor = Color.White;
            panel5.BackgroundImage = null;
            panel5.BackColor = Color.White;
            panel6.BackgroundImage = null;
            panel6.BackColor = Color.White;
            panel7.BackgroundImage = null;
            panel7.BackColor = Color.White;
            panel8.BackgroundImage = null;
            panel8.BackColor = Color.White;
            panel9.BackgroundImage = null;
            panel9.BackColor = Color.White;
            gameStatus.crossZeroChosenByNow = gameInfo.crossZeroChosenBy;
            gameStatus.againstAiNow = gameInfo.againstAi;
            gameStatus.gameIsStarted = true;
            gameStatus.currentPlayer = random.Next(1, 3);
            gameStatus.turns = 0;
            turnCountLabel.Text = "0";
            turnLabel.Text = "Очередь игрока: ";
            turnLabel.Text += Convert.ToString(gameStatus.currentPlayer);
            for (int i = 0; i <= 8; i++)
            {
                gameStatus.checkedField[i] = '?';
            }

        }

        private void onFigureSet(byte crossZero, int indexOfFigure, int nextPlayer, Panel sndr)
        {
            if (gameStatus.checkForFigure(gameStatus.checkedField[indexOfFigure]))
            {
                if (gameStatus.crossZeroChosenByNow == crossZero)
                {
                    gameStatus.checkedField[indexOfFigure] = 'x';
                    sndr.BackgroundImage = Properties.Resources.cross;
                    gameStatus.currentPlayer = nextPlayer;
                    gameStatus.turns += 1;
                    turnCountLabel.Text = Convert.ToString(gameStatus.turns);
                    turnLabel.Text = "Очередь игрока: ";
                    turnLabel.Text += Convert.ToString(gameStatus.currentPlayer);

                }
                else
                {
                    gameStatus.checkedField[indexOfFigure] = 'o';
                    sndr.BackgroundImage = Properties.Resources.zero;
                    gameStatus.currentPlayer = nextPlayer;
                    gameStatus.turns += 1;
                    turnCountLabel.Text = Convert.ToString(gameStatus.turns);
                    turnLabel.Text = "Очередь игрока: ";
                    turnLabel.Text += Convert.ToString(gameStatus.currentPlayer);
                }
            }



        }
    }
}
