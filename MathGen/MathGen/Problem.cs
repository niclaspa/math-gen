namespace MathGen
{
    public class Problem
    {
        public char Operand { get; set; }
        public int First { get; set; }
        public int Second { get; set; }

        public override string ToString()
        {
            return $"{this.First} {this.Operand} {this.Second}";
        }
    }
}
