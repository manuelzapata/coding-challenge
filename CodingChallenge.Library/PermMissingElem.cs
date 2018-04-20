using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library
{
    public class PermMissingElem
    {

        public int Solve(int[] A) {

            //Sum numbers from 1 to (N + 1)
            int totalSum = 0;
            for (int index = 1; index <= A.Length + 1; index++)
            {
                totalSum += index;
            }

            int arraySum = 0;
            for (int index = 0; index < A.Length; index++)
            {
                arraySum += A[index];
            }

            int missingElement = totalSum - arraySum;
            return missingElement;
        }

    }
}
