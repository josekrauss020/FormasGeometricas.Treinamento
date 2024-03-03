using System;
namespace FormasGeometricas;


internal class Circulo : FormaGeometrica 
{
    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double Raio { get; }

    public override double CalculeArea()
    {
        double Area = Raio * Raio * Math.PI;
        return Area;
    }

    public override double CalculePerimetro()
    {
        double Perimetro = 2 * Math.PI * Raio;
        return Perimetro;
    }

}
