/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/13/2019
 * Time: 7:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StatePatternDemo
{
	
	public interface ILocation
	{
		void Mirror();
		void TurnClockWise();
		void TurnAntiClockWise();
		string Description();		
	}
}
