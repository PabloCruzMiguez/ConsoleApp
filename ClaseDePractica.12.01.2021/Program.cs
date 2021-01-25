using System;

namespace ClaseDePractica._12._01._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}

public class Persona
{
    public string Nombre;
    public string Apellido;

    public int Edad
    {
        get
        {
            return DevolverEdad();
        }
        set
        {
            int NuevaEdad = value;
        }
    }

    //*public int DevolverEdad()
    {

    }*//
    
    public class Alumno : Persona
{
    public string Carrera;

}
}