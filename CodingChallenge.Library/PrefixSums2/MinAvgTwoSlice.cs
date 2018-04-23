using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.PrefixSums2
{
    public class MinAvgTwoSlice
    {

        public int Solve(int[] A) {

            int[] prefixSumArray = new int[A.Length + 1];
            //int[] suffixSumArray = new int[A.Length + 1];

            for (int index = 0; index < A.Length; index++)
            {
                prefixSumArray[index + 1] = prefixSumArray[index] + A[index];
                //suffixSumArray[index + 1] = suffixSumArray[index] + A[A.Length - index - 1];
            }

            double minAverage = double.MaxValue;
            int minAverageStartingPosition = -1;

            for (int index = 0; index < A.Length; index++)
            {

                for (int indexTwo = index + 1; indexTwo < A.Length; indexTwo++)
                {
                    int sum = prefixSumArray[indexTwo + 1] - prefixSumArray[index];
                    double average = sum * 1.0 / (indexTwo - index + 1);

                    if (average < minAverage)
                    {
                        minAverage = average;
                        minAverageStartingPosition = index;
                    }
                    else if (average == minAverage)
                    {
                        minAverageStartingPosition = Math.Min(minAverageStartingPosition, index);
                    }

                }

            }

            //Find minimal average

            return minAverageStartingPosition;
        }

    }
}
