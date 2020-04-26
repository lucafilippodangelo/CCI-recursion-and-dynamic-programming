using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RecursionAndDynamicProgramming
{
    public class TestMagicIndex
    {

        [Fact]
        public void MagicIndexUT()
        {
            int[] numbersMatchingAtIndex7 = { -40, -20, -1, 1, 2, 3, 5, 7, 9, 10,  20,  30};
            int position = MagicIndex.checkMatch(numbersMatchingAtIndex7, 0, numbersMatchingAtIndex7.Length);
            Assert.Equal(position,7);

            int[] numbersMatchingAtIndex2 = { -40, -20, 2,  3, 5, 7, 9, 9, 10, 20, 30 };
            position = MagicIndex.checkMatch(numbersMatchingAtIndex2, 0, numbersMatchingAtIndex2.Length);
            Assert.Equal(position, 2);

            int[] notmatching = { -40, -20, 3, 5, 7, 9, 10, 20, 30 };
            position = MagicIndex.checkMatch(notmatching, 0, notmatching.Length);
            Assert.Equal(position, -1);
        }
        public class MagicIndex
        {

            public static int checkMatch(int[] anArray, int start, int end)
            {
                // Base Cases - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
                if (end<start)
                    return -1;

                // Recursion - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                int currentPivotIndex = (start + end) / 2;

                if (anArray[currentPivotIndex] == currentPivotIndex)
                {
                    return currentPivotIndex;
                }
                else if (anArray[currentPivotIndex] > currentPivotIndex) 
                {
                    //then need to investigate in the left side of the current array
                    return checkMatch(anArray, start, currentPivotIndex - 1);
                }
                else {
                    //then need to investigate in the right side of the current array
                    return checkMatch(anArray, currentPivotIndex + 1, end);
                }
            }

        }



    }
}
