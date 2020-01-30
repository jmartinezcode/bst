using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public Node Search(int data, Node node) // return bool? possibly whether exists
        {
            if (node == null || node.data == data)
            {
                return node;
            }
            if (data < node.data )
            {
                return Search(data, node.leftNode);
            }
            else
            {
                return Search(data, node.rightNode);
            }
        }

        public void Add(int data)
        {
            Node node = new Node();
            node.data = data;
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.leftNode;
                        if (current == null)
                        {
                            parent.leftNode = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightNode;
                        if (current == null)
                        {
                            parent.rightNode = node;
                            break;
                        }
                    }
                }            
            }
        }
    }
}
