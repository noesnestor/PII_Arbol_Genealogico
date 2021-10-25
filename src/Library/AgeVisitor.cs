using System.Text;
using System;

namespace Library
{
    public class AgeVisitor : Visitor
    {
        public override void Visit (Node node)
        {
            this.ContentBuilder.Clear();
            int sumaEdad = 0;
            foreach (Persona persona in node.People)
            {
                sumaEdad += persona.Edad;
                Console.WriteLine($"He sumado la edad de {persona.Nombre}");
            }
            this.ContentBuilder.Append($"La suma de las edades de los hijos es: {sumaEdad}");
        }  
    }
}