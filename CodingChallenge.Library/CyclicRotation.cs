using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library
{
    public class CyclicRotation
    {

        public int[] Solve(int[] A, int K) {

            int length = A.Length;
            int[] rotatedArray = new int[length];

            for (int index = 0; index < length; index++)
            {
                int newPosition = (index + K) % length;
                rotatedArray[newPosition] = A[index];
            }

            return rotatedArray;

        }

    }
}
