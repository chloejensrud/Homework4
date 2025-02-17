// Written By Chloe Jensrud
// 2/16/25


namespace Vowels
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            Console.WriteLine(aCalculator.FirstNVowels("Sharpening Skills", 3));
        }
    }
}
