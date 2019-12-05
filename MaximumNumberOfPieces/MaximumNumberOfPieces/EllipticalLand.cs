
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace MaximumNumberOfPieces
{
    class EllipticalLand
    {
        int iteration = -1, loopIndex;
        List<BigInteger> numberOfPoints = new List<BigInteger>();
        public List<BigInteger> GetValue()
        {
            while (iteration <= 0)
            {
                try
                {
                    Console.WriteLine("Enter the Number of Iterations");
                    iteration = Convert.ToInt32(Console.ReadLine());
                    if (iteration <= 0)
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
            Console.WriteLine("Enter The Arbitary Points");
            Console.WriteLine("\nEnter the Arbitary Points one below other");
            for (loopIndex = 0; loopIndex < iteration; loopIndex++)
            {
                try
                {
                    numberOfPoints.Add(Convert.ToInt64(Console.ReadLine()));
                    if (numberOfPoints[loopIndex] < 0)
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

        public List<BigInteger> CalculationMaximumPieces(List<BigInteger> numberOfPoints)
        {
            List<BigInteger> maximumSegments = new List<BigInteger>();
            for (loopIndex = 0; loopIndex < numberOfPoints.Count; loopIndex++)
            {

                maximumSegments.Add(numberOfPoints[loopIndex] * (numberOfPoints[loopIndex] - 1) / 2 + numberOfPoints[loopIndex] * (numberOfPoints[loopIndex] - 1) * (numberOfPoints[loopIndex] - 2) * (numberOfPoints[loopIndex] - 3) / 24 + 1);

            }

            return maximumSegments;
        }


        static void Main(string[] args)
        {
            List<BigInteger> numberOfPoints = new List<BigInteger>();
            EllipticalLand obj = new EllipticalLand();
            numberOfPoints = obj.GetValue();
            List<BigInteger> result = obj.CalculationMaximumPieces(numberOfPoints);
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
