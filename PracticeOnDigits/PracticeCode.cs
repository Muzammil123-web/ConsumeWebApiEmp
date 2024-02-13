namespace PracticeOnDigits
{
    public class PracticeCode
    {
        static void Main()
        {
            int countNum = CountNumberDigits(1234567);
            Console.WriteLine("the given number has " + countNum + "Digits");

            //Check given number is palindrone are not

            bool isNumberPalin = CheckNumberIsPalindrome(123331);
            Console.WriteLine("The given number is " + isNumberPalin);

            //Reverse a number on a given number
            PracticeCode practiceCode = new PracticeCode();
            int revNumber = practiceCode.ReverseNumber(456);
            Console.WriteLine("Reverse a number for a given number is " + revNumber);

            // Return a prime number in a given array
            List<int> primeNumber = PrimeNumber(new[] { 12, 1, 7, 4 });
            Console.WriteLine(primeNumber);

            //Check a given number is prime or not
            bool isprimeNumber = IsPrimeNum(24);
            Console.WriteLine("The Number you have given is actually a " + isprimeNumber);
        }
        static int CountNumberDigits(int num)

        {
            int count = 0;
            int lastNumber = 0;

            while (num > 0)
            {
                lastNumber = num % 10;
                count++;
                num = num / 10;
            }
            return count;
        }

        static bool CheckNumberIsPalindrome(int num)
        {
            int lastnumber = 0;
            int dupicateNumber = num;
            int rev = 0;
            while (num > 0)
            {
                lastnumber = num % 10;
                rev = (rev * 10) + lastnumber;
                num = num / 10;

            }
            if (rev == dupicateNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ReverseNumber(int num)
        {
            int lastNumber = 0;
            int rev = 0;

            while (num > 0)
            {
                lastNumber = num % 10;
                rev = (rev * 10) + lastNumber;
                num = num / 10;
            }
            return rev;
        }

        static List<int> PrimeNumber(int[] num)
        {
            int lastnumber = 0;
            int rev = 0;
            List<int> mylistprime = new List<int>();
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                {

                    mylistprime.Add(num[i]);
                }
            }
            return mylistprime;

        }
        static bool IsPrimeNum(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}