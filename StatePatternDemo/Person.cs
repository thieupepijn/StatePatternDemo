/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/13/2019
 * Time: 7:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StatePatternDemo
{
	/// <summary>
	/// Description of Person.
	/// </summary>
	public class Person
	{
		private string _name;

		public double NumberOfSpinnings
		{
			get; set;
		}

		public ILocation Location;

		public Person(string name)
		{
			_name = name;
			NumberOfSpinnings = 0;
			SetRandomInitialLocation();
		}

		public string GiveInfo()
		{
			return string.Format("{0} is positioned {1} and has done {2} spinnings", _name, Location.Description(), NumberOfSpinnings);
		}

		private void SetRandomInitialLocation()
		{
			Random random = new Random();
			
			switch (random.Next(0, 4))
			{
					case 0: Location = new Left(this); break;
					case 1: Location = new Up(this); break;
					case 2: Location = new Right(this); break;
					case 3: Location = new Down(this); break;
			}		
		}
		
	}
}
