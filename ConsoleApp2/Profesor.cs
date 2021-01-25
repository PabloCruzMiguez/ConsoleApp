using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Profesor : Persona
    {
        public string Materia;

        public Profesor(string materia)
        {
            Materia = materia;
        }
    }
}
