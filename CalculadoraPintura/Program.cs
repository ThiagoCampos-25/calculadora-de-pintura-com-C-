using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é largura do Cômodo");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Quala a profundidade");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("A área das Paredes é: ");
            const double Altura = 2.9;


            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.CalcularAreaParedes(largura, profundidade, Altura));

            Console.WriteLine("A área do teto: ");
            Console.WriteLine(calculadora.CalcularAreaTeto(largura, profundidade));

            Console.WriteLine("A litragem de tinta necessária é: ");
            Console.WriteLine(calculadora.CalcularLitragemNecessaria());
            Console.ReadLine();
        }
    }
}