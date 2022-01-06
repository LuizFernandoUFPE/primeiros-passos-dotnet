using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            s.Empilha(5); //Testei um novo número para observar a pilha e a propriedade de last-in First-Out(LIFO)
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}