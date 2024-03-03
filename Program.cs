using FormasGeometricas;

FormaGeometrica novoQuadrado = new Quadrado(25);
Console.WriteLine("Aqui o perimetro do Quadrado:");
Console.WriteLine(novoQuadrado.CalculePerimetro());

Console.WriteLine("Aqui a área do Quadrado:");
Console.WriteLine(novoQuadrado.CalculeArea());

FormaGeometrica novoCirculo = new Circulo(8);
double resultado1 = novoCirculo.CalculePerimetro();
double resultado2 = novoCirculo.CalculeArea();

Console.WriteLine("Aqui o perimetro do Círculo:");
Console.WriteLine(resultado1);
Console.WriteLine("Aqui a área do Círculo:");
Console.WriteLine(resultado2);

FormaGeometrica novoTriangulo = new Triangulo(3, 4); //hipotenusa = 5
double resultado3 = novoTriangulo.CalculePerimetro();
double resultado4 = novoTriangulo.CalculeArea();

Console.WriteLine("Aqui o perimetro do Triângulo:");
Console.WriteLine(resultado3);
Console.WriteLine("Aqui a área do Triângulo:");
Console.WriteLine(resultado4);

