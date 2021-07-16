using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_HW_Arrays_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region targil 1
            //int[] arr1 = new int[10] { 2,43,332,332,39,33,96,58,45,96};
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr1[3]);
            //Console.WriteLine(arr1[4]);
            //Console.WriteLine(arr1[5]);
            //Console.WriteLine(arr1[6]);
            //Console.WriteLine(arr1[7]);
            //Console.WriteLine(arr1[8]);
            //Console.WriteLine(arr1[9]);
            #endregion

            #region targil 2
            //char[] arr2 = new char[5] { 'a', 'c', 'b', 'r', 'w' };

            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr2[1]);
            //Console.WriteLine(arr2[2]);
            //Console.WriteLine(arr2[3]);
            //Console.WriteLine(arr2[4]);
            #endregion

            #region targil 3
            //int[] arr3a = new int[10];
            //int[] arr3b = new int[10];
            //for (int i = 0; i < arr3a.Length; i++)
            //{
            //    Console.WriteLine("enter a number");
            //    arr3a[i] = int.Parse(Console.ReadLine());
            //    arr3b[i] = arr3a[i];
            //}
            //for (int i = 0; i < arr3b.Length; i++)
            //{
            //    arr3b[i] = arr3a[i];

            //}
            //arr3a[2] = 150;
            //arr3a[5] = 300;
            //Console.WriteLine(arr3b[2]);
            //Console.WriteLine(arr3b[5]);
            //Console.WriteLine("the end");
            #endregion

            #region targil 6
            Console.WriteLine("how many studants in class");
            int numStudent = int.Parse(Console.ReadLine());
            int[] student = new int[numStudent];
            int sum = 0;
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("enter grade");
                student[i] = int.Parse(Console.ReadLine());
                sum = sum + student[i];
            }

            Console.WriteLine($"sum of grades is: {sum}" );
            Console.WriteLine($"avarege is: " + sum/numStudent);

            #endregion
        }
    }
}
