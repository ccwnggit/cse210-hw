public class Circle : Shape

{
    private float _radius;


public Circle (string color, float radius): base (color)
{
    _radius = radius;
}


    public override float GetArea()
    {
        float floatPI = MathF.PI;
        return _radius*_radius*floatPI;
    } 
}