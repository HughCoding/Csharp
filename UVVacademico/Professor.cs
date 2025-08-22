using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class Professor
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public int CargaHoraria { get; set; }
        public double Beneficio { get; set; }

        public Professor(string nome, int matricula, int cargaHoraria,  double beneficio)
        {
            Nome = nome;
            Matricula = matricula;
            CargaHoraria = cargaHoraria;
            Beneficio = beneficio;

        }

        public abstract void calcularBeneficio();


        public double getBeneficio()
        {
            return Beneficio;
        }
    }
}
