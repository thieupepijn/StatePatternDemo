/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/13/2019
 * Time: 7:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StatePatternDemo
{
	/// <summary>
	/// Description of Left.
	/// </summary>
	public class Left : ILocation
	{
		
		private Person _person;
		

		public Left(Person person)
		{
			_person = person;
		}

		public void Mirror()
		{
			_person.Location = new Right(_person);
		}


		public void TurnClockWise()
		{
			_person.NumberOfSpinnings += 0.25;
			_person.Location = new Up(_person);
		}

		public void TurnAntiClockWise()
		{
			_person.NumberOfSpinnings -= 0.25;
			_person.Location = new Down(_person);
		}

		public string Description()
		{
			return "Left";
		}

		
	}
}

