using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            // [34, 15, 88, 2] return 2
            //Console.WriteLine(FindSmallestInt(new int[] { 0, -6, int.MinValue, -5, 1, int.MaxValue })); ;
            #endregion

            #region q2
            //Console.WriteLine(ReverseSeq(5)); ; // 5,4,3,2,1
            #endregion

            #region q4
            //Console.WriteLine(PositiveSum(new int[] { 1, -2, 3, 4, 5 })); ;
            #endregion

            #region q5

            #endregion

            #region q6
            //Console.WriteLine(IsSquare(24));
            #endregion

            
        }

        #region q1_function
        // https://www.codewars.com/kata/55a2d7ebe362935a210000b2/train/csharp
        //public static int FindSmallestInt(int[] args)
        //{
        //    int kucuk = args[0];

        //    for (int i = 0; i < args.Length; i++)
        //    {
        //        if (kucuk > args[i])
        //            kucuk = args[i];
        //    }
        //    return kucuk;
        //}
        #endregion

        #region q2_function
        // https://www.codewars.com/kata/5a00e05cc374cb34d100000d/train/csharp
        //public static int[] ReverseSeq(int n)
        //{
        //    int[] array = new int[n];
        //    int diziIndex = 0;
        //    for (int i = n; i > 0; i--)
        //    {
        //        array[diziIndex] = i;
        //        diziIndex++;
        //    }

        //    return array;
        //}
        #endregion

        #region q3_function
        // https://www.codewars.com/kata/53da3dbb4a5168369a0000fe/train/csharp
        //public static string EvenOrOdd(int number)
        //{
        //    return (number % 2 == 0) ? "Even" : "Odd";
        //}
        #endregion

        #region q4_function
        // https://www.codewars.com/kata/5715eaedb436cf5606000381/train/csharp
        // Example [1,-4,7,12] => 1 + 7 + 12 = 20
        /* public static int PositiveSum(int[] arr)
        {
            int toplam = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    toplam += arr[i];
                }
            }

            return toplam;
        } */
        #endregion

        #region q5_function
        // https://www.codewars.com/kata/5772da22b89313a4d50012f7/javascript
        //public static string Greet(string name, string owner)
        //{
        //    if (name == owner)
        //    {
        //        return "Hello boss";
        //    }
        //    else
        //    {
        //        return "Hello guest";
        //    }
        //}
        #endregion

        #region q6_function
        // https://www.codewars.com/kata/54c27a33fb7da0db0100040e/train/csharp
        /* public static bool IsSquare(int n)
        {
            var result = Math.Floor(Math.Sqrt(n));

            if (n == Math.Pow(result, 2))
            {
                return true;
            }
            return false;
        } */
        #endregion

        #region q7_function
        public static string[] StringToArray(string str)
        {
            string[] array;
            array = str.Split(' ');

            return array;
        }
        #endregion

        #region q8_function
        // https://www.codewars.com/kata/576bb71bbbcf0951d5000044/train/csharp
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            // [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65]
            int[] result = new int[] {0, 0};

            if (!(input == null || input.Length == 0))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > 0)
                    {
                        result[0]++;
                    }
                    else if (input[i] < 0)
                    {
                        result[1] += input[i];
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                return new int[] { };
            }

            return result;
        }
        #endregion
    }
}
