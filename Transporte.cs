using System;

namespace Practica {
	internal abstract class Transporte {
		protected DateTime salida;
		protected int numeroPasajeros;

		public Transporte(DateTime algunDia, int pasajeros) {
			salida = algunDia;
			numeroPasajeros = pasajeros;
		}

		protected double DescuentoPorHora() {
			if (salida.Hour >= 15)
				return 0.85;
			if (salida.DayOfWeek == DayOfWeek.Saturday)
				return 0.8;
			return 1;
		}

		protected bool IsChristmas() {
			return salida.Day == 25 && salida.Month == 12;
		}
	}
}