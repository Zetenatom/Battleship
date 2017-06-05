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


        public bool validPlacement = true;

        public void AIShipGen()
        {
            int shipNumber = 1;
            Random rand = new Random();

            do
            {

                switch (shipNumber)
                {
                    case 1:
                        placeAiShips(2, rand.Next(1, 5));
                        shipNumber++;
                        break;
                    case 2:
                        placeAiShips(3, rand.Next(1, 5));
                        shipNumber++;
                        break;
                    case 3:
                        placeAiShips(3, rand.Next(1, 5));
                        shipNumber++;
                        break;
                    case 4:
                        placeAiShips(4, rand.Next(1, 5));
                        shipNumber++;
                        break;
                    case 5:
                        placeAiShips(5, rand.Next(1, 5));
                        shipNumber++;
                        break;
                }
            } while (shipNumber < 6);
        }


        public void placeAiShips(int shipSize, int direction)
        {
            string orientation = "";
            if (direction == 1)
            {
                orientation = "Up";
            }
            else if (direction == 2)
            {
                orientation = "Right";
            }
            else if (direction == 3)
            {
                orientation = "Left";
            }
            else
            {
                orientation = "Down";
            }
            Random rand = new Random();
            do
            {
                validLocation(shipSize, rand.Next(1, 11), rand.Next(12, 23), orientation, Models.Board.Board.BattleBoard);
            } while (!validPlacement);
        }

        public void validLocation(int shipSize, int row, int column, string direction, Enum.TileStates[,] board)
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
                    //up
                    Enum.TileStates tileEnd = board[row - shipSize + 1, column];
                    if (tileEnd == Enum.TileStates.WATER)
                    {
                        for (int i = row; i > row - shipSize; i--)
                        {
                            if (board[column, i] != Enum.TileStates.WATER)
                            {
                                validPlacement = false;
                                return;
                            }
                        }

                    }
                    else
                    {
                        validPlacement = false;
                        return;
                    }
                    for (int i = row; i > row - shipSize; i--)
                    {
                        ColorTheLabels(column, i);
                    }
                    validPlacement = true;
                    break;
                case 2:
                    //right
                    Enum.TileStates tileEnd2 = board[row, column + shipSize - 1];
                    if (tileEnd2 == Enum.TileStates.WATER)
                    {
                        for (int i = column; i < column + shipSize; i++)
                        {
                            if (board[i, row] != Enum.TileStates.WATER)
                            {
                                validPlacement = false;
                                return;
                            }

                        }
                    }
                    else
                    {
                        validPlacement = false;
                        return;
                    }
                    for (int i = column; i < column + shipSize; i++)
                    {
                        ColorTheLabels(i, row);
                    }
                    validPlacement = true;
                    break;
                case 3:
                    //left
                    Enum.TileStates tileEnd3 = board[row, column - shipSize + 1];
                    if (tileEnd3 == Enum.TileStates.WATER)
                    {
                        for (int i = column; i > column - shipSize; i--)
                        {

                            if (board[i, row] != Enum.TileStates.WATER)
                            {
                                validPlacement = false;
                                return;
                            }

                        }
                    }
                    else
                    {
                        validPlacement = false;
                        return;
                    }
                    for (int i = column; i > column - shipSize; i--)
                    {
                        ColorTheLabels(i, row);
                    }
                    validPlacement = true;
                    break;
                case 4:
                    //down
                    Enum.TileStates tileEnd4 = board[row + shipSize - 1, column];
                    if (tileEnd4 == Enum.TileStates.WATER)
                    {
                        for (int j = row; j > row + shipSize; j++)
                        {
                            if (board[column, j] != Enum.TileStates.WATER)
                            {
                                validPlacement = false;
                                return;
                            }
                        }
                    }
                    else
                    {
                        validPlacement = false;
                        return;
                    }
                    for (int i = row; i < row + shipSize; i++)
                    {
                        ColorTheLabels(column, i);
                    }
                    validPlacement = true;
                    break;
            }

        }

        public void ColorTheLabels(int column, int row)
        {
            foreach (object label in Board.Children)
            {
                if (label.GetType() == typeof(Label))
                {
                    if (Grid.GetColumn((Label)label) == column && Grid.GetRow((Label)label) == row)
                    {
                        ((Label)label).Background = Brushes.Gray;
                    }
                }
            }
        }

        public static int selectedColumn;
        public static int selectedRow;
        Label leb;

        private void Place_Ship(object sender, MouseEventArgs e)
        {
            Models.Board.Board.CreateBoard();
            leb = (Label)sender;
            selectedColumn = Grid.GetColumn(leb);
            selectedRow = Grid.GetRow(leb);

            do
            {
                DirectionalPop.IsOpen = true;
                if (shipNumber == 6)
                {
                    shipNumber = 1;
                    break;
                }
            } while (!validPlacement);
        }

        public int shipNumber = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button selected = (Button)sender;
            string direction = (string)selected.Content;

            switch (shipNumber)
            {
                case 1:
                    validLocation(2, selectedRow, selectedColumn, direction, Models.Board.Board.BattleBoard);
                    if (validPlacement == false)
                    {
                        break;
                    }
                    shipNumber++;
                    break;
                case 2:
                    validLocation(2, selectedRow, selectedColumn, direction, Models.Board.Board.BattleBoard);
                    if (validPlacement == false)
                    {
                        break;
                    }
                    shipNumber++;
                    break;
                case 3:
                    validLocation(2, selectedRow, selectedColumn, direction, Models.Board.Board.BattleBoard);
                    if (validPlacement == false)
                    {
                        break;
                    }
                    shipNumber++;
                    break;
                case 4:
                    validLocation(2, selectedRow, selectedColumn, direction, Models.Board.Board.BattleBoard);
                    if (validPlacement == false)
                    {
                        break;
                    }
                    shipNumber++;
                    break;
                case 5:
                    validLocation(2, selectedRow, selectedColumn, direction, Models.Board.Board.BattleBoard);
                    if (validPlacement == false)
                    {
                        break;
                    }
                    shipNumber++;
                    break;
            }

            DirectionalPop.IsOpen = false;
        }
    }
}
