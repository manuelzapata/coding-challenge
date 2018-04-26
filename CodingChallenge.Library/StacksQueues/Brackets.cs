using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.StacksQueues
{
    public class Brackets
    {

        public int Solve(string S) {

            int N = S.Length;
            if (N == 0) return 1;

            char[] stack = new char[N];
            stack[0] = S[0];
            int stackSize = 1;

            for (int index = 1; index < N; index++)
            {
                char currentCharacter = S[index];
                switch (currentCharacter)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack[stackSize] = currentCharacter;
                        stackSize++;
                        break;
                    case ')':
                        if (stackSize == 0 || stack[stackSize - 1] != '(') return 0;
                        else {
                            stack[stackSize - 1] = (char)0;
                            stackSize--;
                        }
                        break;
                    case ']':
                        if (stackSize == 0 || stack[stackSize - 1] != '[') return 0;
                        else
                        {
                            stack[stackSize - 1] = (char)0;
                            stackSize--;
                        }
                        break;
                    case '}':
                        if (stackSize == 0 || stack[stackSize - 1] != '{') return 0;
                        else
                        {
                            stack[stackSize - 1] = (char)0;
                            stackSize--;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (stackSize > 0) return 0;

            return 1;

        }


    }
}
