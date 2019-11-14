using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
      static void Main(string[] args)
      {
            BinarySearchTree bts = new BinarySearchTree();
            bts.InsertAtEnd(100);
            bts.InsertAtEnd(69);
            bts.InsertAtEnd(150);
            //bts.InsertAtEnd(50);
            //bts.InsertAtEnd(109);
            //bts.InsertAtEnd(90);
            bts.Searching(10);
            bts.Searching(69);

      }
        
    }
}
