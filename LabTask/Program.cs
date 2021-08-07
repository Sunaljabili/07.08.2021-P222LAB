using System;

namespace LabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            #region Task-1
            //int[] arr = { 14, 15, 8,1, 23, 16 };
            //GetSmallest(arr);
            #endregion

            #region Task-2
            //int[] arr = { 14, 15, -5, 0, -8,-9,10};
            //PlusMinus(arr);
            #endregion

            #region Task-3
            //int n = 32;
            //Console.WriteLine(CheckPowTwo(n));
            #endregion

            #region Task-4
            //int[] arr = { 14, 15, 25, 96 };
            //Console.WriteLine(SumArr(arr));
            #endregion
        }

        #region Task-1
        //static void GetSmallest(int[] arr)
        //{
        //    int small = arr[0];
        //    int index = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (small > arr[i])
        //        {
        //            small = arr[i];
        //            index = i;
        //        }
        //    }
        //    Console.WriteLine($"en kicik element {small} en kicik elementin indeksi {index}");

        //}
        #endregion

        #region Task-2
        //static void PlusMinus(int[] arr)
        //{
        //    int PlusCount = 0;
        //    int MinusCount = 0;
        //    int ZeroCount = 0;
        //    foreach (int item in arr)
        //    {
        //        if(item > 0)
        //        {
        //            PlusCount++;
        //        }else if (item < 0)
        //        {
        //            MinusCount++;
        //        }
        //        else
        //        {
        //            ZeroCount++;
        //        }

        //    }
        //    Console.WriteLine($"Musbet ededlerin sayi {PlusCount} menfi ededlerin sayi {MinusCount} Sifirlarin sayi {ZeroCount}");
        //}

        #endregion

        #region Task-3
        //static bool CheckPowTwo(int n)
        //{
        //    if (n == 0)
        //        return false;
        //    while (n != 1)
        //    {
        //        if (n % 2 != 0)
        //            return false;
        //        n = n / 2;
        //    }
        //    return true;
        //}
        #endregion

        #region Task-4
        //static int SumArr(int[] arr)
        //{
        //    int Sum = 0;
        //    foreach (int item in arr)
        //    {
        //        Sum += item;
        //    }
        //    return Sum;
        //}
        #endregion
    }
}
