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
				Console.WriteLine("Press '->' (turn clockwise), '<-' (turn anti-clockwise), 'M' (mirror) or any other key to exit");
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				Console.WriteLine();
				
				switch (keyInfo.Key)
				{
						case ConsoleKey.LeftArrow: Console.WriteLine("Turn AntiClockWise"); doug.Location.TurnAntiClockWise(); break;
						case ConsoleKey.RightArrow: Console.WriteLine("Turn Clockwise"); doug.Location.TurnClockWise(); break;
						case ConsoleKey.M: Console.WriteLine("Mirror"); doug.Location.Mirror(); break;
						default: return;
				}
				
			}
		}
	}
}