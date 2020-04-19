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

At each level I save in an array the number of possible hops, and I try to reuse them up to the root. 

**For instance** in the image I did an example with just hops of "one" and "two". At "Level Node Three" I can potentially make the hops of "step Node Two"(a total of 3) + "step Node One" (a total of 1), I could update the function in order to add another "two steps": node 3 to node 2 + node 3 to node one

Then I return at the last recursive interaction.


[**Implementation Triple Step**](https://github.com/lucafilippodangelo/CCI-recursion-and-dynamic-programming/blob/master/RecursionAndDynamicProgramming/RecursionAndDynamicProgramming/8.1_TripleStep.cs)