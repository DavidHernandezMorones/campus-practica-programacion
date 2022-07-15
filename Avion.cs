using System;

namespace Practica {
	internal sealed class Avion : Transporte {
		private double _precio;
		private string _tipoVuelo;

		public Avion(DateTime salida, int pasajeros, string vuelo) : base(salida, pasajeros) {
			if (IsChristmas())
				_precio = 5000 * DescuentoPorHora() * 0.75;
			else
				_precio = 5000 * DescuentoPorHora();
			
			_tipoVuelo = vuelo;
		}
		
		public double TotalPasajeros() {
		    return _precio * numeroPasajeros;
		}

		public string Detalles () {
			return $"El vuelo es {_tipoVuelo} y tiene un precio de {_precio}";
		}
	}
}