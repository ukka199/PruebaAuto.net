using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PruebaAuto
{
    abstract class Vehiculo

    {
        private Estanque _estanque;
        private Mezclador _mezclador;
        private Motor _motor;
        private Rueda _ruedas;

        public Vehiculo(Estanque estanque, Mezclador mezclador, Motor motor, Rueda ruedas)
        {
            _estanque = estanque;
            _mezclador = mezclador;
            _motor = motor;
            _ruedas = ruedas;
        }
    }
}
