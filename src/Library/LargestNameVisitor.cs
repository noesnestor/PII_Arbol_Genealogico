using System.Text;
using System;

namespace Library
{
    public class LargestNameVisitor : Visitor
    {
        public override void Visit (Node node)
        {
            this.ContentBuilder.Clear();
            int maxValue = 0;
            string ganador = "";
            foreach (Persona persona in node.People)
            {
                string nombreACheckear = persona.Nombre.Replace(" ",String.Empty);
                if(nombreACheckear.Length >= maxValue)
                {
                    maxValue = nombreACheckear.Length;
                    ganador = persona.Nombre;
                }
            }
            this.ContentBuilder.Append($"El hijo con el nombre más largo es {ganador}, con {maxValue} letras.");
        }  
    }
}