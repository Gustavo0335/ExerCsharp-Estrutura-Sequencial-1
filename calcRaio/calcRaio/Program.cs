double Ent , valc, T = 3.14159, raio, resultadoArredondado;
int casasDecimais = 4;

Console.WriteLine("Insira o valor do circulo");
Ent = double.Parse(Console.ReadLine());

valc = Ent * Ent;

raio = valc * T;

resultadoArredondado = Math.Round(raio, casasDecimais);

Console.WriteLine($"{resultadoArredondado}");