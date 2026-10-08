using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public class Transpership : Baseship
    {
        public Transpership(int i) : base(5)
        {
            Console.WriteLine("transpership constuctor");
        }
        public override string move (int distance)
        {
            return $"transpership covered distance : {distance}";
        }
        public override string ToString()
        {
            return $"transpership:hello from tostring";
        }
    }
}
