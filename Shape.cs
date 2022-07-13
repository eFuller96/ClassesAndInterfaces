namespace ClassesAndInterfaces;

public interface IShape
{
    public double GetArea();
}

public class Shape : IShape
{
    private readonly double _length;
    private readonly double _height;

    public double GetArea()
    {
        return _length * _height;
    }

    public Shape(double length, double height)
    {
        _length = length;
        _height = height;
    }
}