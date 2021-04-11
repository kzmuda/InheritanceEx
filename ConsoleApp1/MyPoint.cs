using System;

public class MyPoint
{
	public int x;
	public int y;
	public MyPoint(int x, int y)
    {
		this.x = x;
		this.y = y;
	}

    public virtual double GetDistanceFromPoint(MyPoint point)
    {
		return Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));
	}

}
