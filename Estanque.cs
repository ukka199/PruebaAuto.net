using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaAuto
{
    class Estanque : VehiculoComponentes
    {
        private float _capacidad;
        private float _litros;

        public Estanque(float capacidad, float litros, float estadoComponente) : base(estadoComponente)
        {
            _capacidad = capacidad;
            _litros = litros;
        }

        public float Capacidad { get => _capacidad; set => _capacidad = value; }
        public float Litros { get => _litros; set => _litros = value; }

        public bool MitadCombustible()
        {
            float minCombustible = 10.5f * _capacidad / 100.0f;
            float maxCombustible = 50.0f * _capacidad / 100.0f;
            if (_litros > minCombustible & _litros <= maxCombustible)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool BajoCombustible()
        {
            float maxCombustible = 10.5f * _capacidad / 100.0f;
            if (_litros <= maxCombustible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}