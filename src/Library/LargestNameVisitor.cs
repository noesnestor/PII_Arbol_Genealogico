using System.Text;
using System;

namespace Library
{
    public class LargestNameVisitor : Visitor
    {
        public int MaxValue {get; private set;}

        public string Ganador {get; private set;}
        public override void Visit (Node node)
        {
            this.ContentBuilder.Clear();
            string nombreACheckear = node.Person.Nombre.Replace(" ",String.Empty);
                if(nombreACheckear.Length >= MaxValue)
                {
                    MaxValue = nombreACheckear.Length;
                    Ganador = node.Person.Nombre;
                }
            foreach (Node nodo in node.Children)
            {
                nodo.Accept(this);
            }
            if(this.ContentBuilder.Length == 0)
            {
            this.ContentBuilder.Append($"El familiar con el nombre más largo es {Ganador}, con {MaxValue} letras.");
            }
            
        }  
    }
}