using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Sorting
{
    public class NumberOfDiscIntersections
    {

        public int Solve(int[] A)
        {
            int N = A.Length;

            int[] rangeUpper = new int[N];
            int[] rangeLower = new int[N];

            for (int index = 0; index < N; index++)
            {
                rangeUpper[index] = index + A[index];
                rangeLower[index] = index - A[index];
            }

            Array.Sort(rangeUpper);
            Array.Sort(rangeLower);

            int rangeLowerIndex = 0;
            int intersectCount = 0;

            for (int rangeUpperIndex = 0; rangeUpperIndex < N; rangeUpperIndex++)
            {

                while (rangeLowerIndex < N && rangeUpper[rangeUpperIndex] >= rangeLower[rangeLowerIndex]) {
                    rangeLowerIndex += 1;
                }

                intersectCount += (rangeLowerIndex - rangeUpperIndex - 1);
                if (intersectCount > 10000000) return -1;

            }

            return intersectCount;

        }

        //public int Solve(int[] A) {

        //    int N = A.Length;
        //    //Find max radius
        //    int maxRadius = int.MinValue;
        //    for (int index = 0; index < A.Length; index++)
        //    {
        //        if (A[index] > maxRadius) {
        //            maxRadius = A[index];
        //        }
        //    }

        //    int[] intersections = new int[maxRadius + N];

        //    //Establish number of intersections per position
        //    for (int index = 0; index < A.Length; index++)
        //    {
        //        int radius = A[index];
        //        int startPosition = index - radius;
        //        if (startPosition < 0) startPosition = 0;
        //        int endPostion = index + radius;

        //        for (int indexIntersection = startPosition; indexIntersection <= endPostion; indexIntersection++)
        //        {
        //            intersections[indexIntersection] += 1;
        //        }

        //    }

        //    int result = 0;
        //    //Count intersections
        //    for (int index = 0; index < intersections.Length; index++)
        //    {
        //        if (intersections[index] > 1) {
        //            result += intersections[index];
        //        }
        //    }

        //    return result;

        //}

        }
}
