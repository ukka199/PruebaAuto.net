using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaAuto
{
    class Automovil : Vehiculo

    {
        private string _marca;
        private int _fecha;
        private float _kilometraje;

        public Automovil(Estanque estanque, Mezclador mezclador, Motor motor, Rueda rueda, string marca, int fecha, float kilometraje) : base(estanque, mezclador, motor, rueda)
        {
            _marca = marca;
            _fecha = fecha;
            _kilometraje = kilometraje;
        }
        public string Marca { get => _marca; set => _marca = value; }
        public int Fecha { get => _fecha; set => _fecha = value; }
        public float Kilometraje { get => _kilometraje; set => _kilometraje = value; }
    }
}