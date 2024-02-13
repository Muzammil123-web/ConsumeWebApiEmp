public class Program
{
    static void Main()
    {
        Print1toN(1, 10);

        Print1toNLinear(10, 10);

        PrintNto1(10,10);

        PrintNto1Liner(1,10);

        PrintSum1toN(1, 5);

        PrintOfEvenNumbers(6, 6);

        PrintOfOddNumbers(6, 6);


    }

    //Print 1 to n times using recurrsion

    static void Print1toN(int i,int n)
    {
        if (i > n)
        {
            return ;
        }
       
        Console.WriteLine(i);
        Print1toN(i + 1, n);
       
    }

    //Print 1 to n times using Backward liner recurrsion

    static void Print1toNLinear(int i, int n)
    {
        if (i < 1)
        {
            return;
        }

        Print1toNLinear(i - 1, n);
        Console.WriteLine(i);
       

    }

    //print N times to 1 using recursion

    static void PrintNto1(int i,int n)
    {
        if (i < 1)
        {
            return ;
        }
        Console.WriteLine(i);
        PrintNto1(i -1, n);
                
    }

    //print N times to 1 using backward liner recursion

    static void PrintNto1Liner(int i, int n)
    {
        if (i > n)
        {
            return;
        }
        PrintNto1Liner(i +1, n);
        Console.WriteLine(i);
        
    }

    //Print sum of  1 to n times using recurrsion
    public static int sum = 0;
    static void PrintSum1toN(int i, int n)
    {
        
        if (i > n)
        {
            return;
        }
        sum = sum + i;
        Console.WriteLine(sum);
        PrintSum1toN(i + 1, n);

    }

    //print of even numbers from 1 to N using Recursion

    static void PrintOfEvenNumbers(int i,int n)
    {
        if (i < 1)
        {
            return;
        }
        
        PrintOfEvenNumbers(i-1, n);
        List<int> evenList = new List<int>();
       
        if (i % 2 == 0)
        {
            int Even = i;
            evenList.Add(Even);
            foreach(int x in evenList)
            Console.WriteLine("Even Number are " + x);
        }
        

    }

    //print of odd numbers from 1 to N using recurssion
    static void PrintOfOddNumbers(int i, int n)
    {
        if (i < 1)
        {
            return;
        }

        PrintOfOddNumbers(i - 1, n);

        if (i % 2 != 0)
        {
            int Odd = i;
            Console.WriteLine("Odd Number are " + Odd);

        }

    }

}