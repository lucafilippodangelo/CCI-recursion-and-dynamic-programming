using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RecursionAndDynamicProgramming
{
    public class TestRobotInAGrid
    {

        [Fact]
        public void TestTripleStepTopDownRecursiveMemoizationTwoXTwo()
        {
            List<Tuple<int, int>> validPath = new List<Tuple<int, int>>();
            List<Tuple<int, int>> discoveredPath = new List<Tuple<int, int>>();

            //I do simulate the offlimits with a false
            bool[,] inputMazeGridOne = new bool[2,2] { { true, false },
                                                       { true, true }
                                                 
            };
            var btOne = 1; //I'm testing with a square matrix, passing the coordinates for bottom right

            var aBoolean = TestRobotInAGridExercise.getPath(0, 0, btOne, inputMazeGridOne, validPath, discoveredPath);

            Assert.True(true);
        }

        [Fact]
        public void TestTripleStepTopDownRecursiveMemoizationThreeXThree()
        {
            List<Tuple<int, int>> validPath = new List<Tuple<int, int>>();
            List<Tuple<int, int>> discoveredPath = new List<Tuple<int, int>>();

            //I do simulate the offlimits with a false
            bool[,] inputMazeGrid = new bool[3, 3] { { true, true, true },
                                                 { true, true, false },
                                                 { true, true, true}            };
            var bt = 2; //I'm testing with a square matrix, passing the coordinates for bottom right
            
            var aBoolean = TestRobotInAGridExercise.getPath(0, 0, bt, inputMazeGrid, validPath, discoveredPath);

            Assert.True(true);
        }
        public class TestRobotInAGridExercise
        {

            public static bool getPath(int row, int col, int bt, bool[,] inputMazeGrid, List<Tuple<int, int>> validPath, List<Tuple<int, int>> discoveredPath)
            {
                // Base Cases - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
                if (row > bt || col > bt) //Not valid point: do not need to explore anymore
                    return false;

                if (inputMazeGrid[row, col] == false) //Not valid point: skip invalid coordinates where the robot cannot go
                    return false;

                //If the cell is already visited then return
                if (discoveredPath.Contains(Tuple.Create(row, col)))
                    return false;


                // Recursion - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                // the plan is to start from the top left and explore until the goal point
                bool isGoalPOint = (row == bt && col == bt); //this point has to be added as valid

                //at each point we check recurring bottom up(recompone from bottom-right to top-left) if we are coming from avalid path.
                // We come from a valid path if one of the three conditions is true, then record the point

                var returnedFromDown = getPath(row + 1, col, bt, inputMazeGrid, validPath, discoveredPath); //advance down(row)
                var returnedFromRight = getPath(row, col + 1, bt, inputMazeGrid, validPath, discoveredPath); //advance right(column) 

                if (isGoalPOint || returnedFromDown || returnedFromRight )
                {
                    //create the point and add the point to the list of the valid one
                    validPath.Add(Tuple.Create(row, col));
                    return true;
                }

                discoveredPath.Add(Tuple.Create(row, col));

                return false; //default return, this procedure will never get here
            }

        }



    }
}
