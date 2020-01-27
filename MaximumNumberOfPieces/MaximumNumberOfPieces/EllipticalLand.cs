
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace MaximumNumberOfPieces
{
    public class EllipticalLand
    {
        int iteration = -1, loopIndex;
        List<BigInteger> numberOfPoints = new List<BigInteger>();

        //Getting Inputs From The User
        public List<BigInteger> GetValue()
        {
            while (iteration <= 0)
            {
                try
                {
                    Console.WriteLine("Enter the Number of Iterations");
                    iteration = Convert.ToInt32(Console.ReadLine());
                    if (iteration <= 0)//Validating the user input
                    {
                        Console.WriteLine("Enter a Positive or a Non Zero Integer Input");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a Valid Input");
                }

            }
            //

            Console.WriteLine("Enter The Arbitary Points");
            Console.WriteLine("\nEnter the Arbitary Points one below other");
            for (loopIndex = 0; loopIndex < iteration; loopIndex++)
            {
                try
                {
                    numberOfPoints.Add(Convert.ToInt64(Console.ReadLine()));
                    if (numberOfPoints[loopIndex] < 0)//Validating the user input
                    {
                        numberOfPoints.RemoveAt(loopIndex);
                        loopIndex = loopIndex - 1;
                        Console.WriteLine("Enter a Positive Value or a Zero");

                    }
                    else
                    {
                        continue;
                    }

                }
                catch (FormatException)
                {
                    loopIndex = loopIndex - 1;
                    Console.WriteLine("Enter a Valid Number");
                }
            }
            return numberOfPoints;
        }

        //Calculting The Maximum Number Of Pieces
        public List<BigInteger> CalculationMaximumPieces(List<BigInteger> numberOfPoints)
        {
            List<BigInteger> maximumSegments = new List<BigInteger>();
            for (loopIndex = 0; loopIndex < numberOfPoints.Count; loopIndex++)
            {

                maximumSegments.Add(numberOfPoints[loopIndex] * (numberOfPoints[loopIndex] - 1) / 2 + numberOfPoints[loopIndex] * (numberOfPoints[loopIndex] - 1) * (numberOfPoints[loopIndex] - 2) * (numberOfPoints[loopIndex] - 3) / 24 + 1);

            }
            List<BigInteger> result=new List<BigInteger>();
            for (loopIndex = 0; loopIndex < numberOfPoints.Count; loopIndex++)
            {
                result.Add(-1);
                if(numberOfPoints[loopIndex]<0)
                {
                    return result;
                }
                else
                {
                    result.Add(1);
                }
            }

            return maximumSegments;
        }


        static void Main(string[] args)
        {
            List<BigInteger> numberOfPoints = new List<BigInteger>();  
            EllipticalLand obj = new EllipticalLand();  //Creating An Object For The Class
            numberOfPoints = obj.GetValue();
            List<BigInteger> result = obj.CalculationMaximumPieces(numberOfPoints);
            foreach (var value in result)   //Printing The Final Result
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
