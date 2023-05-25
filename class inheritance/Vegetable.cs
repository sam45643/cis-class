// Written by Madeline Ellingson
// 3/1/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_PlantProblem_Inheritance
{
	public class Vegetable: Plant
	{
		// Class Variables
		private string color = "n/a";

		// Gets & Sets
		public string Color
		{
			get { return this.color; }
			set { this.color = value; }
		}

		// Constructors
		public Vegetable(string aName, string aLifeCycle, int aDays, string aColor): base(aName, aLifeCycle, aDays)
		{
			this.Color = aColor;
		}

		// Methods
		public override string ToString()
		{
			string msg = "";
			msg += base.ToString()
				+ "Color: " + this.Color + "\n";
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
