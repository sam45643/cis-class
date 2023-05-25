// Written by Madeline Ellingson
// 3/1/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_PlantProblem_Inheritance
{
	public class Flower: Plant
	{
		// Class Variables
		private int numOfPetals = 0; // The default could also be -1 you could argue that not all flowers have petals

		// Gets & Sets
		public int NumOfPetals
		{
			get { return numOfPetals; }
			set { this.numOfPetals = value; }
		}

		// Constructors
		public Flower(string aName, string aLifeCycle, int aDays, int aNumOfPetals): base(aName, aLifeCycle, aDays)
		{
			this.numOfPetals = aNumOfPetals;
		}

		// Methods
		public override string ToString()
		{
			string msg = "";
			msg += base.ToString()
				+ "Num Of Petals: " + this.NumOfPetals + "\n";
			return msg;
		}

		// What would be a good thing to do would be to have a parameter
		// numOfDays where we would then grow the flower by that number
		// of days
		//
		// I didn't specify this so it is not necessary at all but I will 
		// do it because I am fancy 
		public override string Grow(int numOfDays)
		{
			if(this.DaysTilMaturation - numOfDays <= 0)
			{
				// We are reseting this to 0 so that it doesn't go on into the negatives
				// forever
				this.DaysTilMaturation = 0;
				return this.Bloom();
			}
			else
			{
				this.DaysTilMaturation -= numOfDays;
				return "The Flower has " + this.DaysTilMaturation + " until it is fully grown!\n";
			}
		}

		// This method is called when the flower
		// is fully grown
		public string Bloom()
		{
			return "The flower bloomed!\n";
		}
	}
}
