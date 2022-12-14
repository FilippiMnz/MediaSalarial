using System; 

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome do Funcionario(a):");
            string nome1 = Console.ReadLine();
            Console.Write("Insira o Salario");
            int salario = int.Parse(Console.ReadLine());

            Console.Write("Insira o nome do Funcionario(a):");
            string nome2 = Console.ReadLine();
            Console.Write("Insira o Salario");
            int salario2 = int.Parse(Console.ReadLine());

            int mediaSalarial = (salario + salario2)/2;
                
            Console.WriteLine("A media Salarial é de " + mediaSalarial);
        }
    }
}