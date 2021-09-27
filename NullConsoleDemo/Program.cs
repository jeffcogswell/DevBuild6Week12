using System;

namespace NullConsoleDemo
{
	class Rectangle
	{
		public int Length;
		public int Width;
	}

	class TwoRectangles
	{
		public Rectangle First;
		public Rectangle Second;
	}

	class Program
	{

		public static void Info(TwoRectangles rects)
		{
			Console.WriteLine("Here is the length of the second rectangle:");
			Console.WriteLine(rects.Second.Length.ToString());
		}

		static void Main(string[] args)
		{

			TwoRectangles myrects = new TwoRectangles();
			myrects.First = new Rectangle() { Length = 10, Width = 20 };
			//myrects.Second = new Rectangle() { Length = 15, Width = 25 };

			Info(myrects);
		}
	}
}
