using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Leader
{
    public class Dominator
    {

        public int Solve(int[] A) {

            int N = A.Length;
            if (N == 0) return -1;

            //Apply technique in lesson to find potential dominator
            int? potentialDominator = null;
            int size = 0;

            for (int index = 0; index < N; index++)
            {
                if (size == 0)
                {
                    size++;
                    potentialDominator = A[index];
                }
                else if (potentialDominator != A[index])
                {
                    size -= 1;
                }
                else {
                    size += 1;
                }
            }

            //There is no dominator. Not even a potential one.
            if (size == 0) return -1;
            int count = 0;
            int dominatorPosition = -1;

            for (int index = 0; index < N; index++)
            {
                if (A[index] == potentialDominator) {
                    count++;
                    dominatorPosition = index;
                }
            }

            int position = -1;
            if (count > N / 2) {
                position = dominatorPosition;
            }


            return position;
        }

    }
}
