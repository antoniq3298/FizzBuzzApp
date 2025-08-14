namespace FizzBuzzApp
{
    public class FizzBuzzResult
    {
        public string Output { get; set; }
        public int Count { get; set; }

        public FizzBuzzResult(string output, int count)
        {
            Output = output;
            Count = count;
        }
    }
}
