/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/13/2019
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StatePatternDemo
{
	class Program
	{
		public static void Main(string[] args)
		{

			Person doug = new Person("Doug");
			while(true)
			{
				Console.WriteLine(doug.GiveInfo());
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				
				if (keyInfo.Key == ConsoleKey.LeftArrow)
				{
					doug.Location.TurnAntiClockWise();
				}
				else if (keyInfo.Key == ConsoleKey.RightArrow)
				{
					doug.Location.TurnClockWise();
				}
				else if (keyInfo.Key == ConsoleKey.M)
				{
					doug.Location.Mirror();
				}
				else
				{
					break;
				}
				
				
			}
		}
	}
}