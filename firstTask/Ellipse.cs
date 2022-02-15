using System;

namespace firstTask
{
	class Ellipse
	{
		public Point Center { get; private set; }
		public UInt32 SemiMinorAxis { get; private set; }
		public UInt32 SemiMajorAxis { get; private set; }

		public Ellipse(Point center, UInt32 semiMinorAxis, UInt32 semiMajorAxis)
		{
			if (semiMinorAxis > semiMajorAxis)
			{
				throw new ArgumentException("Большая полуось должна быть больше малой полуоси");
			}

			Center = center;
			SemiMinorAxis = semiMinorAxis;
			SemiMajorAxis = semiMajorAxis;
		}

		public double GetSquare()
		{
			return Math.PI * SemiMajorAxis * SemiMinorAxis;
		}

		public double GetPerimeter()
		{
			if (SemiMajorAxis == SemiMinorAxis)
			{
				// Частный случай - окружность
				return 2 * Math.PI * SemiMajorAxis;
			}
			else
			{
				UInt32 SemiAxisSumm = SemiMajorAxis + SemiMinorAxis;
				double SemiAxisDiffPow2 = Math.Pow(SemiMajorAxis - SemiMinorAxis, 2.0);

				return 4 * ((Math.PI * SemiMajorAxis * SemiMinorAxis + SemiAxisDiffPow2) / SemiAxisSumm);
			}
		}
	}
}