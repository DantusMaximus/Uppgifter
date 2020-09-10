using System;
namespace Luffarshack
{
    static class Board{
        static public void Construct(char[,] board)
        {
            for(int i =0; i<=2;i++)
            {
                for(int j = 0; j<=2;j++)
                {
                board[i, j] = ' ';
                }
            }
        }
        static public void DrawBoard(char[,] board)
        {
            Console.WriteLine("  1 2 3");
            Console.WriteLine(" =======");
            Console.WriteLine($"1|{board[0, 0]}|{board[1, 0]}|{board[2, 0]}|");
            Console.WriteLine(" =======");
            Console.WriteLine($"2|{board[0, 1]}|{board[1, 1]}|{board[2, 1]}|");
            Console.WriteLine(" =======");
            Console.WriteLine($"3|{board[0, 2]}|{board[1, 2]}|{board[2, 2]}|");
            Console.WriteLine(" =======");
        }
        
    }


    class Game{
        public bool ongoing;
        public char turn;
        public char winner;
        public Game()
        {
            ongoing = true;
            turn = 'O';
            winner = ' ';
        }
        public void Turn(char[,] board, Game game)
        {
            Console.WriteLine();
            if(turn == 'O')
            {
                Console.WriteLine("Ring?");
            }
            else
            {
                Console.WriteLine("Kryss?");
            }

            int coordinates;

            try
            {
                coordinates = Int32.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Felinmatning");
                return;
            }
            int y = coordinates % 10;
            int x = coordinates / 10;
            x--;
            y--;
            if(!((2>=x && x>=0) && (2>=y && y>=0)))
            {
                Console.WriteLine("Felinmatning");
                return;
            }
            if(board[x, y] != ' ')
            {
                Console.WriteLine("Felinmatning");
                return;
            } 
            board[x, y] = turn;
            if(game.turn == 'O')
            {
                game.turn = 'X';
            }
            else
            {
                game.turn = 'O';
            }
        }
        public void Over(char[,] board, Game game)
        {
            for(int x = 0; x<=2; ++x)//kollar efter vinnare kollumnvis
            {
                if(board[x, 0] == ' ');
                else if(board[x, 0] == board[x, 1] && board[x, 1] == board[x, 2])
                {
                    game.ongoing = false;
                    game.winner = board[x, 0];
                }
            }
            for(int y = 0; y<=2; ++y)//radvis
            {
                if(board[0, y] == ' ');
                else if(board[0, y] == board[1, y] && board[1, y] == board[2, y])
                {
                    game.ongoing = false;
                    game.winner = board[0, y];
                }
            }
            if(board[1, 1] == ' ');
            else if((board[0,0] == board[1,1] && board[1,1] == board[2,2]) || (board[2,0] == board[1,1] && board[1,1] == board[0,2])) //diagonalt
            {
                game.ongoing = false;
                game.winner = board[1,1];
            }
            foreach(var boardpiece in board)//Kollar om det finns spelpjäser på alla platser
            {
                if(boardpiece == ' ')
                {
                    return;
                }
            }
            game.ongoing = false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            char[,] board = new char[3,3];
            Board.Construct(board);
            while(game.ongoing)
            {
                Board.DrawBoard(board);
                game.Turn(board, game);
                game.Over(board, game);
            }
            Board.DrawBoard(board);
            if(game.winner == ' ')
            {
                Console.WriteLine("Oavgjort");
            }
            else if(game.winner == 'O')
            {
                Console.WriteLine("Ring vann!");
            }
            else{
                Console.WriteLine("Kryss vann!");
            }
        }
    }
}