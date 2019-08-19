using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Node
    {
        int data;
        Node leftChild;
        Node rightChild;
        public Node(int data)
        {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }
        
        
    }
}
