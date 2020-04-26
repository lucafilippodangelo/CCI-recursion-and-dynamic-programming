using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RecursionAndDynamicProgramming
{

    public class TestsTripleStep
    {


        [Fact]
        public void TestTripleStepTopDownRecursiveMemoization()
        {

            var returnedValue = tripleStep.TripleStepTopDownRecursiveMemoization(2);

            Assert.True(true);
        }

        public class tripleStep
        {

            public static int TripleStepTopDownRecursiveMemoization(int depth)
            {
                int[] memo = new int [depth + 1];

                // Initialization of all the array item to the default
                for (int i = 0; i < depth + 1; i++)
                {
                    memo[i] = -1;
                }

                return TripleStepTopDownRecursiveMemoization(depth, memo);
            }


            public static int TripleStepTopDownRecursiveMemoization(int depth, int[] memo)
            {
                // Base Cases - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
                if (depth < 0)
                    return 0;

                if (depth == 0)
                    return 1; //add one to the total because it is a valid hop THIS IS AMBIGUOIS, IT COULD BE DEFINED AS A ZERO, SEE BOOK

                // Recursion - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                if (memo[depth] > -1) 
                {
                    //if it's a case the procedure already discovered
                    return memo[depth];
                }
                else
                {
                    var a = TripleStepTopDownRecursiveMemoization(depth - 1); //for the level where I am I'm considering all the possible hops COMBINATIONS from ONE level down
                    var b = TripleStepTopDownRecursiveMemoization(depth - 2); //for the level where I am I'm considering all the possible hops COMBINATIONS from TWO level down

                    //var c = TripleStepTopDownRecursiveMemoization(depth - 3);

                    //I memorize how many possible hops from this level(the current index level) towards down.
                    memo[depth] = a + b;// + c;

                    return memo[depth];
                }
            }

        }
    }

}
