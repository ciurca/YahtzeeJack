// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.CompilerServices;
using YahtzeeJack;

var game = new Game();
game.RandomizeDice();
int count = 0;
game.PrintList(count);
Console.CursorVisible = false;
while (count!=-1)
{
    ConsoleKey keyPressed = Console.ReadKey().Key;
    switch (keyPressed)
    {
        case ConsoleKey.RightArrow:
            if (count == 4)
            {
                game.PrintList(count);
                continue;
            } else
            {
                count++;
                game.PrintList(count);
                continue;
            }
        case ConsoleKey.LeftArrow:
            if (count == 0)
            {
                game.PrintList(count);
                continue;
            } else
            {
                count--;
                game.PrintList(count);
                continue;
            }
        case ConsoleKey.Spacebar:
            if (game.selectedDice[count] == 1)
            {
                game.selectedDice[count] = 0;

            } else
            {
                game.selectedDice[count] = 1;
            }
            game.PrintList(count);
            continue;
        case ConsoleKey.Escape:
            var gameCat = new ThreeOfAKind();
            game.rollsLeft = 3;
            game.PrintList(0);
            Console.WriteLine("\n You have acquired {0} points.", gameCat.PointsAcquired(game.dice));
            game.ResetSelectedDice();
            game.RandomizeDice();
            break;

        case ConsoleKey.Enter:
            game.RandomizeSelectedDice();
            if (game.rollsLeft==1)
            {
                var gameCategory = new ThreeOfAKind();
                game.rollsLeft = 3;
                game.PrintList(0);
                Console.WriteLine("\n You have acquired {0} points.", gameCategory.PointsAcquired(game.dice));
                game.RandomizeDice();
            } else
            {
                game.rollsLeft--;
                game.PrintList(0);
            }
            game.ResetSelectedDice();
            break;

    }
}
    
