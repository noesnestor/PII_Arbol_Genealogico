using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeVisitor visitanteEdad = new AgeVisitor();
            LargestNameVisitor visitanteNombreLargo = new LargestNameVisitor();
            OldestChildVisitor visitanteHijoMayor = new OldestChildVisitor();
            
            Persona persona0 = new Persona("María Lucía",12);
            Persona persona1 = new Persona("Nestor",19);
            Persona persona2 = new Persona("Fernando",50);
            Persona persona3 = new Persona("Eleonor",50);
            Persona persona4 = new Persona("Jacqueline",60);
            Persona persona5 = new Persona("Gabriela",60);
            Persona persona6 = new Persona("Eloy",80);
            Persona persona7 = new Persona("Graciela",80);
            Persona persona8 = new Persona("Lola",90);
            Persona persona9 = new Persona("Mario",90);

            Node n0 = new Node(0,persona0);
            Node n1 = new Node(1,persona1);
            Node n2 = new Node(2,persona2);
            Node n3 = new Node(3,persona3);
            Node n4 = new Node(4,persona4);
            Node n5 = new Node(5,persona5);
            Node n6 = new Node(6,persona6);
            Node n7 = new Node(7,persona7);
            Node n8 = new Node(8,persona8);
            Node n9 = new Node(9,persona9);

            n9.AddChildren(n2);
            n9.AddChildren(n4);

            n8.AddChildren(n2);
            n8.AddChildren(n4);

            n7.AddChildren(n3);
            n7.AddChildren(n5);

            n6.AddChildren(n3);
            n6.AddChildren(n5);

            n3.AddChildren(n1);
            n3.AddChildren(n0);

            n2.AddChildren(n1);
            n2.AddChildren(n0);

            // visitar el árbol aquí

            //Se suman las edades de: Mario(90), Fernando(50), Jacqueline(60), 
            // María Lucía(12) y Néstor(19). Esto equivale a:  90+60+50+12+19 = 231 
            visitanteEdad.Visit(n9);
            Console.WriteLine(visitanteEdad.Content);

            //Checkeando entre Néstor y María Lucía quién es el hijo más grande.
            visitanteHijoMayor.Visit(n2);
            Console.WriteLine(visitanteHijoMayor.Content);

            /*Checkear la familia desde el inicio del arbol me otorga un resultado.*/
            visitanteNombreLargo.Visit(n9);
            Console.WriteLine(visitanteNombreLargo.Content);

            /*Que es distinto si checkeo otra zona más cercana al final.*/
            visitanteNombreLargo.Visit(n3);
            Console.WriteLine(visitanteNombreLargo.Content);
        }
    }
}
