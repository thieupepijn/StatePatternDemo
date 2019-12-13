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
		public string Name
		{
			get; set;
		}

		public double NumberOfSpinnings
		{
			get; set;
		}

		public ILocation Location;

		public Person(string name)
		{
			Name = name;
			NumberOfSpinnings = 0;
			Location = new Left(this);
		}

		public string GiveInfo()
		{
			return string.Format("{0} is positioned {1} and has done {2} spinnings", Name, Location.Description(), NumberOfSpinnings);
		}

	}
}
