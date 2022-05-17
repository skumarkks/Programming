using System;

namespace TargetSum
{
    public class Node
    {
        public int data;
        public Node lchild;
        public Node rchild;

        public Node(int val)
        {
            this.data = val;
            this.lchild = null;
            this.rchild = null;
        }
    }

    public class TreeSum
    {
        public bool HasPath(Node p, int targetSum)
        {
            if (p == null) return false;

            if (p.data == targetSum && p.lchild == null && p.rchild == null) return true;

            bool blpath = HasPath(p.lchild, targetSum - p.data);
            bool brpath = HasPath(p.rchild, targetSum - p.data);

            return blpath || brpath;
        }


        
    }

    public class Test
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            Node p2 = root.lchild = new Node(2);
            Node p3 = root.rchild = new Node(3);
            Node p4 = p2.lchild = new Node(4);
            Node p5 = p2.rchild = new Node(5);
            Node p6 = p3.lchild = new Node(6);
            Node p7 = p3.rchild = new Node(7);

            var test = new TreeSum();
    
            bool isPath = test.HasPath(root, 8);

            if (isPath == true)
                Console.WriteLine("SUC");

            isPath = test.HasPath(root, 10);
            if (isPath == true)
                Console.WriteLine("SUC");

            isPath = test.HasPath(root, 12);
            if (isPath == false)
                Console.WriteLine("DIF");

        }
    }

}
