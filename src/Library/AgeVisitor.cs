using System.Text;
using System;

namespace Library
{
    public class AgeVisitor : Visitor
    {
        public override void Visit (Node node)
        {
            this.ContentBuilder.Clear();
            int sumaEdad = node.Person.Edad;
            Console.WriteLine($"El Padre de la familia {node.Person.Nombre}, tiene {node.Person.Edad} años.");
            foreach (Persona persona in node.People)
            {
                sumaEdad += persona.Edad;
                Console.WriteLine($"He sumado la edad de {persona.Nombre}, este tiene {persona.Edad} años.");
            }
            this.ContentBuilder.Append($"La suma de las edades de la familia es: {sumaEdad} años.");
        }  
    }
}