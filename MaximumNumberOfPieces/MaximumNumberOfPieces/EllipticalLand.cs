
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace MaximumNumberOfPieces
{
    class EllipticalLand
    {
        int Iteration = -1, LoopIndex;
        //Int64[] NumberOfPoints = new Int64[3500];
        List<BigInteger> NumberOfPoints = new List<BigInteger>();
        public List<BigInteger> GetValue()
        {
            while (Iteration <= 0)
            {
                try
                {
                    Console.WriteLine("Enter the Number of Iterations");
                    Iteration = Convert.ToInt32(Console.ReadLine());
                    if (Iteration <= 0)
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
            for (LoopIndex = 0; LoopIndex < Iteration; LoopIndex++)
            {
                try
                {
                    //NumberOfPoints[LoopIndex] = Convert.ToInt32(Console.ReadLine());
                    NumberOfPoints.Add(Convert.ToInt64(Console.ReadLine()));
                    if (NumberOfPoints[LoopIndex] < 0)
                    {
                        NumberOfPoints.RemoveAt(LoopIndex);
                        LoopIndex = LoopIndex - 1;
                        Console.WriteLine("Enter a Positive Value or a Zero");
                        //Console.WriteLine("\n");
                    }
                    else
                    {
                        LoopIndex = LoopIndex;
                    }
                    //Console.WriteLine(NumberOfPoints[LoopIndex]);

                }
                catch (FormatException)
                {
                    //NumberOfPoints.RemoveAt(LoopIndex);
                    LoopIndex = LoopIndex - 1;
                    Console.WriteLine("Enter a Valid Number");
                }
            }
            return NumberOfPoints;
        }

        public List<BigInteger> Calculation(List<BigInteger> NumberOfPoints)
        {
            List<BigInteger> MaximumSegments = new List<BigInteger>();
            for (LoopIndex = 0; LoopIndex < NumberOfPoints.Count; LoopIndex++)
            {
                /*MaximumSegments[LoopIndex] = NumberOfPoints[LoopIndex] * (NumberOfPoints[LoopIndex] - 1) / 2;
                MaximumSegments[LoopIndex] += NumberOfPoints[LoopIndex] * (NumberOfPoints[LoopIndex] - 1) * (NumberOfPoints[LoopIndex] - 2) * (NumberOfPoints[LoopIndex] - 3) / 24;
                MaximumSegments[LoopIndex] += 1;*/
                if ((NumberOfPoints[LoopIndex] < 0) || (NumberOfPoints[LoopIndex] > 2147483648))
                {

                    MaximumSegments.Add(0);
                    // Console.WriteLine(MaximumSegments[LoopIndex]);

                }
                else
                {
                    MaximumSegments.Add(NumberOfPoints[LoopIndex] * (NumberOfPoints[LoopIndex] - 1) / 2 + NumberOfPoints[LoopIndex] * (NumberOfPoints[LoopIndex] - 1) * (NumberOfPoints[LoopIndex] - 2) * (NumberOfPoints[LoopIndex] - 3) / 24 + 1);
                    //Console.WriteLine("For {0} Arbitrary Point, Maximum Number Pieces of Land Possible is {1} ", NumberOfPoints[LoopIndex], MaximumSegments[LoopIndex]);
                    //Console.WriteLine(MaximumSegments[LoopIndex]);
                }
            }

            return MaximumSegments;
        }


        static void Main(string[] args)
        {
            List<BigInteger> NumberOfPoints = new List<BigInteger>();
            EllipticalLand obj = new EllipticalLand();
            NumberOfPoints = obj.GetValue();
            // NumberOfPoints =
            List<BigInteger> result = obj.Calculation(NumberOfPoints);
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
