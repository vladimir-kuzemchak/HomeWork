using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300421
{
    class Program
    {
        //GetMin for five values
        
        /*
         Вызов перегруженых методов с дефолтными значениями не является возможным, так как это не безопасно
        */

        static void Main(string[] args)
        {

            int tempResult = GetMin(133,2,44,221,11);
            Console.Write($"Min value: {tempResult} \n");
            

        }

        #region First variant (overloading)

        public static int GetMin(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? secondNumber : firstNumber;
        }

        public static int GetMin(int firstNumber, int secondNumber, int thirdNumber)
        {
            int tmpResult = GetMin(firstNumber, secondNumber);
            return tmpResult < thirdNumber ? tmpResult : thirdNumber;
        }

        public static int GetMin(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            int tmpResult = GetMin(firstNumber, secondNumber, thirdNumber);
            return tmpResult < fourthNumber ? tmpResult : fourthNumber;
        }

        public static int GetMin(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber)
        {
            int tmpResult = GetMin(firstNumber, secondNumber, thirdNumber, fourthNumber);
            return tmpResult < fifthNumber ? tmpResult : fifthNumber;
        }

        #endregion

        #region Second variant (default parametrs)

        //public static int GetMin(int firstNumber,int secondNumber = 2)
        //{
        //    int minValue = (
        //                   (firstNumber > secondNumber ? secondNumber : firstNumber)
        //                   );

        //    return minValue;
        //}

        //public static int GetMin(int firstNumber, int secondNumber = 2, int thirdNumber = 3)
        //{
        //    int minValue = (
        //                   (thirdNumber >
        //                   (firstNumber = (firstNumber > secondNumber ? secondNumber : firstNumber))
        //                   ? firstNumber : thirdNumber)
        //                   );

        //    return minValue;
        //}

        //public static int GetMin(int firstNumber, int secondNumber = 2, int thirdNumber = 3, int fourthNumber = 4)
        //{
        //    int minValue = (
        //                   ((fourthNumber > (secondNumber =
        //                   (thirdNumber > (firstNumber =
        //                   (firstNumber > secondNumber ? secondNumber : firstNumber)
        //                   ) ? firstNumber : thirdNumber)
        //                   ) ? secondNumber : fourthNumber))
        //                   );

        //    return minValue;
        //}

        //public static int GetMin(int firstNumber, int secondNumber = 2, int thirdNumber = 3, int fourthNumber = 4, int fifthNumber = 5)
        //{
        //    int minValue = (
        //                   (fifthNumber > (thirdNumber =
        //                   (fourthNumber > (secondNumber =
        //                   (thirdNumber > (firstNumber =
        //                   (firstNumber > secondNumber ? secondNumber : firstNumber)
        //                   ) ? firstNumber : thirdNumber)
        //                   ) ? secondNumber : fourthNumber)
        //                   ) ? thirdNumber : fifthNumber)
        //                   );

        //    return minValue;
        //}

        #endregion
    }
}
