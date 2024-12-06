namespace Calculado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            int operacao = int.Parse(Console.ReadLine()); //Convert String

            Console.WriteLine("Digite o primeiro numero ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                    default:Console.WriteLine("Numero invalido, digite outro numero.");
                    break;
            }
            Console.WriteLine("Resultado da operação dos números {0} e {1} é: {2}", num1, num2, resultado);
        }

        // Methods auxiliary
        public static int Adicao (int num1, int num2){
            int resultado = num1 + num2;
            return resultado;
            }
        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }

}
