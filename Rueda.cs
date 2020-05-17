using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaAuto
{
    class Rueda : VehiculoComponentes
    {
        private string _recubrimiento;
        private int _minDurometro;
        private int _maxDurometro;


        public Rueda(float estadoComponente, string recubrimiento, int primerNumero, int segundoNumero) : base(estadoComponente)
        {
            _recubrimiento = recubrimiento;

            if (primerNumero >= segundoNumero)
            {
                _minDurometro = segundoNumero;
                _maxDurometro = primerNumero;
            }

            else
            {
                _minDurometro = primerNumero;
                _maxDurometro = segundoNumero;
            }
        }
        public string Recubrimiento { get => _recubrimiento; set => _recubrimiento = value; }
        public int MinDurometro { get => _minDurometro; set => _minDurometro = value; }

        public int MaxDurometro { get => _maxDurometro; set => _maxDurometro = value; }

    }
}
