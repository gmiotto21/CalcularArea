using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
   public class Quadrado : FormasGeometricas { 



        private double lado;
        public double Lado
        {
            get
            { return lado; }
            set
            { lado = value; }
        }

        public override void CalcularArea()
        {
            this.Area = lado * lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * lado;
        }
    }





}

