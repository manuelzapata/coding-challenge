using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Counting
{
    public class PermutationCheck
    {

        public int Solve(int[] A) {

            int N = A.Length;

            //Array to keep the count of elements.
            int[] countArray = new int[N + 1];

            //Count the occurrence of every number in the array
            for (int index = 0; index < N; index++)
            {
                int currentNumber = A[index];
                if (currentNumber < N + 1) {
                    countArray[currentNumber] += 1;
                }
            }

            //Check count. Every number should be only once.
            for (int index = 1; index < countArray.Length; index++)
            {
                if (countArray[index] != 1) return 0;
            }

            return 1;
        }

    }
}
