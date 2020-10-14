using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCsharp.Model
{
    class Departement
    {
        public string nom;
        public int numD;
       
        public List<Commune> Communes { get => communes; set => communes = value; }

        private List<Commune> communes;
    }
}
