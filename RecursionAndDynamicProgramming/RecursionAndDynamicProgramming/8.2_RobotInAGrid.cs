using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionAndDynamicProgramming
{
    public class TestRobotInAGrid
    {

        public class TestRobotInAGridExercise
        {
            List<(int, int)> path = new List<(int, int)>();

            //I do simulate the offlimits with a false
            bool[,] inputGrid = new bool[4, 3] { { true, true, true },
                                                 { true, true, false },
                                                 { true, true, false },
                                                 { true, true, true }
            };

            RobotInAGridExercise(inputGrid, path);
        }

        public class RobotInAGridExercise()
        {

        }

    }
}
