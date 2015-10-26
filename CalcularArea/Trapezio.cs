using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcularArea
{
    public class Trapezio : FormasGeometricas
    {

        private double _baseMenor;
        public double BaseMenor
        {
            get
            { return _baseMenor; }
            set
            { _baseMenor = value; }
        }
        private double _baseMaior;
        public double BaseMaior
        {
            get
            { return _baseMaior; }
            set
            { _baseMaior = value; }
        }
        private double _lado1;
        public double Lado1
        {
            get
            { return _lado1; }
            set
            { _lado1 = value; }
        }
        private double _lado2;
        public double Lado2
        {
            get
            { return _lado2; }
            set
            { _lado2 = value; }
        }
        private double _altura;
        public double Altura
        {
            get
            { return _altura; }
            set
            { _altura = value; }
        }
        public override void CalcularArea()
        {
            this.Area = (_baseMaior + _baseMenor) * _altura / 2;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = _baseMaior + _baseMenor + _lado1 + _lado2;
        }

    }
}