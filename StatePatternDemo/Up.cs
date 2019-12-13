/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/13/2019
 * Time: 7:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StatePatternDemo
{
	
	public class Up : ILocation
	{
		private Person _person;

        public Up(Person person)
        {
            _person = person;
        }

        public void Mirror()
        {
            _person.Location = new Down(_person);
        }

        public void TurnClockWise()
        {
        	_person.NumberOfSpinnings += 0.25;
        	_person.Location = new Right(_person);
        }

        public void TurnAntiClockWise()
        {
        	_person.NumberOfSpinnings -= 0.25;
        	_person.Location = new Left(_person);
        }

        public string Description()
        {
            return "Up";
        }

	}
}
