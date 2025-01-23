using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01
{
    internal static class Helper
    {
        #region non generic swap
        //public static void Swap(ref int x, ref int y)
        //{ int Temp = x;
        //    x = y;
        //    y = Temp;
        //}

        //public static void Swap(ref double x,  ref double  y)
        //{
        //    double Temp = x;
        //    x = y;
        //    y = Temp;
        //}

        //public static void Swap(ref Point p01,  ref Point  po2)
        //{
        //    Point Temp = p01;
        //    p01 = po2;
        //   po2 = Temp;
        //} 
        #endregion

        #region generic swap
        //// generic swap 

        //public static void Swap <T> (ref T x, ref T y)
        //{ T Temp = x;
        //    x = y;
        //    y = Temp;
        //} 
        #endregion

        #region linear search non generic
        //public static int LinearSearch(int[] arr, int value)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //                return i;
        //        }
        //    }
        //    return -1;
        //} 
        #endregion


        #region linear search generic
        //public static int LinearSearch<T>(T[] arr, T value)
        //{
        //    if (arr?.Length > 0)
        //    {
        //       for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i].Equals (value))
        //                return i;
        //        }
        //    }
        //    return -1;
        //}  
        #endregion

    }
}
