using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Pablo = new Node(74, "Pablo", "Gonzales" );
            Node Esteban = new Node(56, "Estebán", "Gonzales");
            Node Sebastian = new Node(45, "Seba", "Gonzales");
            Node Juan = new Node(32, "Juan", "Gonzales");
            Node Paulo = new Node(30, "Paula", "Gonzales");
            Node Flavio = new Node(26, "Flavio", "Gonzales");
            Node Matias = new Node(24, "Matias", "Gonzales");

            Pablo.AddChildren(Esteban);
            Pablo.AddChildren(Sebastian);

            Esteban.AddChildren(Juan);
            Esteban.AddChildren(Paulo);

            Sebastian.AddChildren(Flavio);
            Sebastian.AddChildren(Matias);

            // visitar el árbol aquí

            

            Node Ionas = new Node(67, "Ionas", "Josponis");
            Node Patricio = new Node(40, "Patricio", "Josponis");
            Node Paul = new Node(40, "Paul", "Josponis");
            Node Pedro = new Node(5, "Pedro", "Josponis");
            Node Pancracio = new Node(3, "Pancracio", "Josponis");
            Node Pep = new Node(1, "Pep", "Josponis");
            Node Jaime = new Node(12, "Jaime", "Josponis");
            Node Juanjo = new Node(10, "Juan", "Josponis");
            
            
            Ionas.AddChildren(Patricio);
            Ionas.AddChildren(Paul);
            
            Patricio.AddChildren(Pedro);
            Patricio.AddChildren(Pancracio);
            Patricio.AddChildren(Pep);

            Paul.AddChildren(Juan);
            Paul.AddChildren(Juanjo);

            Visitor visitor = new Visitor();
            visitor.Visit(Ionas); 

            Visitor visitor2 = new Visitor();
            visitor2.VisitCantLetras(Ionas); 

            Visitor visitor3 = new Visitor();
            visitor3.VisitHijoMayor(Ionas); 

            Console.WriteLine(visitor.totalEdad);
            Console.WriteLine(visitor.nombreMasLargo);

        }
    }
}
