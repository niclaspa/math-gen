using System;
using System.Linq;

namespace MathGen
{
    public class ProblemGenerator
    {
        private readonly Random rand = new Random();

        public Problem[] CreateBulk(int count, Func<Problem> gen)
        {
            return Enumerable.Repeat<object>(null, count).Select(_ => gen()).ToArray();
        }

        public Problem CreateAddition(int min, int max)
        {
            var first = this.rand.Next(min, max + 1);
            var second = this.rand.Next(0, max - first);

            return new Problem
            {
                First = first,
                Second = second,
                Operand = '+'
            };
        }

        public Problem CreateSubtraction(int min, int max)
        {
            var first = this.rand.Next(min, max + 1);
            var second = this.rand.Next(min, first + 1);

            return new Problem
            {
                First = first,
                Second = second,
                Operand = '-'
            };
        }

        public Problem CreateMultiplication(int min, int max)
        {
            return new Problem
            {
                First = this.rand.Next(min, max + 1),
                Second = this.rand.Next(min, max + 1),
                Operand = 'x'
            };
        }

        public Problem CreateDivision(int min, int max)
        {
            var first = this.rand.Next(min, max + 1);
            var second = this.rand.Next(min, first + 1);

            return new Problem
            {
                First = first * second,
                Second = second,
                Operand = '/'
            };
        }
    }
}
