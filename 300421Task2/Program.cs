using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300421Task2
{
    class Program
    {
        //GetSum for ten values

        static void Main(string[] args)
        {

            int tempResult = GetSum(1,1,1,1,1,1,1,1,1,1); 


            Console.WriteLine($"Sum of values: {tempResult} \n");

        }

        #region first variant

        //public static int GetSum(int firstNumber, int secondNumber)
        //{
        //    return firstNumber + secondNumber;
        //}

        //public static int GetSum(int firstNumber, int secondNumber, int thirdNumber)
        //{
        //    return GetSum(GetSum(firstNumber, secondNumber), thirdNumber);
        //}

        //public static int GetSum(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        //{
        //    return GetSum(GetSum(firstNumber, secondNumber, thirdNumber), fourthNumber);
        //}

        //public static int GetSum(int firstNumber, int secondNumber, int thirdNumber,
        //                         int fourthNumber, int fifthNumber)
        //{
        //    return GetSum(GetSum(firstNumber, secondNumber, thirdNumber, fourthNumber), fifthNumber);
        //}

        //public static int GetSum(int firstNumber, int secondNumber, int thirdNumber,
        //                         int fourthNumber, int fifthNumber, int sixthNumber)
        //{
        //    return GetSum(GetSum(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber),sixthNumber);
        //}

        //public static int GetSum(int firstNumber, int secondNumber, int thirdNumber,
        //                         int fourthNumber, int fifthNumber, int sixthNumber,
        //                         int seventhNumber)
        //{
        //    return GetSum(GetSum(firstNumber, secondNumber, thirdNumber,
        //                         fourthNumber, fifthNumber, sixthNumber),seventhNumber);
        //}


        //public static int GetSum(int firstNumber, int secondNumber, int thirdNumber,
        //                         int fourthNumber, int fifthNumber, int sixthNumber,
        //                         int seventhNumber, int eighthNumber)
        //{
        //    return GetSum(GetSum(firstNumber, secondNumber, thirdNumber,
        //                         fourthNumber, fifthNumber, sixthNumber, seventhNumber),eighthNumber);
        //}

        //public static int GetSum(int firstNumber, int secondNumber, int thirdNumber,
        //                         int fourthNumber, int fifthNumber, int sixthNumber,
        //                         int seventhNumber, int eighthNumber, int ninthNumber)
        //{
        //    return GetSum(GetSum(firstNumber, secondNumber, thirdNumber,
        //                         fourthNumber, fifthNumber, sixthNumber,
        //                         seventhNumber, eighthNumber),ninthNumber);
        //}

        //public static int GetSum(int firstNumber, int secondNumber, int thirdNumber,
        //                         int fourthNumber, int fifthNumber, int sixthNumber,
        //                         int seventhNumber, int eighthNumber, int ninthNumber,int tenthNumber)
        //{
        //    return GetSum(GetSum(firstNumber, secondNumber, thirdNumber,
        //                         fourthNumber, fifthNumber, sixthNumber,
        //                         seventhNumber, eighthNumber, ninthNumber),tenthNumber);
        //}

        #endregion

        #region second variant

        public static int GetSum(int firstNumber, int secondNumber) => firstNumber + secondNumber;


        public static int GetSum(int firstNumber, int secondNumber, int thirdNumber) =>

                          GetSum(GetSum(firstNumber, secondNumber), thirdNumber);


        public static int GetSum(int firstNumber, int secondNumber,
                                 int thirdNumber, int fourthNumber) =>

                          GetSum(firstNumber, secondNumber) +
                          GetSum(thirdNumber, fourthNumber);


        public static int GetSum(int firstNumber, int secondNumber,
                                 int thirdNumber, int fourthNumber, int fifthNumber) =>

                          GetSum(GetSum(firstNumber, secondNumber, thirdNumber, fourthNumber), fifthNumber);


        public static int GetSum(int firstNumber, int secondNumber,
                                 int thirdNumber, int fourthNumber,
                                 int fifthNumber, int sixthNumber) =>

                          GetSum(firstNumber, secondNumber) +
                          GetSum(thirdNumber, fourthNumber) +
                          GetSum(fifthNumber, sixthNumber);


        public static int GetSum(int firstNumber, int secondNumber,
                                 int thirdNumber, int fourthNumber,
                                 int fifthNumber, int sixthNumber, int seventhNumber) =>

                          GetSum(GetSum(firstNumber, secondNumber, thirdNumber,
                                        fourthNumber, fifthNumber, sixthNumber), seventhNumber);


        public static int GetSum(int firstNumber, int secondNumber,
                                 int thirdNumber, int fourthNumber,
                                 int fifthNumber, int sixthNumber,
                                 int seventhNumber, int eighthNumber) =>

                          GetSum(firstNumber, secondNumber) +
                          GetSum(thirdNumber, fourthNumber) +
                          GetSum(fifthNumber, sixthNumber) +
                          GetSum(seventhNumber, eighthNumber);



        public static int GetSum(int firstNumber, int secondNumber,
                                 int thirdNumber, int fourthNumber,
                                 int fifthNumber, int sixthNumber,
                                 int seventhNumber, int eighthNumber, int ninthNumber) =>

                          GetSum(GetSum(firstNumber, secondNumber, thirdNumber,
                                        fourthNumber, fifthNumber, sixthNumber,
                                        seventhNumber, eighthNumber), ninthNumber);


        public static int GetSum(int firstNumber, int secondNumber,
                                 int thirdNumber, int fourthNumber,
                                 int fifthNumber, int sixthNumber,
                                 int seventhNumber, int eighthNumber,
                                 int ninthNumber, int tenthNumber) =>

                          GetSum(firstNumber, secondNumber) +
                          GetSum(thirdNumber, fourthNumber) +
                          GetSum(fifthNumber, sixthNumber) +
                          GetSum(seventhNumber, eighthNumber) +
                          GetSum(ninthNumber, tenthNumber);

        #endregion

    }
}
