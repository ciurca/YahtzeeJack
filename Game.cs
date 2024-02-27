using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeJack
{
    public class Game
    {
        public List<int> dice { get; set;}
        public List<int> selectedDice { get; set; }
        public int rollsLeft { get; set; }
        public List<int> indexOfSelectedDice { get
            {
                List<int> indexes = new List<int>(); 
                for(int i = 0; i<5; i++)
                {
                    if (this.selectedDice[i] == 1)
                    {
                        indexes.Add(i);
                    }
                }
                return indexes;
            } }
        public Game()
        {
            int[] input = { 1, 1, 1, 1, 1 };
            int[] inputSelectedDice = { 0,0,0,0,0 };
            dice = new List<int>(input);
            selectedDice = new List<int>(inputSelectedDice);
            rollsLeft = 3;
        }
        public void ResetSelectedDice()
        {
            for (int i = 0; i<5; i++)
            {
                selectedDice[i] = 0;
            }
        }
        public void RandomizeDice()
        {
            for (int i = 0; i<5; i++)
            {
                Random randint = new Random();
                dice[i] = randint.Next(1, 7);
            }
        } 
        public void RandomizeSelectedDice()
        {
            foreach(int die in this.indexOfSelectedDice)
            {
                Random randint = new Random();
                dice[die] = randint.Next(1, 7);
            }
        }
        public void RandomizeDie(int index)
        {
            Random randint = new Random();
            dice[index] = randint.Next(1, 7);
        }
        public void PrintList()
        {
            Console.Write("\n");
            foreach(int die in this.dice)
            {
                Console.Write("{0}\t", die);
            }
        }
        public void PrintList(int cursor)
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"NOW PLAYING: {ThreeOfAKind.Name}");
            Console.ResetColor();
            Console.WriteLine($"{ThreeOfAKind.Description}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Rolls left: {rollsLeft}");
            Console.ResetColor();
            Console.WriteLine("=============================================================");
            Console.Write("\n");
            for (int i = 0; i<5; i++)
            {
                if (this.selectedDice[i] == 1) {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"{this.dice[i]}\t");
                    Console.ResetColor();
                } else
                {
                    Console.Write($"{this.dice[i]}\t");
                }
            }
            Console.WriteLine("\n");
            for(int i = 0; i<cursor; i++)
            {
                Console.Write("\t");
            }
            Console.Write("^");
        }
    }
}
