using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(100);
            bst.Add(55);
            bst.Add(125);
            bst.Add(25);
            bst.Add(25);
            bst.Add(27);
            bool search27 = bst.Search(27);
            bool search53 = bst.Search(53);
        
            Console.ReadLine();

        }
    }
}
