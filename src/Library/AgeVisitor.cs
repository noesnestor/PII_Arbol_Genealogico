using System.Text;
using System;

namespace Library
{
    public class AgeVisitor : Visitor
    {
        public int SumaTotal {get; private set;}
        public override void Visit (Node node)
        {
            this.ContentBuilder.Clear();
            int EdadASumar = node.Person.Edad;
            this.SumaTotal += EdadASumar;
            foreach (Node nodo in node.Children)
            {
                nodo.Accept(this);
            }
            if(!this.ContentBuilder.ToString().Contains("La suma de las edades de la familia es:"))
            {
            this.ContentBuilder.Append($"La suma de las edades de la familia es: {SumaTotal} años.");
            }
        }  
    }
}