using System;
using System.Collections.Generic;
using System.Linq;

namespace MathGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var gen = new ProblemGenerator();
            IEnumerable<Problem> adds = new Problem[0];
            IEnumerable<Problem> subs = new Problem[0];
            IEnumerable<Problem> muls = new Problem[0];
            IEnumerable<Problem> divs = new Problem[0];

            adds = gen.CreateBulk(1000, () => gen.CreateAddition(0, 100));
            subs = gen.CreateBulk(1000, () => gen.CreateSubtraction(0, 100));
            muls = gen.CreateBulk(1000, () => gen.CreateMultiplication(0, 12));
            divs = gen.CreateBulk(1000, () => gen.CreateDivision(1, 12));

            var rand = new Random();

            var all = adds.Concat(subs).Concat(muls).Concat(divs).OrderBy(x => rand.Next());

            foreach (var problem in all)
            {
                Console.WriteLine(problem);
            }
        }
    }
}
