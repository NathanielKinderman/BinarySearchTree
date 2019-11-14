using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BinarySearchTree
    {
        Node root;
        Node parentNode;
        Node currentNode;

        public BinarySearchTree()
        {

            root = null;
        }
        public void InsertAtEnd(int newNode)
        {
            // root is begining of tree 
            // key and value are pairs
            Node nodeToAdd= new Node(newNode);
            nodeToAdd.data = newNode;

            if (root == null)
            {

                root = nodeToAdd;
                return;
            }
            else
            {
                currentNode = root;
                while (true)
                {
                    parentNode = currentNode;
                    if(newNode<= currentNode.data)
                    {
                        currentNode = currentNode.leftChild;
                        if(currentNode == null)
                        {
                            parentNode.leftChild = nodeToAdd;
                            return;

                        }

                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                        if(currentNode == null)
                        {
                            parentNode.rightChild = nodeToAdd;
                            return;
                        }

                    }


                }

            }          
           
            
        }
        public bool Searching(int numberToSearch)
        {
            if (root == null)
            {
                Console.WriteLine("Sorry there is no Number with that value.");
                Console.ReadLine();
                return false;

            }
            currentNode = root;
            if(currentNode.data == numberToSearch)
            {
                Console.WriteLine(" This number was found in the Tree.");
                Console.ReadLine();
                return true;

            }
            while (true)
            {
                parentNode = currentNode;
                if(numberToSearch < parentNode.data)
                {
                    currentNode = parentNode.leftChild;
                    if(currentNode == null)
                    {
                        Console.WriteLine("No number with that value is found.");
                        Console.ReadLine();
                        return false;

                    }
                    else if(numberToSearch == currentNode.data)
                    {
                        Console.WriteLine("That number was found in the tree.");
                        Console.ReadLine();
                        return true;

                    }

                }
                else
                {
                    currentNode = parentNode.rightChild;
                    if(currentNode== null)
                    {
                        Console.WriteLine("No number with that value is found.");
                        Console.ReadLine();
                        return false;

                    }
                    else if(numberToSearch == currentNode.data)
                    {
                        Console.WriteLine("That number was found in the tree.");
                        Console.ReadLine();
                        return true;

                    }
                }
            }


        }

  
    }
}
