using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Carrera.Dominio
{
    internal class DetalleCarrera
    {
        private int anioCursado, cuatrimestre;
        private Asignatura materia;
        private bool activo;

        public bool Activo { get { return activo; } set { activo = value; } }   

        public int AnioCursado
        {
            get { return anioCursado; }
            set { anioCursado = value; }
        }

        public int Cuatrimestre
        {
            get { return cuatrimestre; }
            set { cuatrimestre = value; }
        }

        public Asignatura Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public DetalleCarrera(int anioCursado, int cuatrimestre, Asignatura asignatura)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.materia = asignatura;
        }

        public override string ToString()
        {
            return "Año cursado: " + anioCursado + " - Cuatrimestre: " + cuatrimestre +
                " - Asignatura" + materia.ToString();
        }
    }
}
