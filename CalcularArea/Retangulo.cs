using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcularArea
{
    public class Retangulo : FormasGeometricas
    {


        private double _lado;
        public double Lado
        {
            get
            { return _lado; }
            set
            { _lado = value; }
        }

        private double _base;
        public double Base
        {
            get
            { return _base; }
            set
            { _base = value; }
        }
        public override void CalcularArea()
        {
            this.Area = _lado * _base;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 2 * _lado + 2 * _base;
        }

    }
}