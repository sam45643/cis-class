// Written by Madeline Ellingson
// 3/1/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_PlantProblem_Inheritance
{
	// This class is sealed which means it can't have children
	public sealed class FruitTree: Tree
	{
		// Class Variables
		private string fruitName = "n/a";
		private int fruitPerYear = -1;

		// Gets & Sets
		public string FruitName
		{
			get { return this.fruitName; }
			set { this.fruitName = value; }
		}

		public int FruitPerYear
		{
			get { return this.fruitPerYear; }
			set { this.fruitPerYear = value; }
		}

		// Constructors
		public FruitTree(string aName, string aLifeCycle, int aDays,
							double aHeight, bool aHasLeaves, string aFruitName,
							int aFruitPerYear): base(aName, aLifeCycle, aDays, aHeight, aHasLeaves)
		{
			this.FruitName = aFruitName;
			this.FruitPerYear = aFruitPerYear;
		}

		// Methods
		public override string ToString()
		{
			string msg = "";
			msg += base.ToString()
				+ "Fruit Name: " + this.FruitName + "\n"
				+ "Fruit Per Year: " + this.FruitPerYear + "\n";
			return msg;
		}

		// This method subtracts from the days til maturation and returns how many days it has left
		// to grow or if it is done growing it returns it is fully grown.
		public override string Grow(int numOfDays)
		{
			if (this.DaysTilMaturation - numOfDays <= 0)
			{
				// We are reseting this to 0 so that it doesn't go on into the negatives
				// forever
				this.DaysTilMaturation = 0;
				return "The " + this.Name + " is fully grown!\n";
			}
			else
			{
				this.DaysTilMaturation -= numOfDays;
				return "The " + this.Name + " has " + this.DaysTilMaturation + " until it is fully grown!\n";
			}
		}
	}
}
