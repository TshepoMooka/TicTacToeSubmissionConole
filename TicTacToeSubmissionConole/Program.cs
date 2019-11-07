using System;

namespace TicTacToeSubmissionConole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.SetCursorPosition(10, 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome regular show to Tic Tac Toe");

            var ticTacToe = new TicTacToe();

            ticTacToe.PlayerOne();
            ticTacToe.PlayerTwo();
            ticTacToe.PlayerOne();
            ticTacToe.PlayerTwo();
            ticTacToe.PlayerOne();
            ticTacToe.PlayerTwo();
            ticTacToe.coordinateWin();



            Console.ForegroundColor = oldColor;



            Console.SetCursorPosition(20, 30);
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
    }
}
