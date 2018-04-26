using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Leader
{
    public class EquiLeader
    {

        public const int NoLeader = -1000000001;

        public int Solve(int[] A) {

            int N = A.Length;
            int[] leftLeader = new int[N];
            leftLeader[0] = A[0];
            int leftSize = 1;
            int leftLeaderCount = 1;
            Dictionary<int, int> count = new Dictionary<int, int> {
                { A[0], 1 }
            };

            //Calculate left leaders
            for (int index = 1; index < N; index++)
            {
                int currentValue = A[index];
                if (!count.ContainsKey(currentValue)) count[currentValue] = 0;
                count[currentValue] += 1;

                if (currentValue == leftLeader[leftSize - 1])
                {
                    //Same leader
                    leftLeader[leftSize] = currentValue;
                    leftSize++;
                    leftLeaderCount++;
                }
                else {
                    leftSize++;
                    if (leftLeaderCount > leftSize / 2)
                    {
                        //Continues as leader, despite the last element is not the leader
                        leftLeader[leftSize - 1] = leftLeader[leftSize - 2];
                    }
                    else {
                        //Find new leader (if there is any)
                        int newLeader = int.MinValue;
                        int leaderCount = 0;
                        foreach (KeyValuePair<int, int> pair in count)
                        {
                            if (pair.Key > newLeader) {
                                newLeader = pair.Key;
                                leaderCount = pair.Value;
                            }
                        }

                        if (leaderCount > leftSize / 2) {
                            //New Leader!!!
                            leftLeader[leftSize - 1] = newLeader;
                        } else {
                            leftLeader[leftSize - 1] = NoLeader;
                        }

                    }

                }
            }


            return 0;
        }

    }
}
