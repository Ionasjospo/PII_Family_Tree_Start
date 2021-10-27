using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person persona;

        private List<Node> children = new List<Node>();

        public Person Person 
        {
            get
            {
                return this.persona;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int edad, string nombre, string apellido)
        {
            Person person = new Person(edad, nombre, apellido);
            this.persona = person;
            
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
