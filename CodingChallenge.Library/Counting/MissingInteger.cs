using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Counting
{
    public class MissingInteger
    {

        public int Solve(int[] A)
        {

            int N = A.Length;

            //First, find max number
            int max = int.MinValue;
            for (int index = 0; index < N; index++)
            {
                if (A[index] > max) max = A[index];
            }

            if (max <= 0) return 1;

            int[] countArray = new int[max + 1];

            //Array to keep element count
            for (int index = 0; index < N; index++)
            {
                int currentNumber = A[index];
                if (currentNumber > 0) {
                    countArray[currentNumber] += 1;
                }
            }

            for (int index = 1; index < countArray.Length; index++)
            {
                if (countArray[index] == 0) return index;
            }

            //All the number appear, so the next number is the one.
            return countArray.Length;

        }

        public int SolveFirstSolution(int[] A) {

            int N = A.Length;

            //First, find max number
            int max = int.MinValue;
            for (int index = 0; index < N; index++)
            {
                if (A[index] > max) max = A[index];
            }

            if (max <= 0) return 1;

            int[] countArray = new int[max + 1];

            //Array to keep element count
            for (int index = 0; index < N; index++)
            {
                int currentNumber = A[index];
                countArray[currentNumber] += 1;
            }

            for (int index = 1; index < countArray.Length; index++)
            {
                if (countArray[index] == 0) return index;
            }

            //All the number appear, so the next number is the one.
            return countArray.Length;

        }

    }
}
