using System;
using System.IO;

namespace Practica {
	class Program {
		static void GreetCountries(string inputFile, string outputFile) {
			try {
				using (StreamReader countriesInput = new StreamReader(inputFile))
					using (StreamWriter countriesOutput = new StreamWriter(outputFile)) {
						string cline = countriesInput.ReadLine();
						while (cline != null) {
							countriesOutput.WriteLine($"Saludos hasta {cline}!");
							cline = countriesInput.ReadLine();
						}
					}
			}
			catch
				(FileNotFoundException e) {
				Console.WriteLine($"Error: {e.Message}");
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}

		static void Main(string[] args) { 
			DateTime today = DateTime.Now;
			CustomException myCustomException = new CustomException();
			string path = "../../../";
			string dateFormat = today.ToString("yyyy-MMM-dd");
			string outputFile;

			if (args.Length == 1) path = args[0];

			outputFile = $"{path}Countries {dateFormat}.txt";
			GreetCountries($"{path}countries.txt", outputFile);

			Avion vuelo = new Avion(today, 32, "VIP");
			Console.WriteLine(vuelo.TotalPasajeros());
			Console.WriteLine(vuelo.Detalles());

			try {
				myCustomException.Fail();
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
	}
}