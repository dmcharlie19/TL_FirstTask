using System;

namespace firstTask
{
	class Rectangle
	{
		public Point TopLeft { get; private set; }
		public Point BottomRight { get; private set; }

		public Rectangle(Point topLeft, Point bottomRight)
		{
			if (topLeft.X >= bottomRight.X)
			{
				throw new ArgumentException("invalid arg ");
			}

			if (topLeft.Y <= bottomRight.Y)
			{
				throw new ArgumentException("invalid arg ");
			}
			TopLeft = topLeft;
			BottomRight = bottomRight;
		}

		public int GetSquare()
		{
			int heiht = TopLeft.Y - BottomRight.Y;
			int widht = BottomRight.X - TopLeft.X;

			return heiht * widht;
		}

		public int GetPerimeter()
		{

			int heiht = TopLeft.Y - BottomRight.Y;
			int widht = BottomRight.X - TopLeft.X;

			return heiht * 2 + widht * 2;
		}
	}
}