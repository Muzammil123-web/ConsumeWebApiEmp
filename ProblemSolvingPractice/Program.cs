
class Program
{
    static void Main()
    {
        int[] intMyNumber = { 45, 63, 23, 45, 56, 89, 100, 32 };
        Console.WriteLine("Here is the list of my numbers");
        DisplayNumbers(intMyNumber);
        var maxi = FindMaxNumber(intMyNumber);
       

        Console.WriteLine("Biggest number in a given array is " + maxi);

        var Min = FindMinValue(intMyNumber);
        Console.WriteLine("Smallest Number in a given array is " + Min);

        var evenNumbers = FindEvenNumber(intMyNumber);
        Console.WriteLine("Here is Even Number among Array");
        foreach (int evenNum in evenNumbers) {
            Console.WriteLine(evenNum);
        }
        var OddNumbers=FindOddNumber(intMyNumber);
        Console.WriteLine("Here Is Odd Numbers among given Array");
        foreach(int OddNum in OddNumbers)
        {
            Console.WriteLine(OddNum);
        }

        ForeachExample();

        ArrayTwoDimensinoal();

        ExampleOfArray();

        int[] myNumbers = { 15, 23, 93, 45, 56, 89, 100, 32 };
        Console.WriteLine("Find second largest Number");

        int secondLargestNumber = FindLastnumber(myNumbers);
        Console.WriteLine("Here is the second Largest NUmber in the given array" + secondLargestNumber);

    }

    static int[] DisplayNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        return numbers;
    }

    static int FindMaxNumber(int[] numbers)
    {
        int maxi = 0;
        maxi = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxi)
            {
                maxi = numbers[i];
            }
        }
        return maxi;
    }

    static int FindMinValue(int[] numbers)
    {
        int Min = 0;
        Min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < Min)
            {
                Min = numbers[i];
            }
        }
        return Min;
    }

    static List<int> FindEvenNumber(int[] numbers)
    {
        List<int>  list = new List<int>();
        for(int i=0; i<numbers.Length; i++)
        {
            if (numbers[i] % 2==0) 
            {
                list.Add(numbers[i]);
            }
        }
        return list;
    }

    static List<int> FindOddNumber(int[] numbers)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 !=0)
            {
                list.Add(numbers[i]);
            }
        }
        return list;
    }

    public static void  ForeachExample()
    {
        int[] numbers = new int[5];
        numbers[0] = 2;
        numbers[1] = 3;
        numbers[2] = 4;
        numbers[3] = 5;
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
        
    }

    static void ArrayTwoDimensinoal()
    {
        int[,] myarray =
        {
            { 21,31,41 },
            { 22,32,42},
            {23,33,43 },
            

        };
        int[][] mynewArray = new int[3][];
        mynewArray[0] = new[] { 23, 45, 55 };
        for(int i = 0; i < myarray.GetLength(0); i++)
        {
            for (int j = 0; j < myarray.GetLength(1); j++)
            {
                Console.Write(myarray[i,j] +"");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void ExampleOfArray()
    {
        Console.WriteLine("Enter a array size ");
        int sizeArry=Convert.ToInt16(Console.ReadLine());
        int[] userArray= new int[sizeArry];
        for(int i=0; i<sizeArry; i++)
        {
            Console.WriteLine("Enter a data at a index "+ (i+1));
            int arrayData=Convert.ToInt16(Console.ReadLine());
            userArray[i] = arrayData;
        }
        Console.WriteLine("Here is your Array data");
        foreach(int mydata in userArray)
        {
            Console.WriteLine(mydata);
        }
    }

    static int FindLastnumber(int[] mynumbers)
    {
        int largestNum = mynumbers[0];
        int secondNum = -1;
        for(int i=1;i<mynumbers.Length;i++)
        {
            if (mynumbers[i] > largestNum)
            {
                secondNum = largestNum;
                largestNum = mynumbers[i];
                
            }
            else if ( mynumbers[i] > secondNum && mynumbers[i] < largestNum)
             {
                secondNum = mynumbers[i];
            }
        }
        return secondNum;
    }

   
}