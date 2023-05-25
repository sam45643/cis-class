// Written by Madeline Ellingson
// 3/1/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_PlantProblem_Inheritance
{
	public class Tree: Plant
	{
		// Class Variables
		private double height = 0.0;
		private bool hasLeaves = false;

		// Gets & Sets
		public double Height
		{
			get { return this.height; }
			set { this.height = value; }
		}

		public bool HasLeaves
		{
			get { return this.hasLeaves; }
			set { this.hasLeaves = value; }
		}

		// Constructors
		public Tree(string aName, string aLifeCycle, int aDays, double aHeight, bool aHasLeaves): base(aName, aLifeCycle, aDays)
		{
			this.Height = aHeight;
			this.HasLeaves = aHasLeaves;
		}

		// Methods
		public override string ToString()
		{
			string msg = "";
			msg += base.ToString()
				+ "Height: " + this.Height + "\n"
				+ "Has Leaves?: " + this.HasLeaves + "\n";
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
