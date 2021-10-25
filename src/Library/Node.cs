using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        private List<Persona> people = new List<Persona>();
        private List<Node> children = new List<Node>();

        public Persona Person {get;}
        public int Number 
        {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Persona> People 
        { 
            get
            {
                return this.people.AsReadOnly();
            }
        }
        public ReadOnlyCollection<Node> Children 
            { 
                get
                {
                    return this.children.AsReadOnly();
                }
            }
        
        public Node(int number, Persona persona)
        {
            this.number = number;
            this.Person = persona;
        }
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
            
        public void AddChildren(Node n)
        {
            this.children.Add(n);
            this.people.Add(n.Person);
        }
        
    }
}
