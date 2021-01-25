using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Curso
    {
        public Profesor[] ListaProfesores = new Profesor[5];
        private int posicion = 0;

        public void AgregarProfesor(Profesor profesor)
        {
            ListaProfesores[posicion] = profesor;
        }

        public void AgregarAlumno(Alumno alumno)
        {

        }
    }
}
