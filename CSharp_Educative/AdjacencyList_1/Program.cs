using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList_1
{
    public enum Color
    {
        White,
        Blue,
        Black
    }

    public class EdgeNode
    {
        public string Name;
        public int weight;
        public int distance;
        public bool visited;
        public Color color;
        public EdgeNode parent;
    }

    public class Graph
    {
        public int numVertex;
        public int numEdges;


        private Dictionary<EdgeNode, LinkedList<EdgeNode>> edgeList;

        public Dictionary<EdgeNode, LinkedList<EdgeNode>> EdgeList => edgeList;

        public Graph(int nVertex)
        {
            numVertex = nVertex;
            edgeList = new Dictionary<EdgeNode, LinkedList<EdgeNode>>();
        }

        public void AddEdgeToend(EdgeNode startvertex, EdgeNode destinationVertex, int weight)
        {
            LinkedList<EdgeNode> list;
            if (edgeList.ContainsKey(startvertex))
            {
                list = edgeList[startvertex];
            }
            else
            {
                list = new LinkedList<EdgeNode>();
                edgeList.Add(startvertex, list);
            }
            if(destinationVertex != null)
                list.AddLast(destinationVertex);
        }

        public List<EdgeNode> BreadthFirstSearch(EdgeNode startVertex)
        {
            if (!edgeList.ContainsKey(startVertex))
                return null;
            //int count = 1;

            List<EdgeNode> array = new List<EdgeNode>();
            Queue<EdgeNode> queue = new Queue<EdgeNode>();

            startVertex.visited = true;
            startVertex.color = Color.Blue;
            startVertex.parent = null;
            queue.Enqueue(startVertex);

            while (queue.Count != 0)
            {
                var vertex = queue.Dequeue();
                vertex.color = Color.Black;
                array.Add(vertex);

                if (edgeList.ContainsKey(vertex))
                {
                    var lists = edgeList[vertex];

                    foreach (var node in lists)
                    {
                        if (!node.visited)
                        {
                            node.distance = vertex.distance + 1;
                            node.color = Color.Blue;
                            node.visited = true;
                            node.parent = vertex;
                            queue.Enqueue(node);
                        }
                    }
                }

                //count++;
            }

            //Console.WriteLine("Count: {0} ", count);

            return array;
        }

        //Find a path x to y vertex
        public List<string> FindPath(EdgeNode start, EdgeNode end, List<string> array)
        {
            if (start == end)
            {
                array.Add(end.Name);
                return array;
            }
            else
            {
                array.Add(end.Name);
                var lists = edgeList[end];

                foreach (var list in lists)
                {
                    if (list.distance == end.distance - 1)
                    {
                        end = list;
                        break;
                    }
                }

                FindPath(start, end, array);
            }

            return array;
        }

        public int FindNumberOfConnectedComponents(Graph gh)
        {
            int nVertex = gh.numVertex;

            var adjlists = gh.EdgeList;

            int count = 0;

            foreach (var adjlist in adjlists)
            {
                var edgeNode = adjlist.Key;
                if (!edgeNode.visited)
                {
                    edgeNode.visited = true;
                    count++;
                    BreadthFirstSearch(edgeNode);
                }
            }

            return count;
        }

        public List<EdgeNode> DeepthFirstSearch(EdgeNode startVertex)
        {
            List<EdgeNode> array = new List<EdgeNode>();

            foreach (var list in edgeList)
            {
                if (!list.Key.visited)
                {
                    DeepthFirstSearch(list.Key, array);
                }
            }

            return array;
        }

        public void DeepthFirstSearch(EdgeNode startVertex, List<EdgeNode> array)
        {
            
            if (!edgeList.ContainsKey(startVertex))
            {
                startVertex.visited = true;
                startVertex.color = Color.Black;
                array.Add(startVertex);
                return;
            }

            startVertex.visited = true;
            startVertex.color = Color.Black;
            array.Add(startVertex);

            var lists = edgeList[startVertex];

            foreach (var list in lists)
            {
                if (!list.visited)
                {
                    list.visited = true;
                    list.distance = startVertex.distance + 1;
                    list.parent = startVertex;
                    DeepthFirstSearch(list, array);
                    list.color = Color.Black;
                }
            }

            return;
        }


        public LinkedList<string> TopologicalSort(EdgeNode StartVertex)
        {
            if (EdgeList.ContainsKey(StartVertex))
            {
                var array = new LinkedList<string>();
                
                if(!StartVertex.visited)
                    DFS(StartVertex, array);

                foreach (var lists in edgeList)
                {
                    if (!lists.Key.visited)
                        DFS(lists.Key, array);
                }

                return array;
            }

            return null;
        }

        private void DFS(EdgeNode startVertex, LinkedList<string> array)
        {
            if (!EdgeList.ContainsKey(startVertex))
            {
                startVertex.visited = true;
                array.AddFirst(new LinkedListNode<string>(startVertex.Name));
                return;
            }

            startVertex.visited = true;

            var lists = edgeList[startVertex];

            foreach (var list in lists)
            {
                if (!list.visited)
                {
                    DFS(list,array);
                }
            }

            array.AddFirst(new LinkedListNode<string>(startVertex.Name));
        }

        public bool IsGraphHasCycle(EdgeNode startVertex)
        {
            bool isCyclic = false;
            if (EdgeList.ContainsKey(startVertex))
            {
                DFSCycle(startVertex, ref isCyclic);

                if (isCyclic) return true;
            }

            foreach (var vertex in EdgeList)
            {
                if (!vertex.Key.visited)
                {
                    DFSCycle(vertex.Key, ref isCyclic);

                    if (isCyclic) return true;
                }
            }

            return false;
        }

        private void DFSCycle(EdgeNode startVertex, ref bool isCyclic)
        {
            if (!EdgeList.ContainsKey(startVertex))
            {
                startVertex.visited = true;
                return;
            }

            var list = EdgeList[startVertex];

            foreach (var vertex in list)
            {
                if (!vertex.visited)
                {
                    vertex.visited = true;
                    DFSCycle(vertex, ref isCyclic);
                }
                else
                {
                    isCyclic = true;
                    return;
                }
            }
        }
    }

    class Program
    {
        public static void TestGraph1()
        {
            var nodeS = new EdgeNode()
            {
                Name = "S",
                distance = 0
            };

            var nodeA = new EdgeNode()
            {
                Name = "A",
                distance = 0
            };

            var nodeB = new EdgeNode()
            {
                Name = "B",
                distance = 0
            };
            var nodeC = new EdgeNode()
            {
                Name = "C",
                distance = 0
            };
            var nodeD = new EdgeNode()
            {
                Name = "D",
                distance = 0
            };
            var nodeE = new EdgeNode()
            {
                Name = "E",
                distance = 0
            };

            SetValueTest1(nodeS, nodeA, nodeB, nodeC, nodeD, nodeE);


            int nVertex = 6;
            Graph graph = new Graph(nVertex);

            graph.AddEdgeToend(nodeS, nodeA, 0);
            graph.AddEdgeToend(nodeS, nodeB, 0);
            graph.AddEdgeToend(nodeA, nodeC, 0);
            graph.AddEdgeToend(nodeA, nodeS, 0);
            graph.AddEdgeToend(nodeB, nodeS, 0);
            graph.AddEdgeToend(nodeB, nodeC, 0);
            graph.AddEdgeToend(nodeB, nodeD, 0);
            graph.AddEdgeToend(nodeC, nodeA, 0);
            graph.AddEdgeToend(nodeC, nodeB, 0);
            graph.AddEdgeToend(nodeC, nodeE, 0);
            graph.AddEdgeToend(nodeC, nodeD, 0);
            graph.AddEdgeToend(nodeD, nodeB, 0);
            graph.AddEdgeToend(nodeD, nodeC, 0);
            graph.AddEdgeToend(nodeD, nodeE, 0);
            graph.AddEdgeToend(nodeE, nodeC, 0);
            graph.AddEdgeToend(nodeE, nodeD, 0);

            Console.WriteLine("Number of connected components");
            int count = graph.FindNumberOfConnectedComponents(graph);
            Console.WriteLine("Number of connected components {0}", count);


            SetValueTest1(nodeS, nodeA, nodeB, nodeC, nodeD, nodeE);

            Console.WriteLine("Breadth First Search");
            var result = graph.BreadthFirstSearch(nodeS);
            result.ForEach(r => Console.WriteLine("{0} {1} {2} {3}", r.Name, r.distance, r.color == Color.Black ? "Black  " : "Blue  ", r.parent != null ? r.parent.Name : "null"));


            List<string> array = new List<string>();
            graph.FindPath(nodeS, nodeE, array);

            Console.WriteLine("Path from {0} to {1}", nodeS.Name, nodeE.Name);
            for (int i = array.Count - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);
            }


            nodeS.visited = false;
            nodeS.distance = 0;

            nodeA.visited = false;
            nodeA.distance = 0;

            nodeB.visited = false;
            nodeB.distance = 0;

            nodeC.visited = false;
            nodeC.distance = 0;

            nodeD.visited = false;
            nodeD.distance = 0;

            nodeE.visited = false;
            nodeE.distance = 0;

            Console.WriteLine();
            Console.WriteLine("Deepth First Search");
            var arrayList = new List<EdgeNode>();
            result = graph.DeepthFirstSearch(nodeA);
            result.ForEach(r => Console.WriteLine("{0} {1} {2} {3}", r.Name, r.distance, r.color == Color.Black ? "Black  " : "Blue  ", r.parent != null ? r.parent.Name : "null" ));
        }
        
        public static void TestGraph2()
        {
            var node1 = new EdgeNode()
            {
                Name = "1",
                distance = 0,

            };

            var node2 = new EdgeNode()
            {
                Name = "2",
                distance = 0
            };

            var node3 = new EdgeNode()
            {
                Name = "3",
                distance = 0
            };
            var node4 = new EdgeNode()
            {
                Name = "4",
                distance = 0
            };
            var node5 = new EdgeNode()
            {
                Name = "5",
                distance = 0
            };
            var node6 = new EdgeNode()
            {
                Name = "6",
                distance = 0
            };


            SetValuesTest2(node1, node2, node3, node4, node5, node6);

            Graph graph = new Graph(6);
            graph.AddEdgeToend(node1, node2, 0);
            graph.AddEdgeToend(node2, node3, 0);
            graph.AddEdgeToend(node1, node3, 0);
            graph.AddEdgeToend(node4, node1, 0);
            graph.AddEdgeToend(node4, node5, 0);
            graph.AddEdgeToend(node5, node6, 0);
            graph.AddEdgeToend(node6, node4, 0);

            Console.WriteLine("Number of connected components");
            int count = graph.FindNumberOfConnectedComponents(graph);
            Console.WriteLine("Number of connected components: {0 }", count);


            Console.WriteLine("Breadth First Search");
            SetValuesTest2(node1, node2, node3, node4, node5, node6);
            var result = graph.BreadthFirstSearch(node1);
            result.ForEach(r => Console.WriteLine("{0} {1} {2} {3}", r.Name, r.distance, r.color == Color.Black ? "Black  " : "Blue  ", r.parent != null ? r.parent.Name : "null"));

            Console.WriteLine();
            Console.WriteLine("Deepth First Search");
            SetValuesTest2(node1, node2, node3, node4, node5, node6);
            result = graph.DeepthFirstSearch(node1);
            result.ForEach(r => Console.WriteLine("{0} {1} {2} {3}", r.Name, r.distance, r.color == Color.Black ? "Black  " : "Blue  ", r.parent != null ? r.parent.Name : "null"));

        }

        public static void TestGraph3()
        {
            var undershots = new EdgeNode()
            {
                Name = "undershots",
                distance = 0
            };

            var pants = new EdgeNode()
            {
                Name = "pants",
                distance = 0
            };

            var belt = new EdgeNode()
            {
                Name = "belt",
                distance = 0
            };

            var shirt = new EdgeNode()
            {
                Name = "shirt",
                distance = 0
            };

            var tie = new EdgeNode()
            {
                Name = "tie",
                distance = 0
            };

            var jacket = new EdgeNode()
            {
                Name = "jacket",
                distance = 0
            };

            var socks = new EdgeNode()
            {
                Name = "socks",
                distance = 0
            };

            var shoes = new EdgeNode()
            {
                Name = "shoes",
                distance = 0
            };

            var watch = new EdgeNode()
            {
                Name = "watch",
                distance = 0
            };

            Graph graph = new Graph(6);
            graph.AddEdgeToend(undershots, pants, 0);
            graph.AddEdgeToend(pants, belt, 0);
            graph.AddEdgeToend(shirt, belt, 0);
            graph.AddEdgeToend(shirt, tie, 0);
            graph.AddEdgeToend(tie, jacket, 0);

            graph.AddEdgeToend(undershots, shoes, 0);
            graph.AddEdgeToend(pants, shoes, 0);
            graph.AddEdgeToend(socks, shoes, 0);
            graph.AddEdgeToend(watch, null, 0);
            graph.AddEdgeToend(belt, jacket, 0);

            LinkedList<string> array = graph.TopologicalSort(shirt);

            foreach (var item in array)
            {
                Console.WriteLine("{0}",item);
            }

            Console.WriteLine();

        }

        public static void TestGraph4()
        {
            var node1 = new EdgeNode()
            {
                Name = "1",
                distance = 0
            };

            var node2 = new EdgeNode()
            {
                Name = "2",
                distance = 0
            };

            var node3 = new EdgeNode()
            {
                Name = "3",
                distance = 0
            };

            var node4 = new EdgeNode()
            {
                Name = "4",
                distance = 0
            };

            var node5 = new EdgeNode()
            {
                Name = "5",
                distance = 0
            };

            Graph graph = new Graph(6);
            graph.AddEdgeToend(node1, node2, 0);
            graph.AddEdgeToend(node1, node4, 0);
            graph.AddEdgeToend(node2, node3, 0);
            graph.AddEdgeToend(node2, node4, 0);
            graph.AddEdgeToend(node4, node5, 0);
            graph.AddEdgeToend(node4, node3, 0);

            LinkedList<string> array = graph.TopologicalSort(node1);

            foreach (var item in array)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine();

        }

        public static void TestGraph5()
        {
            var node0 = new EdgeNode()
            {
                Name = "0",
                distance = 0
            };

            var node1 = new EdgeNode()
            {
                Name = "1",
                distance = 0
            };

            var node2 = new EdgeNode()
            {
                Name = "2",
                distance = 0
            };

            var node3 = new EdgeNode()
            {
                Name = "3",
                distance = 0
            };

            Graph graph = new Graph(6);
            graph.AddEdgeToend(node0, node1, 0);
            graph.AddEdgeToend(node0, node2, 0);
            graph.AddEdgeToend(node1, node2, 0);
            graph.AddEdgeToend(node2, node3, 0);
            graph.AddEdgeToend(node2, node0, 0);
            //graph.AddEdgeToend(node3, node3, 0);

             bool iscycle = graph.IsGraphHasCycle(node0);
             Console.WriteLine(iscycle);

        }

        private static void SetValueTest1(EdgeNode nodeS, EdgeNode nodeA, EdgeNode nodeB, EdgeNode nodeC, EdgeNode nodeD,
            EdgeNode nodeE)
        {
            nodeS.distance = 0;
            nodeS.visited = false;
            nodeS.color = Color.White;

            nodeA.distance = 0;
            nodeA.visited = false;
            nodeA.color = Color.White;

            nodeB.distance = 0;
            nodeB.visited = false;
            nodeB.color = Color.White;

            nodeC.distance = 0;
            nodeC.visited = false;
            nodeC.color = Color.White;

            nodeD.distance = 0;
            nodeD.visited = false;
            nodeD.color = Color.White;

            nodeE.distance = 0;
            nodeE.visited = false;
            nodeE.color = Color.White;
        }

        private static void SetValuesTest2(EdgeNode node1, EdgeNode node2, EdgeNode node3, EdgeNode node4, EdgeNode node5,
            EdgeNode node6)
        {
            node1.visited = false;
            node2.visited = false;
            node3.visited = false;
            node4.visited = false;
            node5.visited = false;
            node6.visited = false;

            node1.distance = 0;
            node2.distance = 0;
            node3.distance = 0;
            node4.distance = 0;
            node5.distance = 0;
            node6.distance = 0;
        }

        public static void Main(string[] args)
        {


            //Program.TestGraph1();
            //Program.TestGraph2();
            //Program.TestGraph3();
            //Program.TestGraph4();
            Program.TestGraph5();
        }

    }
}
