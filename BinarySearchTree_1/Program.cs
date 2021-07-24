using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BinarySearchTree_1
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;
        public BST parent;

        public BST(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
            this.parent = null;
        }

        //Average time complexity O(logn) and Average space complexity o(logn) 
        //Worst case time complextity o(n) and Wost case space complexity O(n)
        public void Insert(int value)
        {
            if(value >= this.value)
            {
                if(this.right != null)
                {
                    right.Insert(value);
                }
                else
                {
                    var node = new BST(value);
                    this.right = node;
                    node.parent = this;
                }
            }
            else if(value < this.value)
            {
                if(this.left != null)
                {
                    left.Insert(value);
                }
                else
                {
                    var node = new BST(value);
                    this.left = node;
                    node.parent = this;
                }
            }
        }
        //Average time complexity O(logn) and Average space complexity o(1) 
        //Worst case time complextity o(n) and Wost case space complexity O(1)
        public BST Maximum()
        {
            BST current = this;
            while (current != null)
            {
                if (current.right != null)
                {
                    current = current.right;
                }
                else
                {
                    return current;
                }
            }

            return null;
        }

        //Average time complexity O(logn) and Average space complexity o(1) 
        //Worst case time complextity o(n) and Wost case space complexity O(1)
        public BST Minimum()
        {
            BST current = this;
            while(current != null)
            {
                if(current.left != null)
                {
                    current = current.left;
                }
                else
                {
                    return current;
                }
            }
            
            return null;
        }

        //Average time complexity O(logn) and Average space complexity o(logn) 
        //Worst case time complexity o(n) and Wost case space complexity O(n)
        public BST Search(int value)
        {
            if(value < this.value)
            {
                if(this.left != null)
                {
                    return left.Search(value);
                }               
            }
            else if (value > this.value)
            {
                if(this.right != null)
                {
                    return right.Search(value);
                }
            }
            else if(value == this.value)
            {
                return this;
            }
            return null;
        }

        public static void PreOrderTraversal(BST node, List<int> nodes)
        {
            if (node != null)
            {
                nodes.Add(node.value);
            }
            if (node!= null && node.left != null) PreOrderTraversal(node.left, nodes);
            if (node!= null && node.right != null) PreOrderTraversal(node.right, nodes);
        }

        public static void InOrderTraversal(BST node, List<int> nodes)
        {
            if(node != null &&  node.left != null) InOrderTraversal(node.left, nodes);
            if (node != null)
            {
                nodes.Add(node.value);
            }
            if(node!= null && node.right != null) InOrderTraversal(node.right, nodes);
        }

        public static void PostOrderTraversal(BST node, List<int> nodes)
        {
            if(node != null && node.left != null) PostOrderTraversal(node.left, nodes);
            if(node != null && node.right != null) PostOrderTraversal(node.right, nodes);
            if(node != null)
            {
                nodes.Add(node.value);
            }
        }

        public static BST Successor(BST node)
        {
            if (node != null && node.right != null)
            {
                return node.right.Minimum();
            }

            BST yNode = node.parent;
            BST xNode = node;
            while (yNode != null && yNode.right != null && yNode.right == xNode)
            {
                xNode = yNode;
                yNode = xNode.parent;
            }

            return yNode;
        }

        public static BST Predecessor(BST node)
        {
            if (node != null && node.left != null)
            {
                return node.left.Maximum();
            }

            BST yNode = node.parent;
            BST xNode = node;
            while (yNode != null && yNode.left != null && yNode.left == xNode)
            {
                xNode = yNode;
                yNode = xNode.parent;
            }

            return yNode;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int value = 15;
            var root = new BST(value);
            root.Insert(6);
            root.Insert(18);
            root.Insert(3);
            root.Insert(7);
            root.Insert(2);
            root.Insert(4);
            root.Insert(17);
            root.Insert(20);
            root.Insert(13);
            root.Insert(9);
            //root.Insert(5);

            BST maximum = root.Maximum();
            Console.WriteLine("Maximum : {0}\n", maximum.value);

            BST minimum = root.Minimum();
            Console.WriteLine("Minimum : {0}\n", minimum.value);

            value = 17;
            BST find = root.Search(value);
            Console.WriteLine("Find Value : {0}\n", find?.value ?? 0);

            List<int> result = new List<int>();
            BST.PreOrderTraversal(root, result);
            foreach (var res in result)
            {
                Console.Write("{0} ", res);
            }
            result.Clear();
            Console.WriteLine("\n");

            BST.InOrderTraversal(root, result);
            foreach (var res in result)
            {
                Console.Write("{0} ", res);
            }
            result.Clear();
            Console.WriteLine("\n");

            BST.PostOrderTraversal(root, result);
            foreach (var res in result)
            {
                Console.Write("{0} ", res);
            }
            result.Clear();
            Console.WriteLine("\n");

            BST node = root.Search(18);
            BST successor = BST.Successor(node);
            Console.WriteLine("Successor of {0} is {1}", node.value, successor.value);

            node = root.Search(13);
            successor = BST.Successor(node);
            Console.WriteLine("Successor of {0} is {1}", node.value, successor.value);

            node = root.Search(13);
            successor = BST.Predecessor(node);
            Console.WriteLine("Predecessor of {0} is {1}", node.value, successor.value);

            node = root.Search(9);
            successor = BST.Predecessor(node);
            Console.WriteLine("Predecessor of {0} is {1}", node.value, successor.value);



            Console.ReadLine();
        }
    }
}
