using System;
using System.IO;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class Node
    {
        public Node lchild;
        public int data;
        public Node rchild;
    }

    public class BSearch
    {
        public Node Root;
        public string path = @"C:\Users\skuma\OneDrive\Workspace\Educative\Educative\BinarySearchTree\Nodes.txt";

        public int[] GetNodeList(string path)
        {
            string nodeList = File.ReadAllText(path).ToString();
            string[] nodeLists = nodeList.Split(' ');
            int[] result = new int[nodeLists.Length];

            int i = 0;
            foreach (var item in nodeLists)
            {
                result[i] = int.Parse(item);
                i++;
            }

            return result;
        }

        public Node CreateTree()
        {
            int[] nodeLists = GetNodeList(path);
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
                        if (nodeLists[2 * i + 1] != -1)
                        {
                            var node = new Node();
                            node.data = nodeLists[2 * i + 1];
                            node.lchild = null;
                            node.rchild = null;
                            temp.lchild = node;
                            queue.Enqueue(node);
                        }

                        if (nodeLists[2 * i + 2] != -1)
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

        public Node SearchBTree(Node p, int k)
        {
            if (p == null) return null;
            else if (p.data == k) return p;
            else if (p.data < k)
            {
                 return SearchBTree(p.rchild, k);
            }
            else
                return SearchBTree(p.lchild, k);
        }

        public Node BTSearchIterative(Node p, int k)
        {
            while(p != null)
            {
                Node temp = p;
                if (p.data == k) return p;
                else if(p.data < k)
                {
                    if (p.rchild != null)
                        p = p.rchild;
                    else
                        p = null;
                }
                else
                {
                    if (p.lchild != null)
                        p = p.lchild;
                    else
                        p = null;
                }
            }
            return null;
        }

        public Node BTInsert(Node p , int value)
        {
            if(p == null)
            {
                Node t = new Node();
                t.data = value;
                t.rchild = null;
                t.lchild = null;
                return t;
            }

            if(p.data < value )
            {
                p.rchild = BTInsert(p.rchild, value);
            }
            else
            {
                p.lchild = BTInsert(p.lchild, value);
            }
            return p;
        }

        public Node BTInsertIterative(Node root, int value)
        {
            Node p = root;
            Node prev = null;
            while(p != null)
            {
                prev = p;
                if (p.data < value)
                {
                    p = p.rchild;
                }
                else
                    p = p.lchild;
            }

            if(p == null)
            {
                Node newNode = new Node();
                newNode.data = value;
                newNode.lchild = null;
                newNode.rchild = null;

                if (prev.data < value)
                {
                    prev.rchild = newNode;
                }
                else
                {
                    prev.lchild = newNode;
                }
            }

            return root;
        }

        public Node BTCreate(int[] nums)
        {
            var root = new Node();
            root.data = nums[0];
            root.lchild = null;
            root.rchild = null;

            Node prev = null;
            var temp = root;
            int i = 1;

            while(i < nums.Length)
            {
                var temp1 = new Node();
                temp1.data = nums[i];
                temp1.rchild = null;
                temp1.lchild = null;

                while(temp != null)
                {
                    prev = temp;
                    if(temp.data < nums[i])
                    {
                        temp = temp.rchild;
                    }
                    else
                    {
                        temp = temp.lchild;
                    }
                }

                if (prev.data < nums[i])
                {
                    prev.rchild = temp1;
                }
                else
                {
                    prev.lchild = temp1;
                }
                temp = root;
                i++;
            }
            return root;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BSearch();
            Node p = tree.CreateTree();

            Console.WriteLine("Search item in BT");
            var temp = tree.SearchBTree(p, 20);
            Console.WriteLine(temp.data);
            Console.WriteLine();

            Console.WriteLine("Search item in BT iterative");
            temp = tree.BTSearchIterative(p, 20);
            Console.WriteLine(temp.data);
            Console.WriteLine();

            Console.WriteLine("Insert node");
            temp = tree.BTInsert(p, 38);
            Console.WriteLine(temp.data);
            Console.WriteLine();

            Console.WriteLine("Insert node iteratively");
            temp = tree.BTInsertIterative(p, 45);
            Console.WriteLine(temp.data);
            Console.WriteLine();

            Console.WriteLine("BT Create");
            temp = tree.BTCreate(new int[] { 9, 15, 5, 20, 16, 8, 12, 3, 6 });
            Console.WriteLine(temp.data);
            Console.WriteLine();


            Console.WriteLine("Hello World!");
        }
    }
}
