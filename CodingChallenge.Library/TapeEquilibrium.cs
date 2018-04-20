using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library
{
    public class TapeEquilibrium
    {
        public int Solve(int[] A) {

            Dictionary<int, int> left = new Dictionary<int, int>();
            Dictionary<int, int> right = new Dictionary<int, int>();
            int leftSum = 0, rightSum = 0;

            /**
             * Iterate from the left and iterate from the right at the same time.
             */


            for (int leftIndex = 0, rightIndex = A.Length - 1; leftIndex < A.Length - 1; leftIndex++, rightIndex--)
            {
                leftSum += A[leftIndex];
                left[leftIndex + 1] = leftSum;

                rightSum += A[rightIndex];
                right[rightIndex] = rightSum;
            }

            int min = int.MaxValue;

            //Subtract right from left and find minimum
            foreach (KeyValuePair<int, int> pair in left)
            {
                int diff = Math.Abs(pair.Value - right[pair.Key]);
                if (diff < min) {
                    min = diff;
                }
            }
            return min;
        }
    }
}
