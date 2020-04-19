using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RecursionAndDynamicProgramming
{

    public class testsTripleStep
    {


        [Fact]
        public void TestTripleStepTopDownRecursiveMemoization()
        {

            var returnedValue = tripleStep.TripleStepTopDownRecursiveMemoization(3);

            Assert.True(true);
        }

        public class tripleStep
        {

            public static int TripleStepTopDownRecursiveMemoization(int depth)
            {
                int[] memo = new int [depth + 1];

                for (int i = 0; i < depth + 1; i++)
                {
                    memo[i] = -1;
                }

                return TripleStepTopDownRecursiveMemoization(depth, memo);
            }


            public static int TripleStepTopDownRecursiveMemoization(int depth, int[] memo)
        {
                if (depth < 0)
                    return 0;

                if (depth == 0)
                    return 1; //add one to the total because it is a valid hop

                if (memo[depth] > -1)
                    return memo[depth];

                var a = TripleStepTopDownRecursiveMemoization(depth - 1);
                var b = TripleStepTopDownRecursiveMemoization(depth - 2);
                //var c = TripleStepTopDownRecursiveMemoization(depth - 3);
                
                //I memorize how many possible hops from this level towards down.
                memo[depth] = a + b;// + c;

                return memo[depth];
            }

         
        }
    }

}
