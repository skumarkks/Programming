using System;
using System.Collections.Generic;
using System.IO;

namespace TreeConstruction
{
    public class Node
    {
        public Node lchild;
        public string data;
        public Node rchild;
    }

    public class Tree
    {
        public Node Root;
        public string path = @"C:\Users\skuma\OneDrive\Workspace\Educative\Educative\TreeConstruction\Nodes.txt";

        public string[] GetNodeList(string path)
        {
            string nodeList = File.ReadAllText(path).ToString();
            string[] nodeLists = nodeList.Split(' ');

            return nodeLists;
        }

        public Node CreateTree()
        {
            string[] nodeLists = GetNodeList(path);
            int i = 0;

            while (i < nodeLists.Length)
            {
                var root = new Node();
                root.data = nodeLists[i];
                root.lchild = null;
                root.rchild = null;

                var queue = new Queue<Node>();
                queue.Enqueue(root);
                Root = root;

                while (queue.Count != 0)
                {
                    var temp = queue.Dequeue();

                    if (2 * i + 1 < nodeLists.Length || 2 * i + 2 < nodeLists.Length)
                    {
                        if (nodeLists[2 * i + 1] != "-1")
                        {
                            var node = new Node();
                            node.data = nodeLists[2 * i + 1];
                            node.lchild = null;
                            node.rchild = null;
                            temp.lchild = node;
                            queue.Enqueue(node);
                        }

                        if (nodeLists[2 * i + 2] != "-1")
                        {
                            var node = new Node();
                            node.data = nodeLists[2 * i + 2];
                            node.lchild = null;
                            node.rchild = null;
                            temp.rchild = node;
                            queue.Enqueue(node);
                        }
                    }
                    i++;

                }
            }
            return Root;

        }

        public void PreOrder(Node p)
        {
            if (p != null)
            {
                Console.Write(p.data);
                PreOrder(p.lchild);
                PreOrder(p.rchild);
            }
        }

        public void PreOrderIterative(Node p)
        {
            var stack = new Stack<Node>();

            while (p != null || stack.Count != 0)
            {
                if (p != null)
                {
                    Console.Write(p.data);
                    stack.Push(p);
                    p = p.lchild;
                }
                else
                {
                    p = stack.Pop();
                    p = p.rchild;
                }
            }
        }

        public void InOrder(Node p)
        {
            if (p != null)
            {
                InOrder(p.lchild);
                Console.Write(p.data);
                InOrder(p.rchild);
            }
        }

        public IList<string> listInOrder = new List<string>();
        public IList<string> InOrderReturn(Node p)
        {
            if (p == null) return listInOrder;
            if (p != null)
            {
                InOrderReturn(p.lchild);
                listInOrder.Add(p.data);
                InOrderReturn(p.rchild);
            }
            return listInOrder;
        }

        public void InOrderIterative(Node p)
        {
            var stack = new Stack<Node>();

            while (p != null || stack.Count != 0)
            {
                if (p != null)
                {
                    stack.Push(p);
                    p = p.lchild;
                }
                else
                {
                    p = stack.Pop();
                    Console.Write(p.data);
                    p = p.rchild;
                }
            }
        }



        public void PostOrder(Node p)
        {
            if (p != null)
            {
                PostOrder(p.lchild);
                PostOrder(p.rchild);
                Console.Write(p.data);
            }
        }

        public void PostOrderIterative(Node p)
        {
            var stack = new Stack<Node>();

            while (p != null || stack.Count != 0)
            {
                if (p != null)
                {
                    stack.Push(p);
                    p = p.lchild;
                }
                else
                {
                    p = stack.Pop();

                    if (!p.data.Contains("-"))
                    {
                        p.data = p.data + "-";
                        stack.Push(p);
                        p = p.rchild;
                    }
                    else
                    {
                        p.data = p.data.Remove(1);
                        Console.Write(p.data);
                        p = null;
                    }

                }
            }
        }

        public void LevelOrderTraversal(Node p)
        {
            var queue = new Queue<Node>();

            Console.Write(p.data);
            queue.Enqueue(p);

            while (queue.Count != 0)
            {
                p = queue.Dequeue();

                if (p.lchild != null)
                {
                    Console.Write(p.lchild.data);
                    queue.Enqueue(p.lchild);
                }

                if (p.rchild != null)
                {
                    Console.Write(p.rchild.data);
                    queue.Enqueue(p.rchild);
                }
            }
        }

        public void LevelReverseOrderTraversal(Node p)
        {
            var queue = new Queue<Node>();

            Console.Write(p.data);
            queue.Enqueue(p);
            while (queue.Count != 0)
            {
                var temp = queue.Dequeue();
                if (temp != null)
                {
                    if (temp.rchild != null)
                    {
                        queue.Enqueue(temp.rchild);
                        Console.Write(temp.rchild.data);
                    }
                    if (temp.lchild != null)
                    {
                        queue.Enqueue(temp.lchild);
                        Console.Write(temp.lchild.data);
                    }
                }
            }
        }

        public void ReverseLevelOrderTraversal(Node p)
        {
            var queue = new Queue<Node>();
            var stack = new Stack<Node>();

            queue.Enqueue(p);

            while(queue.Count != 0)
            {
                Node temp = queue.Dequeue();
                stack.Push(temp);

                if(temp.rchild != null)
                {
                    queue.Enqueue(temp.rchild);
                }
                if(temp.lchild != null)
                {
                    queue.Enqueue(temp.lchild);
                }
            }
            while(stack.Count != 0)
            {
                Node temp = stack.Pop();
                Console.Write("{0} ", temp.data);
            }
        }
        // Constructing a tree from the preorder and inorder
        public Node BuildTree(char[] inorder, char[] preorder, int start, int end, int preorderIndex)
        {
            if (start > end) return null;

            Node tNode = new Node();
            tNode.data = preorder[preorderIndex++].ToString();

            if (start == end) return tNode;

            int index = Search(inorder, start, end, tNode.data);

            tNode.lchild = BuildTree(inorder, preorder, start, index, preorderIndex);
            tNode.rchild = BuildTree(inorder, preorder, index + 1, end, preorderIndex);

            return tNode;

        }

        private int Search(char[] inorder, int start, int end, string data)
        {
            while (start < end)
            {
                if (inorder[start].ToString() == data)
                {
                    return start;
                }
                else
                {
                    start++;
                }
            }
            return -1;
        }

        public int Height(Node p)
        {
            int x, y;
            if (p != null)
            {
                x = Height(p.lchild);
                y = Height(p.rchild);

                if (x > y)
                    return x + 1;
                else
                    return y + 1;
            }
            return 0;
        }

        public void PrintNodesByLevel(Node p)
        {

            if (p == null) return;

            var queue = new Queue<Node>();
            queue.Enqueue(p);
            queue.Enqueue(null);

            Node pPrev = null;

            while (true)
            {
                var temp = queue.Dequeue();
                if (temp != null)
                {
                    Console.Write(temp.data);
                }

                if (temp == null && pPrev == null)
                {
                    break;
                }
                else if (temp == null)
                {
                    Node x = null;
                    Console.WriteLine();
                    queue.Enqueue(x);
                    pPrev = temp;
                    continue;
                }

                pPrev = temp;

                queue.Enqueue(temp.lchild);
                queue.Enqueue(temp.rchild);
            }

        }

        public int countLeftNodes(Node p)
        {
            int x = 0, y = 0;
            if (p != null)
            {
                x = countLeftNodes(p.lchild);
                y = countLeftNodes(p.rchild);

                if (p.lchild == null && p.rchild == null)
                {
                    return x + y + 1;
                }
                else
                {
                    return x + y;
                }
            }
            return 0;
        }

        public int countInternalNodes(Node p)
        {
            int x, y;

            if (p != null)
            {
                x = countInternalNodes(p.lchild);
                y = countInternalNodes(p.rchild);

                if (p.lchild != null && p.rchild != null)
                {
                    return x + y + 1;
                }
                else
                {
                    return x + y;
                }
            }
            return 0;
        }

        public void SpiralTraversal(Node p)
        {
            var stack1 = new Stack<Node>();
            var stack2 = new Stack<Node>();

            stack1.Push(p);

            while (stack1.Count != 0 || stack2.Count != 0)
            {
                while (stack1.Count != 0)
                {
                    Node temp = stack1.Pop();
                    Console.Write("{0} ", temp.data);
                    if (temp.rchild != null)
                        stack2.Push(temp.rchild);
                    if (temp.lchild != null)
                        stack2.Push(temp.lchild);
                }
                while (stack2.Count != 0)
                {
                    Node temp = stack2.Pop();
                    Console.Write("{0} ", temp.data);
                    if (temp.lchild != null)
                        stack1.Push(temp.lchild);
                    if (temp.rchild != null)
                        stack1.Push(temp.rchild);
                }
            }
        }

        public void PrintTree(Node p)
        {
            var queue = new Queue<Node>();
            if(p != null)
            {
                queue.Enqueue(p);
            }

            var q = queue.Dequeue();
            Console.Write("{0} ", q.data);
            queue.Enqueue(p.lchild);
            queue.Enqueue(p.rchild);

            while(queue.Count != 0)
            {
                var temp1 = queue.Dequeue();
                var temp2 = queue.Dequeue();
                Console.Write("{0} ", temp1.data);
                Console.Write("{0} ", temp2.data);
                queue.Enqueue(temp1.lchild);
                queue.Enqueue(temp2.rchild);
                queue.Enqueue(temp1.rchild);
                queue.Enqueue(temp2.lchild);
            }
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            Node result = tree.CreateTree();

            Console.WriteLine("Inorder");
            tree.InOrder(result);
            Console.WriteLine();
            tree.InOrderIterative(result);
            Console.WriteLine();

            Console.WriteLine("PreOrder");
            tree.PreOrder(result);
            Console.WriteLine();
            tree.PreOrderIterative(result);
            Console.WriteLine();

            Console.WriteLine("PostOrder");
            tree.PostOrder(result);
            Console.WriteLine();
            //tree.PostOrderIterative(result);
            Console.WriteLine();

            Console.WriteLine("Level Order");
            tree.LevelOrderTraversal(result);
            Console.WriteLine();

            Console.WriteLine("Level reverse Order");
            tree.LevelReverseOrderTraversal(result);
            Console.WriteLine();

            Console.WriteLine("Reverse Level Order Traversal");
            tree.ReverseLevelOrderTraversal(result);
            Console.WriteLine();

            Console.WriteLine("Height of the tree");
            int height = tree.Height(result);
            Console.WriteLine(height);
            Console.WriteLine();

            Console.WriteLine("Print Nodes By Level");
            tree.PrintNodesByLevel(result);
            Console.WriteLine();

            Console.WriteLine("Count Leaf nodes");
            int leafCount = tree.countLeftNodes(result);
            Console.WriteLine(leafCount);

            Console.WriteLine("Count Internal nodes");
            int internalCount = tree.countLeftNodes(result);
            Console.WriteLine(leafCount);

            Console.WriteLine("Sprial Tree traversal");
            tree.SpiralTraversal(result);
            Console.WriteLine();


            Console.WriteLine("Print Tree traversal");
            tree.PrintTree(result);
            Console.WriteLine();

        }
    }
}


