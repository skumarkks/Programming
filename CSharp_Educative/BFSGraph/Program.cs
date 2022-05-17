using System;
using System.Collections.Generic;

public class Node
{
    public string Name;
    public List<Node> Children = new List<Node>();
    public Node(string name)
    {
        Name = name;
    }

    public Node AddNode(string name)
    {
        var child = new Node(name);
        Children.Add(child);
        return this;
    }

    public List<string> BreadthFirstSearch(List<string> array)
    {
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(this);
        while (queue.Count != 0)
        {
            Node current = queue.Dequeue();
            array.Add(current.Name);
            current.Children.ForEach(ch => queue.Enqueue(ch));
        }

        return array;
    }

    public List<string> DepthFirstSearch(List<string> array)
    {
        array.Add(this.Name);

        for (int i = 0; i < Children.Count; i++)
        {
            Children[i].DepthFirstSearch(array);
        }

        return array;
    }

}
public class Program
{
    static void Main()
    {
        var graph = new Node("A");
        graph.AddNode("B").AddNode("C").AddNode("D");

        graph.Children[0].AddNode("E").AddNode("F");
        graph.Children[2].AddNode("G").AddNode("H");

        graph.Children[0].Children[1].AddNode("I").AddNode("J");
        graph.Children[2].Children[0].AddNode("K");

        List<string> array = new List<string>();

        var result = graph.BreadthFirstSearch(array);

        result.ForEach(ch => Console.Write("{0} ", ch));

        result.Clear();
        Console.WriteLine();
        result = graph.DepthFirstSearch(array);
        result.ForEach(ch => Console.Write("{0} ", ch));

    }
}