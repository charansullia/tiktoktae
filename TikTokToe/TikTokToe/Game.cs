using System;
using System.Collections.Generic;
using System.Text;

namespace TikTokToe
{
   public class Game
    {
        public char player;
        public char computer;
        public char[] gameboard = new char[10];
        public void tik()
        {
          for(int i=0;i<10;i++)
            {
                gameboard[i] = ' ';
            }
            
        }
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
        public void showboard()
        {
            Console.WriteLine(" "+gameboard[0]+"|\t"+ " "+gameboard[1]+"|\t"+gameboard[2]);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" " + gameboard[3] + "|\t" + " " + gameboard[4] + "|\t" + gameboard[5]);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" " + gameboard[6] + "|\t" + " " + gameboard[7] + "|\t" + gameboard[8]);
            Console.WriteLine("-------------------------------");
        }


    }
}
