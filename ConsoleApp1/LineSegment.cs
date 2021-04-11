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
	public LineSegment(MyPoint startpoint, MyPoint stoppoint)
	{
		startPoint = startpoint;
		stopPoint = stoppoint;
	}

	public double CalculateLength()
    {
		return Math.Sqrt(Math.Pow(startPoint.x - stopPoint.x, 2) + Math.Pow(startPoint.y - stopPoint.y, 2));
    }
}
