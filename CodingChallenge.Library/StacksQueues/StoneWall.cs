using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.StacksQueues
{
    public class StoneWall
    {

        public int Solve(int[] H) {

            int N = H.Length;

            //Stack to keep track of the height of the last block
            int[] lastBlockHeight = new int[N];
            int size = 0;
            int blockCount = 0;

            //First block
            lastBlockHeight[size] = H[0];
            size++;
            blockCount++;

            for (int index = 1; index < N; index++)
            {
                int height = H[index];
                if (height > lastBlockHeight[size - 1])
                {
                    //Add another block on top of the previous one
                    lastBlockHeight[size] = height;
                    size++;
                    blockCount++;
                }
                else if (height < lastBlockHeight[size - 1]) {

                    //Remove blocks from the stack
                    int lastHeight = int.MaxValue;
                    while (height < lastHeight && size > 0) {
                        lastHeight = lastBlockHeight[size - 1];
                        if (height < lastHeight)
                        {
                            lastBlockHeight[size - 1] = 0;
                            size--;
                        }
                        else if (height > lastHeight) {
                            lastBlockHeight[size] = height;
                            size++;
                            blockCount++;
                        }
                    }
                    if (size == 0) {
                        //Another block (smaller than the previous one).
                        lastBlockHeight[size] = height;
                        size++;
                        blockCount++;
                    }

                }
            }

            return blockCount;

        }

    }
}
