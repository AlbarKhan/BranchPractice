// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

class SetZero
{
    public static  void FibonacciSeries(int n)
    {
        int a = 0;
        int b = 1;
        int temp;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for(int i = 0; i <n-2; i++) {
            temp = a+b;
            a = b;
            b = temp;
            Console.WriteLine(b);
        }
    }
    static bool IsArmstrong(int n)
    {
        int r,sum = 0, temp;
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = sum + (r * r * r);
            n = n / 10;
        }
        if(sum == temp)
        {
            return true;
        }
        else
        
        return false;
        }

    static bool IsAnagram(string str1,string str2)
    {
        if(str1.Length != str2.Length)
        {
            return false;
        }
        char[] chars1 = str1.ToCharArray();
        char[] chars2 = str2.ToCharArray();

        Array.Sort(chars1);
        Array.Sort(chars2);

        string sortedStr1 = new string(chars1);
        string sortedStr2 = new string(chars2);
        //Console.Write(sortedStr1 );
        if(sortedStr1 == sortedStr2)
        {
            return true;
        }
        else
        { 
        return false;
        }
        
     }

   static bool IsPrime(int num)
    {
        for(int i = 2; i < num; i++)
        {
            if(num%i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int ReverseNumber(int num)
    {
        int revNum = 0;
        while (num > 0)
        {
            revNum = revNum * 10 + num % 10;
            num = num / 10;
        }
        return revNum;
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped = false;
        for (int i = 0; i < n; i++)
        {
            swapped = false;
            for (int j = 0; j <n-1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    arr[j] = arr[j] + arr[j + 1];
                    arr[j + 1] = arr[j] - arr[j + 1];
                    arr[j] = arr[j] - arr[j + 1];
                    swapped = true;
                }
            }
            if (swapped == false)
            {
                break;
            }
        }

        for(int i = 0; i < n;i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    static void Factorial(int num)
    {
        int factorial = 1;
        for(int i=1;i <=num; i++)
        {
            factorial *= i;
        }
        Console.Write( factorial);
    }

    static void NumbersToWords(int n)
    {
        string[] words = { "zero","one","two","three","four","five","six","seven","eight","nine"};
        string result = "";
        int temp;
        while (n > 0)
        {
            temp = n % 10;
            result += words[temp] + " ";
            n /= 10;
        }
        string[] resultArr = result.Split(' ');
        Array.Reverse(resultArr);
        string ak = String.Join(" ", resultArr);
        Console.WriteLine(ak);
    }

    static void Divisible(int [] arr)
    {
        int count = 0;
        int result = 0;
        for(int i = 0;i < arr.Length; i++)
        {
            count = 0;
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[i] / arr[j]==0)
                {
                    count++;
                }
                if(count == arr.Length-1)
                {
                   // Console.WriteLine(arr[i]);
                    result = arr[i];
                }

            }
        }
        if(result>0)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }

    public static void IsPalindrome(string str1)
    {
        char [] charStr1 = str1.ToCharArray();
        Array.Reverse (charStr1);
        string reversedStr = new string(charStr1);
        if(str1 == reversedStr)
        {
            Console.WriteLine("The given String is Palindrome");
        }
        else
        {
            Console.WriteLine("The given String is Not  Palindrome");
        }
    }

    public static void MinMax(int[] arr)
    {
        int max = arr[0];
        int min = arr[0];

        for(int i=0;i<arr.Length;i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min  = arr[i];
            }
        }
        Console.WriteLine("The largest Element is : " + max);
        Console.WriteLine("The smallest Element is : " + min);
    }

 
    public static void MaxRepeatedChar(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            Console.WriteLine("The string is empty");
        }

        Dictionary<char,int> frequency = new Dictionary<char,int>();

        foreach (char ch in str)
        {
            if(frequency.ContainsKey(ch))
            {
                frequency[ch]++;
            }
            else
            {
                frequency[ch] = 1;
            }
        }

        char maxChar = '\0';
        int maxCount = 0;
        foreach (var pair in frequency) { 
            if(pair.Value > maxCount)
            {
                maxCount = pair.Value;
                maxChar = pair.Key;
            }
        }
        Console.WriteLine(maxChar);
    }

    static void TrainglePattern(int n)
    {
        int row = 1;
        while (row <=n)
        {
            int col = 1;
            while (col <= n-row)
            {
                Console.Write(" ");
                col++;
            }

             col = 1;
            while (col <= row)
            {
                Console.Write(col);
                col++;
            }
            col = 1;
            while (col < row)
            {
                Console.Write(row-col);
                col++;
            }


            Console.WriteLine("");
            row++;
        }
    }

    public static void AsciiOfString(string str)
    {
        char[] charStr = str.ToCharArray();
        string result = "";
        for(int i=0;i<charStr.Length; i++)
        {
            //Console.WriteLine(charStr[i]);
            for(int j = 0; j < 128; j++)
            {
                char asciValue = Convert.ToChar(j);
                if (charStr[i] == asciValue)
                {
                    Console.Write(j + " ");
                    //result = result + " " + Convert.ToString(j) + " ";
                }
            }
            //Console.WriteLine(result);
        }
        //Console.WriteLine(result);
    }

    public static void Problem9() {
        int sum = 0;
        for(int i = 2; i < 20; i++)
        {
            if( i% 3==0  && i% 4 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }


    public static void Main(string [] args)
    {
        // FibonacciSeries(8);

        //IsArmstrong(153);

        // Console.WriteLine(IsAnagram("printer","reprint"));

        //Console.WriteLine(IsPrime(73));

        // Console.WriteLine(ReverseNumber(10
        //ReverseNumber(102);

        int[] arr = { 11, 452, 63, 99, 102 };
        //BubbleSort(arr);

        // Factorial(10);

        // NumbersToWords(6786);

        //int[] arr = { 10, 6, 2, 4, 8 };
        //Divisible(arr);

        //IsPalindrome("madam");

        //  MinMax(arr);

        //  MaxRepeatedChar("Albarr");

        //TrainglePattern(6);

        AsciiOfString("hello");

        //Problem9();
    }
}
