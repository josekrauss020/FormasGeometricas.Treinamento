

namespace FormasGeometricas;

internal class Quadrado : FormaGeometrica
{
    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public double Lado { get; }
    public override double CalculeArea()
    {
        double Area = Math.Pow(Lado, 2);
        return Area;
    }
    public override double CalculePerimetro()
    {
        double Perimetro = (Lado + Lado) * 2;
        return Perimetro;
    }
}
