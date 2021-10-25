using System.Text;
using System;

namespace Library
{
    public class OldestChildVisitor : Visitor
    {
        public override void Visit (Node node)
        {
            this.ContentBuilder.Clear();
            int maxValue = 0;
            string ganador = "";
            foreach (Persona persona in node.People)
            {
                if(persona.Edad >= maxValue)
                {
                    maxValue = persona.Edad;
                    ganador = persona.Nombre;
                }
            }
            this.ContentBuilder.Append($"El hijo más grande es {ganador}, con {maxValue} años.");
        }  
    }
}