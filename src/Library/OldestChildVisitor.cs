using System.Text;
using System;

namespace Library
{
    public class OldestChildVisitor : Visitor
    {
        public int MaxValue {get; private set;}

        /*Para no contar al nodo padre cuando entra (que generalmente va a ser el más grande),
        utilizo un contador*/
        public int Contador {get; private set;}
        public string Ganador {get; private set;}
        public override void Visit (Node node)
        {
            this.ContentBuilder.Clear();
            if(node.Person.Edad >= MaxValue && Contador != 0)
                {
                    MaxValue = node.Person.Edad;
                    Ganador = node.Person.Nombre;
                }
            Contador++;
            //Ahora ignora el nodo padre y cuenta los hijos.
            foreach (Node nodo in node.Children)
            {
                nodo.Accept(this);
            }
            if(this.ContentBuilder.Length == 0)
            {
            this.ContentBuilder.Append($"El familiar más grande es {Ganador}, con {MaxValue} años.");
            }
        }  
    }
}