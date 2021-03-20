using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. constante π (pi) = 3,14159 radianos - Math.PI

            //2. constante g = 9,80665 m/s²
            double g = 9.80665;

            double anguloEmGraus;
            double anguloEmRadianos;
            double velocidade;
            double alcance;
            double altura;

            Console.WriteLine("--------------");
            Console.WriteLine("-- Lançamento do Projétil --");
            Console.WriteLine("--------------");

            Console.Write("Entre com a velocidade, em m/..: ");
            velocidade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entre com a velocidade, em m/s..: ");
            anguloEmGraus = Convert.ToDouble(Console.ReadLine()) ;

            //3. Converter o ângulo de graus para radianos
            anguloEmRadianos = anguloEmGraus * (Math.PI/180);

            //4. Aplicar a Equação de Torrivelli para o alcance
            alcance = Math.Pow(velocidade, 2) * Math.Sin(2 * anguloEmRadianos) / g;
            Console.WriteLine($"Alcance........: {alcance:N2} m");

            //5. Aplicar a equação de Torricelli para a altura.
            altura = Math.Pow((velocidade * Math.Sin(anguloEmRadianos)), 2) / (2 * g);
            Console.WriteLine($"Altura máxima..: {altura:N2} m");





        }
    }
}
