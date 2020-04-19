# CCI-recursion-and-dynamic-programming

##4.0 Memoization - Top-Down Dynamic programming on Fibonacci
Fibonacci sequence -> 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ... Each number equals the sum of the number before + two numbers before in sequence.
For this exercise I'm not returnig the tree with the sum, I'm implementing some code to create the tree of calls simulating I want to sum in this way: the number X = (X-1) + (X-2)

I did implement two version of the exercise to test fibonacci, the second of them with memoization approach(cache the results of Fibonacci(i) for each call), runtime goes down from worst case O(2^n) to O(n).

NOTE: as the exercise is implemented, the result of Fibonacci(2)= 1, Fibonacci(3)= 2. So the exercise is to show the approach 
IMPLEMENTATION:
- I did implement a brutal solution as a start, method "FibonacciCalculation(int aNumber)", covered by UT
  - then I did implement the **memoization** version of it, method "FibonacciMemoizationCalculation". Basically I pass around an array, the key is the node, if the value for the key is zero I save the value in order to be reused, otherwise I skip the calculation by reusing the value in the array.



## 4.1 Routes Between Nodes
Given a directed graph, design an algorithm to find out whether there is a route between two nodes.

SOLUTION:

It's an implemetation of a BFS(Breadth First Search), the problem can be solved with just a simple graphs traversal, the scope is to visit before all the immediate neighbors. We start with one node and check if the other node is found. We have to mark nodes as already visited.

LOGIC:

- a
- b
  - b1
    - b2
    - b3
      - c

[**link text**](https://github.com/lucafilippodangelo/CCI-trees-and-graphs/tree/master/Q4_01_RouteBetweenNodes)