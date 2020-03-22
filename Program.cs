using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasTaxi
{
    class Program //www.fckr3i.com
    {
		static void Main(string[] args)
		{
			// membuat objek dari class taxi

			Taxi taxi = new Taxi();


			// mengeset nilai properties
			taxi.DriverName = "Untung Dwi Handoko";
			taxi.OnDuty = true;
			taxi.NumPassenger = 10;

			// memanggil method 
			taxi.TaxiInfo();
			taxi.PickupPassenger();
			taxi.DropOffPassenger();

			Console.ReadKey();
		}

	}
}
