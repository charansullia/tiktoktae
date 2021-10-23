using System;
using System.Collections.Generic;
using System.Text;

namespace TikTokToe
{
   public class Game
    {
        public char[,] gameboard = new char[10, 10];
        public void tik()
        {
            Console.WriteLine("A B C\n");
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<10;j++)
                {
                    Console.Write("|"+gameboard[i,j]);
                }
                Console.Write("\n\n");
            }
        }
    }
}
