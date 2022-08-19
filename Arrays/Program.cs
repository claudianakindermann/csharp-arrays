using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var meuArray = new int[5]; //lista de tamanho 5
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray.Length);

            Console.WriteLine("---------- listando meu array ------------");

            for (int index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }

            Console.WriteLine("---------- listando meu array com foreach------------");

            var funcionarios = new Funcionarios[5];
            funcionarios[0] = new Funcionarios() { Id = 2567, Name = "Maria" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Name);
            }
        }
    }
    public struct Funcionarios
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}