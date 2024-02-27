using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeJack
{
    public interface ICategory
    {
        public static string Name { get; }
        public static int MaxPoints { get; }
        public static string Description { get; }
    }
}
