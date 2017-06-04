using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Battleship
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public void Fire_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label selected = (Label)sender;
            int selectedColumn = Grid.GetColumn(selected);
            int selectedRow = Grid.GetRow(selected);

            Enum.TileStates tileT = Controller.Controller.FireCannons(selectedColumn, selectedRow);


            if (tileT == Enum.TileStates.HIT)
            {

                selected.Background = Brushes.Red;
            }
            else
            {
                selected.Background = Brushes.White;
            }

        }

        public void disableLabels()
        {
            P2A1.IsEnabled = false;
            P2A2.IsEnabled = false;
            P2A3.IsEnabled = false;
            P2A4.IsEnabled = false;
            P2A5.IsEnabled = false;
            P2A6.IsEnabled = false;
            P2A7.IsEnabled = false;
            P2A8.IsEnabled = false;
            P2A9.IsEnabled = false;
            P2A10.IsEnabled = false;
            P2B1.IsEnabled = false;
            P2B2.IsEnabled = false;
            P2B3.IsEnabled = false;
            P2B4.IsEnabled = false;
            P2B5.IsEnabled = false;
            P2B6.IsEnabled = false;
            P2B7.IsEnabled = false;
            P2B8.IsEnabled = false;
            P2B9.IsEnabled = false;
            P2B10.IsEnabled = false;
            P2C1.IsEnabled = false;
            P2C2.IsEnabled = false;
            P2C3.IsEnabled = false;
            P2C4.IsEnabled = false;
            P2C5.IsEnabled = false;
            P2C6.IsEnabled = false;
            P2C7.IsEnabled = false;
            P2C8.IsEnabled = false;
            P2C9.IsEnabled = false;
            P2C10.IsEnabled = false;
            P2D1.IsEnabled = false;
            P2D2.IsEnabled = false;
            P2D3.IsEnabled = false;
            P2D4.IsEnabled = false;
            P2D5.IsEnabled = false;
            P2D6.IsEnabled = false;
            P2D7.IsEnabled = false;
            P2D8.IsEnabled = false;
            P2D9.IsEnabled = false;
            P2D10.IsEnabled = false;
            P2E1.IsEnabled = false;
            P2E2.IsEnabled = false;
            P2E3.IsEnabled = false;
            P2E4.IsEnabled = false;
            P2E5.IsEnabled = false;
            P2E6.IsEnabled = false;
            P2E7.IsEnabled = false;
            P2E8.IsEnabled = false;
            P2E9.IsEnabled = false;
            P2E10.IsEnabled = false;
            P2F1.IsEnabled = false;
            P2F2.IsEnabled = false;
            P2F3.IsEnabled = false;
            P2F4.IsEnabled = false;
            P2F5.IsEnabled = false;
            P2F6.IsEnabled = false;
            P2F7.IsEnabled = false;
            P2F8.IsEnabled = false;
            P2F9.IsEnabled = false;
            P2F10.IsEnabled = false;
            P2G1.IsEnabled = false;
            P2G2.IsEnabled = false;
            P2G3.IsEnabled = false;
            P2G4.IsEnabled = false;
            P2G5.IsEnabled = false;
            P2G6.IsEnabled = false;
            P2G7.IsEnabled = false;
            P2G8.IsEnabled = false;
            P2G9.IsEnabled = false;
            P2G10.IsEnabled = false;
            P2H1.IsEnabled = false;
            P2H2.IsEnabled = false;
            P2H3.IsEnabled = false;
            P2H4.IsEnabled = false;
            P2H5.IsEnabled = false;
            P2H6.IsEnabled = false;
            P2H7.IsEnabled = false;
            P2H8.IsEnabled = false;
            P2H9.IsEnabled = false;
            P2H10.IsEnabled = false;
            P2I1.IsEnabled = false;
            P2I2.IsEnabled = false;
            P2I3.IsEnabled = false;
            P2I4.IsEnabled = false;
            P2I5.IsEnabled = false;
            P2I6.IsEnabled = false;
            P2I7.IsEnabled = false;
            P2I8.IsEnabled = false;
            P2I9.IsEnabled = false;
            P2I10.IsEnabled = false;
            P2J1.IsEnabled = false;
            P2J2.IsEnabled = false;
            P2J3.IsEnabled = false;
            P2J4.IsEnabled = false;
            P2J5.IsEnabled = false;
            P2J6.IsEnabled = false;
            P2J7.IsEnabled = false;
            P2J8.IsEnabled = false;
            P2J9.IsEnabled = false;
            P2J10.IsEnabled = false;

        }
        public void enableLabels()
        {
            P2A1.IsEnabled = true;
            P2A2.IsEnabled = true;
            P2A3.IsEnabled = true;
            P2A4.IsEnabled = true;
            P2A5.IsEnabled = true;
            P2A6.IsEnabled = true;
            P2A7.IsEnabled = true;
            P2A8.IsEnabled = true;
            P2A9.IsEnabled = true;
            P2A10.IsEnabled = true;
            P2B1.IsEnabled = true;
            P2B2.IsEnabled = true;
            P2B3.IsEnabled = true;
            P2B4.IsEnabled = true;
            P2B5.IsEnabled = true;
            P2B6.IsEnabled = true;
            P2B7.IsEnabled = true;
            P2B8.IsEnabled = true;
            P2B9.IsEnabled = true;
            P2B10.IsEnabled = true;
            P2C1.IsEnabled = true;
            P2C2.IsEnabled = true;
            P2C3.IsEnabled = true;
            P2C4.IsEnabled = true;
            P2C5.IsEnabled = true;
            P2C6.IsEnabled = true;
            P2C7.IsEnabled = true;
            P2C8.IsEnabled = true;
            P2C9.IsEnabled = true;
            P2C10.IsEnabled = true;
            P2D1.IsEnabled = true;
            P2D2.IsEnabled = true;
            P2D3.IsEnabled = true;
            P2D4.IsEnabled = true;
            P2D5.IsEnabled = true;
            P2D6.IsEnabled = true;
            P2D7.IsEnabled = true;
            P2D8.IsEnabled = true;
            P2D9.IsEnabled = true;
            P2D10.IsEnabled = true;
            P2E1.IsEnabled = true;
            P2E2.IsEnabled = true;
            P2E3.IsEnabled = true;
            P2E4.IsEnabled = true;
            P2E5.IsEnabled = true;
            P2E6.IsEnabled = true;
            P2E7.IsEnabled = true;
            P2E8.IsEnabled = true;
            P2E9.IsEnabled = true;
            P2E10.IsEnabled = true;
            P2F1.IsEnabled = true;
            P2F2.IsEnabled = true;
            P2F3.IsEnabled = true;
            P2F4.IsEnabled = true;
            P2F5.IsEnabled = true;
            P2F6.IsEnabled = true;
            P2F7.IsEnabled = true;
            P2F8.IsEnabled = true;
            P2F9.IsEnabled = true;
            P2F10.IsEnabled = true;
            P2G1.IsEnabled = true;
            P2G2.IsEnabled = true;
            P2G3.IsEnabled = true;
            P2G4.IsEnabled = true;
            P2G5.IsEnabled = true;
            P2G6.IsEnabled = true;
            P2G7.IsEnabled = true;
            P2G8.IsEnabled = true;
            P2G9.IsEnabled = true;
            P2G10.IsEnabled = true;
            P2H1.IsEnabled = true;
            P2H2.IsEnabled = true;
            P2H3.IsEnabled = true;
            P2H4.IsEnabled = true;
            P2H5.IsEnabled = true;
            P2H6.IsEnabled = true;
            P2H7.IsEnabled = true;
            P2H8.IsEnabled = true;
            P2H9.IsEnabled = true;
            P2H10.IsEnabled = true;
            P2I1.IsEnabled = true;
            P2I2.IsEnabled = true;
            P2I3.IsEnabled = true;
            P2I4.IsEnabled = true;
            P2I5.IsEnabled = true;
            P2I6.IsEnabled = true;
            P2I7.IsEnabled = true;
            P2I8.IsEnabled = true;
            P2I9.IsEnabled = true;
            P2I10.IsEnabled = true;
            P2J1.IsEnabled = true;
            P2J2.IsEnabled = true;
            P2J3.IsEnabled = true;
            P2J4.IsEnabled = true;
            P2J5.IsEnabled = true;
            P2J6.IsEnabled = true;
            P2J7.IsEnabled = true;
            P2J8.IsEnabled = true;
            P2J9.IsEnabled = true;
            P2J10.IsEnabled = true;

        }

        public static bool placeAiShips(int row, int column, string direction)
        {
            int shipNumber = 1;

            switch (shipNumber)
            {
                case 1:
                    if (validLocation(2, row, column, direction, Models.Board.Board.BattleBoard))
                    {
                        Models.Board.Board.BattleBoard[column, row] = Enum.TileStates.BOAT;
                        shipNumber++;
                    }
                    return false;
                case 2:
                    if (validLocation(3, row, column, direction, Models.Board.Board.BattleBoard))
                    {
                        Models.Board.Board.BattleBoard[column, row] = Enum.TileStates.BOAT;
                        shipNumber++;
                    }
                    return false;
                case 3:
                    if (validLocation(3, row, column, direction, Models.Board.Board.BattleBoard))
                    {
                        Models.Board.Board.BattleBoard[column, row] = Enum.TileStates.BOAT;
                        shipNumber++;
                    }
                    return false;
                case 4:
                    if (validLocation(4, row, column, direction, Models.Board.Board.BattleBoard))
                    {
                        Models.Board.Board.BattleBoard[column, row] = Enum.TileStates.BOAT;
                        shipNumber++;
                    }
                    return false;
                case 5:
                    if (validLocation(5, row, column, direction, Models.Board.Board.BattleBoard))
                    {
                        Models.Board.Board.BattleBoard[column, row] = Enum.TileStates.BOAT;
                        shipNumber++;
                    }
                    return false;
            }
            return false;
        }

        public static bool validLocation(int shipSize, int row, int column, string direction, Enum.TileStates[,] board)
        {
            int directionNum;
            if (direction == "Up")
            {
                directionNum = 1;
            }
            else if (direction == "Right")
            {
                directionNum = 2;
            }
            else if (direction == "Left")
            {
                directionNum = 3;
            }
            else
            {
                directionNum = 4;
            }
            

            switch (directionNum)
            {
                case 1:
                    Enum.TileStates tileEnd = board[row - shipSize + 1, column];
                    if (tileEnd == Enum.TileStates.WATER)
                    {
                        for (int i = column; i < column + 1; i++)
                        {
                            for (int j = row; j > row - shipSize; j--)
                            {
                                if (board[i, j] != Enum.TileStates.WATER)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                case 2:
                    Enum.TileStates tileEnd2 = board[row, column + shipSize - 1];
                    if (tileEnd2 == Enum.TileStates.WATER)
                    {
                        for (int i = column; i < column + shipSize; i++)
                        {
                            for (int j = row; j < row + 1; j++)
                            {
                                if (board[i, j] != Enum.TileStates.WATER)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                case 3:
                    Enum.TileStates tileEnd3 = board[row, column - shipSize + 1];
                    if (tileEnd3 == Enum.TileStates.WATER)
                    {
                        for (int i = column; i > column - shipSize; i--)
                        {
                            for (int j = row; j < row - 1; j--)
                            {
                                if (board[i, j] != Enum.TileStates.WATER)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                    return false;
                case 4:
                    Enum.TileStates tileEnd4 = board[row + shipSize - 1, column];
                    if (tileEnd4 == Enum.TileStates.WATER)
                    {
                        for (int i = column; i < column + 1; i++)
                        {
                            for (int j = row; j > row + shipSize; j++)
                            {
                                if (board[i, j] != Enum.TileStates.WATER)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                    return true;
            }
            
            return true;
        }


        public static int selectedColumn;
        public static int selectedRow;

        private void Place_Ship(object sender, MouseEventArgs e)
        {
            Label leb = (Label)sender;
            DirectionalPop.IsOpen = true;
            selectedColumn = Grid.GetColumn(leb);
            selectedRow = Grid.GetRow(leb);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button selected = (Button)sender;
            string direction = (string)selected.Content;
            //validLocation(2, selectedRow, selectedColumn, direction, Models.Board.Board.());

        }
    }
}
