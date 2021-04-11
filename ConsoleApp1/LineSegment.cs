using ConsoleApp1;
using System;

public class LineSegment
{
	public MyPoint startPoint;
	public MyPoint stopPoint;

	
	public LineSegment(int x1, int y1, int x2, int y2)
    {
		startPoint = new MyPoint(x1, y1);
		stopPoint = new MyPoint(x2, y2);
	}

	public LineSegment(int x1, int y1, int x2, int y2, int z1, int z2)
	{
		startPoint = new MyPoint3D(x1, y1, z1);
		stopPoint = new MyPoint3D(x2, y2, z2);
	}

	public LineSegment(MyPoint startpoint, MyPoint stoppoint)
	{
		startPoint = startpoint;
		stopPoint = stoppoint;

	}

	public double CalculateLength()
    {
		if (startPoint is MyPoint3D)
        {
			MyPoint3D startPointz = (MyPoint3D)startPoint;
			MyPoint3D stopPointz = (MyPoint3D)stopPoint;

			return Math.Sqrt(Math.Pow(startPointz.x - stopPointz.x, 2) + Math.Pow(startPointz.y - stopPointz.y, 2) + Math.Pow(startPointz.z - stopPointz.z, 2));
		}
		return Math.Sqrt(Math.Pow(startPoint.x - stopPoint.x, 2) + Math.Pow(startPoint.y - stopPoint.y, 2));
    }
}
