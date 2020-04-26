# CCI-recursion-and-dynamic-programming

## 8.0 Memoization - Top-Down Dynamic programming on Fibonacci

Fibonacci sequence -> 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ... Each number equals the sum of the number before + two numbers before in sequence.
For this exercise I'm not returnig the tree with the sum, I'm implementing some code to create the tree of calls simulating I want to sum in this way: the number X = (X-1) + (X-2)

I did implement two version of the exercise to test fibonacci, the second of them with memoization approach(cache the results of Fibonacci(i) for each call), runtime goes down from worst case O(2^n) to O(n).

NOTE: as the exercise is implemented, the result of Fibonacci(2)= 1, Fibonacci(3)= 2. So the exercise is to show the approach 
IMPLEMENTATION:
- I did implement a brutal solution as a start, method "FibonacciCalculation(int aNumber)", covered by UT
  - then I did implement **memoization** version of it
    - "**Top Down Recursive**" method "FibonacciMemoizationTopDownCalculation". I pass around an array, the key is the node, if the value for the key is zero I save the value in order to be reused, otherwise I skip the calculation by reusing the value in the array.
    - "**Bottom Up Iterative**" method "FibonacciMemoizationBottomUpCalculation". I iteratively populate the array indexes with sums starting from base cases. 

## 8.1 Triple step
**Exercise:** A child is running up a staircase with "n" steps and can hop either 1 step, 2 steps, 3 steps at a time. Implement a method to count how many possible way the child can run up the stairs.

SOLUTION:

![Image description](https://github.com/lucafilippodangelo/CCI-recursion-and-dynamic-programming/blob/master/RecursionAndDynamicProgramming/RecursionAndDynamicProgramming/Images/TripleStep_exampleWithTwoHopsAndDepthFour.jpg)

Starting from the top node I go down until the base case, the base case is that one where is not possible anymore to do any type of further step(one,two or three). 

I evaluate all the possible decision the child can make at any hop he does.

At each level I save in an array the number of possible hops, and I try to reuse them up to the root. 

**For instance** in the image I did an example with just hops of "one" and "two". At "Level Node Three" I can potentially make the hops of "step Node Two"(a total of 3) + "step Node One" (a total of 1), I could update the function in order to add another "two steps": node 3 to node 2 + node 3 to node one, that would give me the correct total

Then I return at the last recursive interaction.

COMPLEXITY:

Would be O(3^N) where "3" is the split happening at each recursion and "N" is the depth. With Memoization complexity is O(N) because a new calculation is done only for undiscovered cases.

[**Implementation Triple Step**](https://github.com/lucafilippodangelo/CCI-recursion-and-dynamic-programming/blob/master/RecursionAndDynamicProgramming/RecursionAndDynamicProgramming/8.1_TripleStep.cs)

## 8.2 Robot in a Grid
**Exercise:** Imagine a robot sitting on the upper left corner of grid with r rows and c columns. The robot can only move in two directions, right and down, but certain cels are "off limits" such that the robot cannot step on them. Design an algorithm to find a path for the robot from the top left to the bottom right.

SOLUTION:

The code is well commented. 
The approach is top down: 
I consider as base case the top-left position, 
  - I build a tree of recursion moving from each position right or bottom, 
    - I go down until I find the goalPosition and consider that as a valid position.
      - Then I recursively go up the tree of recursion, if I was comong from at least a "valid" position I consider that position valid.
        - I skip not valid position, did create a condition for that.

COMPLEXITY:

Would be O(2^row+columns) where "2" is the split happening at each recursion and "row+columns" is the depth. With Memoization complexity is O("row+columns") because a new calculation is done only for undiscovered cases.

[**Implementation Robot In A Grid**](https://github.com/lucafilippodangelo/CCI-recursion-and-dynamic-programming/blob/master/RecursionAndDynamicProgramming/RecursionAndDynamicProgramming/8.2_RobotInAGrid.cs)

## 8.3 Magic Index

**Exercise One:** A magic index in an array A[1...n-1] is defined to be an index such that A[i] = i. Given a sorted array of **distinct** integers, write a method to find a magic index if one exists in the array A. 

SOLUTION: did implement a recursive binary search

**Exercise Two:** A magic index in an array A[1...n-1] is defined to be an index such that A[i] = i. Given a sorted array of **not distinct** integers, write a method to find a magic index if one exists in the array A. 