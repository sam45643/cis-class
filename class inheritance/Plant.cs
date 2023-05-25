// Written by Madeline Ellingson
// 3/1/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_PlantProblem_Inheritance
{
	// This class is abstract which means we can't instantiate
	// objects or we can't make objects from it. 
	// That means we can't do this in main....
	//
	// Plant aPlant = new Plant();
	public abstract class Plant
	{
		// Class Variables
		private string name = "n/a";
		private string lifeCycle = "n/a";
		private int daysTilMaturation = -1;

		// Gets & Sets
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}
		public string LifeCycle
		{
			get { return this.lifeCycle; }
			set
			{
				// Here we need to make sure the value being
				// passed in is either a perenial or annual
				if(value == "Perenial" || value == "Annual")
				{
					this.lifeCycle = value;
				}
			}
		}
		public int DaysTilMaturation
		{
			get { return this.daysTilMaturation; }
			set 
			{ 
				// Here we need to make sure the value being
				// passed in is greater than 0
				if(value > 0)
				{
					this.daysTilMaturation = value;
				} 
			}
		}

		// Constructors
		public Plant(string aName, string aLifeCycle, int aDays)
		{
			this.Name = aName;
			this.LifeCycle = aLifeCycle;
			this.DaysTilMaturation = aDays;
		}

		// Methods
		public override string ToString()
		{
			string msg = "";
			msg += "Name: " + this.Name + "\n"
				+ "Life Cycle: " + this.LifeCycle + "\n"
				+ "Days Til Maturation: " + this.DaysTilMaturation + "\n";
			return msg;
		}

		// This method is marked abstract so we do not need to 
		// define a body (The body is what is in { } which we don't have)
		//
		// So see the comment above Flower's Grow method
		public abstract string Grow(int numOfDays);
	}
}
