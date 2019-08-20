using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BinarySearchTree
    {
        int data;

        node leftChild;
        node rightChild;


    }


    public void InsertAtEnd(int data)
    {
        // root is begining of tree 
        //key and value are pairs
        if (root == null)
        {
            
            return new node;

        }
        if (key < node ->key)
        {
            //if the number is less then the root node send it left
            //insert: i guess by looking at examples on line will need instrction
            node->leftChild = insert(node->leftChild, key);

        }
        else if (key-> node->)
        {
            //if the number is greater then the root sent it right 
            node->rightChild = insert(node->rightChild, key);
        }
        return node;

    }
}
