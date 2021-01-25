using System;

Persona persona1 = new Persona();
persona1.Nombre = "Lorenzo";
persona1.Apellido = "Stark";
// persona1.Edad = 20;
Console.WriteLine("Nombre: {0} - Apellido: {1} - Edad: {2}", persona1.Nombre, persona1.Apellido, persona1.Edad);

Persona persona2 = new Persona();
persona2.Nombre = "Tony";
persona2.Apellido = "Stark";
// persona2.Edad = 50;
Console.WriteLine("Nombre: {0} - Apellido: {1} - Edad: {2}", persona2.Nombre, persona2.Apellido, persona2.Edad);

Persona persona3 = new Persona();
Console.WriteLine("Nombre: {0} - Apellido: {1} - Edad: {2}", persona3.Nombre, persona3.Apellido, persona3.Edad);

Persona persona4 = new Persona("Sara", "Connor", 46);
Console.WriteLine("Nombre: {0} - Apellido: {1} - Edad: {2}", persona4.Nombre, persona4.Apellido, persona4.Edad);

Persona persona5 = new Persona("Martin", "Cardagian");
Console.WriteLine("Nombre: {0} - Apellido: {1} - Edad: {2}", persona5.Nombre, persona5.Apellido.ToUpper().Substring(0, 3), persona5.Edad);

Persona persona6 = new Persona("Martin", "Cardagian", new DateTime(1991, 11, 23, 4, 35, 00));
Console.WriteLine("Nombre: {0} - Apellido: {1} - Nacimiento: {3} - Edad: {2}", persona6.Nombre, persona6.Apellido, persona6.Edad, persona6.FechaNacimiento.ToShortDateString());
persona6.FechaNacimiento = new DateTime(1981, 11, 23, 4, 35, 00);
// Console.WriteLine("Nueva edad segun metodo: {0} - Segun propiedad: {1}", persona6.DevolverEdad(), persona6.Edad);
// Console.WriteLine("Nueva edad segun propiedad: {0} - Segun metodo: {1} -- {2}", persona6.Edad, persona6.DevolverEdad(), persona6.Edad);
try
{
    persona6.FechaNacimiento = new DateTime(1789, 11, 23, 4, 35, 00);
}
catch (System.Exception error)
{
    Console.WriteLine(error.Message);
}


Alumno alumno1 = new Alumno("Peter", "Parker", new DateTime(2001, 11, 15), "Sistemas");
Console.WriteLine("Alumno: Nombre: {0} - Apellido: {1} - Nacimiento: {3} - Edad: {2} - Carrera: {4}", alumno1.Nombre, alumno1.Apellido, alumno1.Edad, alumno1.FechaNacimiento.ToShortDateString(), alumno1.Carrera);

Alumno alumno2 = new Alumno("Peter", "Parker", new DateTime(2001, 11, 15));
alumno2.InscribirEnCarrera("Contador Publico");
Console.WriteLine("Alumno: Nombre: {0} - Apellido: {1} - Nacimiento: {3} - Edad: {2} - Carrera: {4}", alumno2.Nombre, alumno2.Apellido, alumno2.Edad, alumno2.FechaNacimiento.ToShortDateString(), alumno2.Carrera);



Profesor profesor1 = new Profesor();
profesor1.Materia = "Programacion";
profesor1.Nombre = "Juan";

Console.WriteLine("Profesor: {0} - Alumno: {1}", profesor1.Saludar(), alumno2.Saludar());

public class Persona
{
    public string Nombre = "Sin asignar";
    public string Apellido = "Sin asignar";
    public int Edad
    {
        get
        {
            return DevolverEdad();
        }
    }

    private DateTime _fechaNacimiento;
    public DateTime FechaNacimiento
    {
        get
        {
            return _fechaNacimiento;
        }
        set
        {
            if (value.Year < 1800)
            {
                throw new Exception("Error en el año ingresado");
            }
            else
            {
                _fechaNacimiento = value;
            }
        }
    }

    public Persona()
    {

    }

    public Persona(string nombre, string apellido, DateTime fechaNacimiento)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
    }

    public Persona(string nombre, string apellido, int edad = 0)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    private int DevolverEdad()
    {
        int edad = DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;

        return edad;
    }

    public virtual string Saludar()
    {
        string saludo = "";
        if (DateTime.Now.Hour <= 12) saludo = "Buenos días";
        else saludo = "Buenas tardes";

        return saludo;
    }
}

public class Alumno : Persona
{
    public string Carrera;

    public Alumno()
    {

    }

    public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string carrera = "Sin definir") : base(nombre, apellido, fechaNacimiento)
    {
        Carrera = carrera;
    }

    public string DevolverNombreYCarrera()
    {
        return Nombre + " " + Apellido + " " + Carrera;
    }

    public void InscribirEnCarrera(string carrea)
    {
        Carrera = carrea;
    }

    public override string Saludar()
    {
        string nuevoSaludo = base.Saludar() + " profesor";
        return nuevoSaludo;
    }
}

public class Profesor : Persona
{
    public string Materia;

    public override string Saludar()
    {
        string nuevoSaludo = base.Saludar() + " Alumnos!";
        return nuevoSaludo;

    }

    public class ProfesorPrimaria : Profesor
    {

    }

    public class ProfesorSecundaria : Profesor
    {

    }
}