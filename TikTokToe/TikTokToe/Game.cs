using System;
using System.Collections.Generic;
using System.Text;

namespace TikTokToe
{
   public class Game
    {
        public char player;
        public char computer;
        //public char[] gameboard = new char[10,10];
        //public void tik()
        //{
        //    Console.WriteLine("A B C\n");
        //    for(int i=0;i<10;i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            Console.Write("|" + gameboard[i, j]);
        //        }
        //        Console.Write("\n\n");
        //    }
        //}
        public void chooseoption()
        {
            Console.WriteLine("enter option X or Y");
            char option = Convert.ToChar(Console.ReadLine());
            switch(option)
            {
                case 'X':
                    Console.WriteLine("player");
                    break;
                case 'O':
                    Console.WriteLine("computer");
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }


    }
}
