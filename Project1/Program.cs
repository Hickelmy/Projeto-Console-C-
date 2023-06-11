namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            bool condition = false;
            char gender = 'F';
            char text = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Nome Teste";
            object obj1 = "Objeto";
            object obj2 = 4.5f;

            int nMax = int.MaxValue;
            int nMin = int.MinValue;
            sbyte sMax = sbyte.MaxValue;
            sbyte sMin = sbyte.MinValue;



            Console.WriteLine(condition);
            Console.WriteLine(gender);
            Console.WriteLine(text);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(nMax);
            Console.WriteLine(nMin);
            Console.WriteLine(sMax);
            Console.WriteLine(sMin);


        }
    }
}