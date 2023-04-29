using System;
using System.Reflection;


namespace CarLotSimulator
{
	public class Car
	{
        public Car()
		{
			CarLot.numberOfCars++;
		}

        public Car(int year, string make, string model, string engineNoise, string hunkNoise, bool isDrivable)
		{
			Year = year;
			Make = make;
			Model = model;
			EngineNoise = engineNoise;
			HunkNoise = hunkNoise;
			IsDrivable = isDrivable;
		}

		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HunkNoise { get; set; }
		public bool IsDrivable { get; set; }

		public void MakeEngineNoise(string engineNoise)
		{
			Console.WriteLine(engineNoise);
		}

		public void MakeHunkNoise(string hunkNoise)
		{
			Console.WriteLine(hunkNoise);
		}

	}
}

