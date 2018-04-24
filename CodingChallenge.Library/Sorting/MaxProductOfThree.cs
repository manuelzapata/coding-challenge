using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Sorting
{
    public class MaxProductOfThree
    {

        public int Solve(int[] A) {

            Array.Sort(A);
            int result = int.MinValue;

            for (int index = 0; index < A.Length - 2; index++)
            {
                int product = A[index] * A[index + 1] * A[index + 2];
                if (product > result) result = product;
            }

            //Check also the biggest negative numbers and the biggest positive number
            int potentialBiggestProduct = A[0] * A[1] * A[A.Length - 1];
            if (potentialBiggestProduct > result) result = potentialBiggestProduct;


            return result;
        }

    }
}
