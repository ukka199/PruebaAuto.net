using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaAuto
{
    abstract class VehiculoComponentes
    {
        private float _estadoComponente;

        public VehiculoComponentes(float estadoComponente)
        {
            _estadoComponente = estadoComponente;
        }

        public float EstadoComponente { get => _estadoComponente; set => _estadoComponente = value; }
    }
}