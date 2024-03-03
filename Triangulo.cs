namespace FormasGeometricas;

internal class Triangulo : FormaGeometrica
{
    public Triangulo(double lado, double altura)
    {
        Base = lado;
        Altura = altura;
    }

    public double Base { get;} 
    public double Altura { get; }

    public override double CalculeArea()
    {
        double Area = (Base * Altura) / 2; 
        return Area;
    }
    public override double CalculePerimetro()
    {
        double PotBase = Math.Pow(Base, 2);
        double PotAltura = Math.Pow(Altura, 2);
        double Soma = PotAltura + PotBase;
        double Hipotenusa = Math.Sqrt(Soma);
        double Perimetro = Base + Altura + Hipotenusa;
        return Perimetro;
    }
}
