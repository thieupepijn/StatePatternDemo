/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/13/2019
 * Time: 7:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StatePatternDemo
{
	/// <summary>
	/// Description of Right.
	/// </summary>
	public class Right : ILocation
	{
		private Person _person;

        public Right(Person person)
        {
            _person = person;
        }

        public void Mirror()
        {
            _person.Location = new Left(_person);
        }

        public void TurnClockWise()
        {
        	_person.NumberOfSpinnings += 0.25;
            _person.Location = new Down(_person);
        }

        public void TurnAntiClockWise()
        {
        	_person.NumberOfSpinnings -= 0.25;
            _person.Location = new Up(_person);
        }

        public string Description()
        {
            return "Right";
        }

	}
}
