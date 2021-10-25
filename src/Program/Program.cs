using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Pablo = new Node(74, "Pablo");
            Node Esteban = new Node(56, "Estebitan");
            Node Sebastian = new Node(45, "Seba");
            Node Juan = new Node(32, "Juancito");
            Node Paula = new Node(30, "Paulita");
            Node Flavio = new Node(26, "Flavio");
            Node Matias = new Node(24, "Matias");

            Pablo.AddChildren(Esteban);
            Pablo.AddChildren(Sebastian);

            Esteban.AddChildren(Juan);
            Esteban.AddChildren(Paula);

            Sebastian.AddChildren(Flavio);
            Sebastian.AddChildren(Matias);

            // visitar el árbol aquí

            

            Person Ionas = new Person(19, "Ionas Josponis");
            Person Patricio = new Person(1, "Patricio Josponis");
            Person Patricia = new Person(5, "Patricia Josponis");


            Ionas.AddChildren(Patricia);
            Ionas.AddChildren(Patricio);
            



        }
    }
}
