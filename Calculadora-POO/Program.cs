using System;

namespace Calculadora_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* * * * C A L C U L A D O R A  * * * *\n\n");
            Console.WriteLine("Escolha uma operação\n\n");
            Console.WriteLine("1 - SOMA\n2 - SUBTRAÇÃO\n3 - MULTIPLICAÇÃO\n4 - DIVISÃO\n99 - SAIR");
            int operacao = int.Parse(Console.ReadLine());
            Numero1 num1 = new Numero1();
            Numero2 num2 = new Numero2();
            Calculo op = new Calculo();

            if (operacao == 1)
            {
                op.soma();
            }
            else if (operacao == 2)
            {
                op.subtracao();
            }
            else if (operacao == 3)
            {
                op.multiplicacao();
            }
            else if (operacao == 4)
            {
                op.divisao();
            }
            else if (operacao == 99)
            {
               return;
            }
        }

        class Numero1
        {
            public float num1;

            public float Num1
            {
                get { return num1; }
                set { num1 = value; }
            }

            public float Getnum1()
            {
                Console.WriteLine("Digite o primeiro número");
                Num1 = float.Parse(Console.ReadLine());
                return Num1;
            }
        }

        class Numero2
        {
            public float num2;

            public float Num2
            {
                get { return num2; }
                set { num2 = value; }
            }

            public float GetNum2()
            {
                Console.WriteLine("Digite o segundo número");
                Num2 = float.Parse(Console.ReadLine());
                return Num2;
            }
        }

        class Calculo
        {
            public float resultado;
            Numero1 num1 = new Numero1();
            Numero2 num2 = new Numero2();

            public void soma()
            {
                resultado = num1.Getnum1() + num2.GetNum2();
                Console.WriteLine(resultado);
            }

            public void subtracao()
            {
                resultado = num1.Getnum1() - num2.GetNum2();
                Console.WriteLine(resultado);
            }

            public void multiplicacao()
            {
                resultado = num1.Getnum1() * num2.GetNum2();
                Console.WriteLine(resultado);
            }

            public void divisao()
            {
                resultado = num1.Getnum1() / num2.GetNum2();
                Console.WriteLine(resultado);
            }
        }
    }
}
