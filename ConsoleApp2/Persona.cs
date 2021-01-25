using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Persona
    {
        public string Nombre;
        public string Apellido;
        public long Dni;
        public DateTime FechaNacimiento;
        public Boolean Activo;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, long dni, DateTime fechanacimiento, Boolean activo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechanacimiento;
        }

        public void Activar()
        {
            Activo = true;
        }

        public void Inactivar()
        {
            Activo = false;
        }

    }
}
