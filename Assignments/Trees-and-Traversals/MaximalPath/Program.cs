using System;
using System.Collections.Generic;

namespace MaximalPath
{
    class Program
    {
        static long maxSum = 0;
        static HashSet<Node> usedNodes = new HashSet<Node>();

        static void DFS(Node node, long currentSum)
        {
            currentSum += node.Value;
            usedNodes.Add(node);

            for (int i = 0; i < node.NumberOfChildren; i++)
            {
                if (usedNodes.Contains(node.GetChild(i)))
                {
                    continue;
                }

                DFS(node.GetChild(i), currentSum);
            }

            if (node.NumberOfChildren == 1 && currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            int maxNode = 0;

            for (int i = 0; i < n-1; i++)
            {
                string connection = Console.ReadLine();
                string[] separatedConnection = connection.Split(new char[] { '(', '<', '-', ')' }, StringSplitOptions.RemoveEmptyEntries);

                int parent = int.Parse(separatedConnection[0]);
                int child = int.Parse(separatedConnection[1]);

                Node parrentNode;
                Node childNode;

                if (nodes.ContainsKey(parent))
                {
                    parrentNode = nodes[parent];
                }
                else
                {
                    parrentNode = new Node(parent);
                    nodes.Add(parent, parrentNode);
                }

                if (nodes.ContainsKey(child))
                {
                    childNode = nodes[child];
                }
                else
                {
                    childNode = new Node(child);
                    nodes.Add(child, childNode);
                }

                parrentNode.AddChild(childNode);
                childNode.AddChild(parrentNode);

                if (parent > maxNode)
                {
                    maxNode = parent;
                }

                if (child > maxNode)
                {
                    maxNode = child;
                }
            }

            foreach (var node in nodes)
            {
                if (node.Value.NumberOfChildren == 1)
                {
                    usedNodes.Clear();
                    DFS(node.Value, 0);
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
