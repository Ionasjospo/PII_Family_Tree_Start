using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;

namespace Library
{
   public class Visitor
   {
        int sumaEdadTotal = 0; 
        

        List<int> listaCantidadLetras = new List<int> ();
        List<int> hijoMayorList = new List<int> ();
        

        
        public int totalEdad
        {
            get
            {
               return sumaEdadTotal; 
            }
        
            
        }

        public int hijoMayor
        {
            get
            {
                return hijoMayorList.Max();
            } 
        }

        public int nombreMasLargo
        {
            get
            {
                return listaCantidadLetras.Max();
            } 
        }

        public void Visit(Node node)
        {
            sumaEdadTotal += node.Person.edad;

            foreach (var item in node.Children)
            {
                item.Accept(this);
            }
            
        }

        public void VisitCantLetras (Node node)
        {
            foreach (var nombrePersona in node.Person.nombre)
            {
                int cantLetras = node.Person.nombre.Length();
                listaCantidadLetras.Append(cantLetras);
            }
            
            foreach (var item in node.Children)
            {
                item.Accept(this);
            }
            
        }

        public void VisitHijoMayor (Node node)
        {
            foreach (var nombrePersona in node.Person.edad)
            {
                int edadPersona = node.Person.edad();
                hijoMayorList.Append(edadPersona);
            }
            
            foreach (var item in node.Children)
            {
                item.Accept(this);
            }
            
        }
        
        
        
    }     

}