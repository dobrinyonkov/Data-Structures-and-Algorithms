using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalPath
{
    public class Node
    {
        private int value;
        private bool hasParent;
        private List<Node> children;

        public Node(int value)
        {
            this.value = value;
            this.children = new List<Node>();
        }

        public int NumberOfChildren
        {
            get
            {
                return this.children.Count;
            }
        }

        public int Value
        {
            get
            {
                return this.value;
            }
        }

        public void AddChild(Node child)
        {
            child.hasParent = true;
            children.Add(child);
        }

        public Node GetChild(int index)
        {
            return this.children[index];
        }
    }
}
