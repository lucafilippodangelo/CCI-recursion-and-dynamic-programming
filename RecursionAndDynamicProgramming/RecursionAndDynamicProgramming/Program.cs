using System;
using Xunit;

namespace RecursionAndDynamicProgramming
{
    public class Program
    {
        public static void MainLd(string[] args)
        {
            Console.WriteLine("Hello World!");
            //test
        }
    }

    /*
    public class testsPrep
    {
        public static IEnumerable<object[]> PrepBSTSequences()
        {

            Node Node1 = new Node(1); Node1.LDvalue = 1;
            Node Node2 = new Node(2); Node2.LDvalue = 2;
            Node Node3 = new Node(3); Node3.LDvalue = 3;
            Node Node4 = new Node(4); Node4.LDvalue = 4;
            Node Node5 = new Node(5); Node5.LDvalue = 5;
            Node Node6 = new Node(6); Node6.LDvalue = 6;
            Node Node7 = new Node(7); Node7.LDvalue = 7;

            //LD Graph creation
            Graph Graph1 = new Graph();
            Graph1.Nodes = new List<Node> { Node1, Node2, Node3, Node4, Node5, Node6, Node7 };

            //LD Graph setup
            // N7 visitable from N1, not from N2
            // We can visit N4, N1->N3->N6->N4 or N1->N2->N4. The shortest path has two steps
            Graph1.nodePointTo(Node1, new List<Node>() { Node2, Node3 });
            Graph1.nodePointTo(Node2, new List<Node>() { Node5, Node4 });
            Graph1.nodePointTo(Node3, new List<Node>() { Node6 });
            Graph1.nodePointTo(Node5, new List<Node>() { Node4 });
            Graph1.nodePointTo(Node6, new List<Node>() { Node4, Node7 });

            //LD TESTS ------------------
            bool result;
            //result = Implementation.search(Graph1, Node2, Node7); //expected "-1", the nodes are not connected.
            //result = Implementation.search(Graph1, Node1, Node4); //expected "2", the nodes are connected by two steps

            yield return new object[] { Graph1, Node2, Node7 };
            yield return new object[] { Graph1, Node1, Node4 };


        }

    }
    */
    public class tests
    {


        [Fact]
        //[Theory]
        //[MemberData(nameof(testsPrep.PrepBSTSequences), MemberType = typeof(testsPrep))]
        public void BSTSequences() //4.9
        {

            Assert.Equal(4, 4);

        }
    }
}
