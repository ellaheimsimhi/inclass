using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public class Baseship
    {
        private int counter;
        protected int speed;

        public Baseship(int i)
        {
            Console.WriteLine("Baseship constructor" + i);
        }
        public virtual string move(int distance)
        {
            counter ++;
            return $"base ship covered distance {distance}";
        }
    }
}
