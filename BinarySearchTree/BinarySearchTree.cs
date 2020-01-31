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

        public bool Search(int data) // return bool? possibly whether exists
        {            
            if (root == null)
            {
                return false;
            }
            else
            {
                Node current = root;
                while (true)
                {
                    if (data <= current.data)
                    {
                        if (current.leftNode == null)
                        {
                            return false;
                        }
                        current = current.leftNode;
                    }
                    else if (data > current.data)
                    {
                        if (current.rightNode == null)
                        {
                            return false;
                        }
                        current = current.rightNode;                        
                    }
                    else
                    {                        
                        return true;
                    }
                }
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
                    if (data <= current.data)
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
