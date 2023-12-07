/*
1)
using System;
using System.IO;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pathInput = @"C:\Users\gr622_yurnal\Desktop\lr1\Lr1.5\numsTask1";
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(' ');
            int[] numbers = new int [input.Length];
            
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int min = numbers[0];
            int minimumElementIndex = 0;
            int work = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minimumElementIndex = i;
                }
            }

            for (int i = minimumElementIndex + 1; i < numbers.Length; i++)
            {
                work = work * numbers[i];
            }

            Console.WriteLine(work);
        }
    } 
}
*/
/*
2)
using System;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pathInput = @"C:\Users\gr622_yurnal\Desktop\lr1\Lr1.5\numsTask2";
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(';');
            float[] numbers = new float [input.Length];
            readInput.Close();
            
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = float.Parse(input[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        float z = numbers[j]; 
                        numbers[j]=numbers[j+1];
                        numbers[j + 1] = z;
                    }
                }
            }
            
            string[] massStr = new string [numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                massStr[i] = numbers[i].ToString();
            }

            using (StreamWriter writer = new StreamWriter(pathInput))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == 0)
                    {
                        writer.Write($"{massStr[0]}");
                    }
                    else
                    {
                        writer.Write($";{massStr[i]}");
                    }

                }
            }
        }
    } 
}
*/
/*
3)

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        string[] file = File.ReadAllLines(@"C:\Users\gr622_yurnal\Desktop\lr1\Lr1.5\numsTask3");
        string[] lines = file[0].Split(' ');
        int[] nums = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            nums[i] = Int32.Parse(lines[i]);
        }

        int minValue = nums[0];
        int indexOfMin = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < minValue)
            {
                minValue = nums[i];
                indexOfMin = i;
            }
        }

        float sum = 0;
        for (int i = 0; i <= indexOfMin; i++)
        {
            sum += nums[i];
        }

        float avgValue = 0;
        avgValue = sum / (indexOfMin + 1);
        Console.WriteLine(avgValue);
    }
}
*/
/*
4)

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        string[] file = File.ReadAllLines(@"C:\Users\gr622_yurnal\Desktop\lr1\Lr1.5\numsTask4");
        string[] lines = file[0].Split(' ');
        int[] nums = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            nums[i] = Int32.Parse(lines[i]);
        }

        int maxValue = nums[0];
        int indexOfMax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxValue)
            {
                maxValue = nums[i];
                indexOfMax = i;
            }
        }

        int sum = 0;
        sum = nums[indexOfMax - 1] + nums[indexOfMax + 1];
        Console.WriteLine(sum);
    }
}
*/
/*
5)

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        string[] file = File.ReadAllLines(@"C:\Users\gr622_yurnal\Desktop\lr1\Lr1.5\numsTask5");
        string[] lines = file[0].Split(' ');
        int[] nums = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            nums[i] = Int32.Parse(lines[i]);
        }

        int minValue = nums[0];
        int indexOfMin = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < minValue)
            {
                minValue = nums[i];
                indexOfMin = i;
            }
        }
        
        int maxValue = nums[0];
        int indexOfMax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxValue)
            {
                maxValue = nums[i];
                indexOfMax = i;
            }
        }

        float sum = 0;
        int quantity = 0;
        for (int i = indexOfMin; i < indexOfMax + 1; i++)
        {
            sum += nums[i];
            quantity++;
        }

        float avgValue = sum / quantity;
        Console.WriteLine(avgValue);
    }
}
*/