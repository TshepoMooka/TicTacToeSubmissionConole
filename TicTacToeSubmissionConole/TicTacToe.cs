using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        public string[] row = new string[9] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public int choice;
        static int player = 1;
        public static object arr;
        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }


        public void PlayerOne()
        {

            Console.SetCursorPosition(28, 19);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(2, 19);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("PlayerOne:X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();
         
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

        }

        public void PlayerTwo()
        {

            Console.SetCursorPosition(28, 19);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(2, 25);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("PlayerTwo");


            Console.SetCursorPosition(2, 26);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 28);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


        
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);
        }





        public bool coordinateWin()
        {
            for (int x = 1; x < player; ++x)
            {

            }

            Console.WriteLine("\n");

            if (player % 1 == 0)

            {

                Console.WriteLine("Player One's Chance");

            }

            else

            {

                Console.WriteLine("Player Two's chance");

            }
            Console.WriteLine("\n");
            if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }

            if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {

            }
            return false;
        }

    }


}
