using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Sorting
{
    public class Distinct
    {

        public int Solve(int[] A) {

            //Sort array
            Array.Sort(A);
            int lastUniqueNumber = -1000001;
            int result = 0;

            for (int index = 0; index < A.Length; index++)
            {
                int currentNumber = A[index];
                if (currentNumber != lastUniqueNumber)
                {
                    result++;
                    lastUniqueNumber = currentNumber;
                }

            }

            return result;
        }

    }
}
