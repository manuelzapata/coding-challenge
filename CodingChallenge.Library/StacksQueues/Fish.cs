using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.StacksQueues
{
    public class Fish
    {

        public int Solve(int[] A, int[] B) {

            int N = A.Length;

            //We will store the positions of the fishes in the following array.
            int[] aliveFishes = new int[N];
            //There is at least one fish in the river. At the beginning, this fish is alive.
            int aliveFishCount = 1;

            for (int index = 1; index < N; index++)
            {
                int currentFishDirection = B[index];
                int currentFishSize = A[index];

                int lastFishPosition = aliveFishes[aliveFishCount - 1];
                int lastFishDirection = B[lastFishPosition];
                int lastFishSize = A[lastFishPosition];

                if (lastFishDirection == 1 && currentFishDirection == 0)
                {
                    // if lastFishSize > currentFishSize, the last fish in the array eats the current one. Nothing changes
                    if (currentFishSize > lastFishSize)
                    {
                        aliveFishes[aliveFishCount - 1] = index;
                    }

                }
                else if (lastFishDirection == currentFishDirection || lastFishDirection == 0 && currentFishDirection == 1) {
                    aliveFishes[aliveFishCount] = index;
                    aliveFishCount++;
                }

            }

            return aliveFishCount;
        }

    }
}
