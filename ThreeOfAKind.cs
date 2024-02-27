using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeJack
{
    public class ThreeOfAKind : ICategory
    {
        public static string Name
        {
            get
            {
                return "Three Of A Kind";
            }
        }
        public static int MaxPoints {
            get
            {
                return 30;
            }
        }
        public static string Description
        {
            get
            {
                return "RULE: At least three dice the same. SCORE: Sum of all dice.";
            }
        }
        public bool CheckValidity(List<int> dice)
        {
            foreach (int die in dice)
            {
                int count = dice.Count(s => s == die);
                if (count >= 3)
                {
                    return true;
                }
            }
            return false;
        }
        public int PointsAcquired(List<int> dice) => CheckValidity(dice) ? dice.Sum() : 0;
    }
}
