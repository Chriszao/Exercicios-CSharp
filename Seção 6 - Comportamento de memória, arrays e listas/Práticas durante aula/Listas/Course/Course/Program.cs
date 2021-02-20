using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //Adicionar elementos a lista, utilizamos o comando "Add".
            //O Comando Add, adiciona por padrão ao final da lista.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            //Comando "Insert", é possivel adicionar um elemento na posição especificada;
            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");

            //"Count" Realiza a contagem de elmentos na lista;
            Console.WriteLine("List Count: " + list.Count);

            Console.WriteLine("------------------------------");

            //Comando Find, encontrará o primeiro nome com a letra determinada. Ex: Encontre o primeiro Nome que comece com a letra A;
            //string s1 = list.Find(x => x[0] == 'A') = Pode-se evitar o uso de função ao realizar uma expressão Lambda;
            //Predicado é uma função que pega um valor e retornará true or false conforme a lógica implementada na função;
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            //Comando FindLast, encontrará o ultimo nome com a letra determinada. Ex: Encontre o ultimo Nome que comece com a letra A;
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            Console.WriteLine("------------------------------");

            //Comando FindIndex, encontrará a posição em que o primeiro nome com a letra determinada aparece. Ex: Encontre a posição em que o primeiro Nome comece com a letra A;
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            //Comando FindLastIndex, encontrará a posição em que o ultimo nome com a letra determinada aparece. Ex: Encontre a posição em que o ultimo Nome comece com a letra A;
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("------------------------------");

            //Comando FindAll filtrará a lista criando uma nova com base no predicado utilizado. Ex: Ache somente nomes que contenha 5 caracteres;
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("------------------------------");

            //Comando Remove removerá elementos da lista
            //Se o metodo remove não encontrar o objeto desejado, ele dará continuidade na execução, sem remover ou gerar algum erro.

            /*list.Remove("Alex");
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/

            /*list.RemoveAt(3);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/

            list.RemoveRange(2, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");
        }
    }
}
