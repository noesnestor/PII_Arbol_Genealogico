namespace Library
{
    public class Persona
    {
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
    }
}