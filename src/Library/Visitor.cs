using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
   public class Visitor
   {
        int sumaTotal = 0; 
        public int totalEdad
        {
            get
            {
               return sumaTotal; 
            }
        
            
        }

        public void Visit(Node node)
        {
            sumaTotal += node.Person.edad;
            foreach (var item in node.Children)
            {
                item.Accept(this);
            }
            
        }
    }     

}