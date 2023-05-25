// Written by Madeline Ellingson
// 3/1/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_PlantProblem_Inheritance
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Make some plants
			Flower aFlower = new Flower("Petunia", "Annual", 5, 5);
			Vegetable aVegetable = new Vegetable("Carrot", "Annual", 60, "Orange");
			Tree aTree = new Tree("Pine", "Perenial", 365, 15.0, false);
			FruitTree aFruitTree = new FruitTree("Apple Tree", "Perenial", 480, 10.0, true, "Apple", 15);

			// Make a list of plants
			List<Plant> aListOfPlants = new List<Plant>()
			{
				aFlower, aVegetable, aTree, aFruitTree
			};

			// Loop through and print them out while also doing the grow method.
			// The flower will bloom
			foreach(Plant aPlant in aListOfPlants)
			{
				Console.WriteLine(aPlant.ToString());
				Console.WriteLine(aPlant.Grow(5));
			}

			Console.ReadLine();
		}
	}
}
