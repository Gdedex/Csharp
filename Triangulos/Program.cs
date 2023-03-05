int lado1, lado2, lado3;

Console.WriteLine("CALCULADORA DE TRIANGULOS");
Console.WriteLine();

Console.Write("Valor do lado 1: ");
lado1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor do lado 2: ");
lado2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor do lado 3: ");
lado3 = Convert.ToInt32(Console.ReadLine());

if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2){
    Console.WriteLine("Não pode ser um triângulo");
}
else if (lado1 == lado2 && lado2 == lado3){
    Console.WriteLine("É um triângulo Equilatero, pois todos os seus lado possuem a mesma medida");
}
else if (lado1 == lado2 || lado2 == lado3)
{
    Console.WriteLine("é um Triangulo Isóseles, pois dois lados pussuem a mesma medida");
}
else
{
    Console.WriteLine("É um triângulo Escaleno, pois todos os lados possuem medidas destintas");
}