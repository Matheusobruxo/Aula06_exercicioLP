using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Aula06_exercicioLP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }

        void exercicio1()
        {
            /*
             *  Escreva um algoritmo para ler o número total de eleitores de um município, o número
                de votos brancos, nulos e válidos. Calcular e escrever o percentual que cada um
                representa em relação ao total de eleitores.
            */

            int totalE, totalH,  // e de eleitores                       //h de habitantes
                vBrancos, vNulos, vValidos,   // v de votos
                totalV; // V de Votos

            string municipio, user;
            float porcentB, porcentN, porcentV, // b de branco               //n de nulo                //v de valido
                porcentComp, porcentHab;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Bem vindo ao Banco de resultados de votos");
            Console.WriteLine("---------------------------------------------------------\n\n");


            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite o nome do responsável:");
            user = Console.ReadLine();
            Console.WriteLine("\nDigite o nome do municipio:");
            municipio = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"A atualização dos eleitores será feita por {user}!!");

            Console.WriteLine();

            Console.WriteLine($"Quantas pessoas moram na cidade de(o) {municipio}?");
            totalH = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a quantidade de eleitores:");
            totalE = int.Parse(Console.ReadLine());

            if (totalE < 0 || totalE > totalH)
            {
                Console.WriteLine("Digite uma quantidade válida de eleitores!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            Console.WriteLine("---------------- Contabilização de votos ----------------");
            Console.WriteLine("\nQuantos votos brancos tiveram?");
            vBrancos = int.Parse(Console.ReadLine());
            if (vBrancos < 0 || vBrancos > totalE)
            {
                Console.WriteLine("Digite uma quantidade válida de Votos!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            porcentB = 100 / (totalE / vBrancos);



            Console.WriteLine("\nQuantos votos nulos tiveram?");
            vNulos = int.Parse(Console.ReadLine());
            if (vNulos < 0 || vNulos > totalE)
            {
                Console.WriteLine("Digite uma quantidade válida de Votos!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            porcentN = 100 / (totalE / vNulos);




            Console.WriteLine("\nE quantos votos válidos tiveram?");
            vValidos = int.Parse(Console.ReadLine());
            if (vValidos < 0 || vValidos > totalE)
            {
                Console.WriteLine("Digite uma quantidade válida de Votos!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            porcentV = 100 / (totalE / vValidos);



            totalV = vBrancos + vNulos + vValidos;



            porcentComp = porcentB + porcentN + porcentV;

            porcentHab = 100 / (totalH / totalV);



            if (totalV > totalE)
            {
                Console.WriteLine("Digite uma quantidade válida de Votos!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.Clear();

            Console.WriteLine("---------------- Contabilização de votos ----------------");
            Console.WriteLine("Os valores a seguir são referente ao total de eleitores!!");
            Console.WriteLine($"A quantidade de votos em Brancos representam {porcentB}%");
            Console.WriteLine($"A quantidade de votos em Nulos representam {porcentN}%");
            Console.WriteLine($"A quantidade de votos em Validos representam {porcentV}%");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"{porcentComp}% Dos eleitores de {municipio} compareceram para votar !");
            Console.WriteLine($"Oque representa {porcentHab}% da população da cidade !!");
            Console.ReadKey();
        }
        void exercicio2()
        {
            /*  
    *  Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual
    de reajuste. Calcular e escrever o valor do novo salário.  
    */
            float salarioAtual, salarioFinal,
                     percentReajuste;

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("---------------- Calculadora de reajuste -----------------");
            Console.WriteLine("Digite o seu salário mensal atual:");
            salarioAtual = int.Parse(Console.ReadLine());
            if (salarioAtual < 0)
            {
                Console.WriteLine("Digite um salário válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }


            Console.WriteLine("\n\nDigite o percentual de reajuste:");
            Console.WriteLine("Exemplo: para 15,5% digite 15,5");
            percentReajuste = float.Parse(Console.ReadLine());
            percentReajuste = percentReajuste / 100;
            if (percentReajuste < 0)
            {
                Console.WriteLine("Digite um salário válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            salarioFinal = salarioAtual + (salarioAtual * percentReajuste);

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Seu salário será reajustado para {salarioFinal}");


            Console.ReadKey();
        }
        void exercicio3()
        {
            /*
            *  Uma revendedora de carros usados paga a seus funcionários vendedores um salário
               fixo por mês, no valor de R$2000,00, mais uma comissão também fixa para cada carro
               vendido de R$300,00 e mais 5% do valor das vendas por ele efetuadas. Escrever um
               algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas.
               Calcule e escreva o salário final do vendedor.

            */
            double salarioBase = 2000f, salarioFinal, comissionamento,
                qtdeVendas, valorTotalVendas, comissaoTaxa;


            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("---------------- Calculadora de Salário ------------------");
            Console.WriteLine("Quantos carros foram vendidos por você esse mês?");
            qtdeVendas = int.Parse(Console.ReadLine());
            if (qtdeVendas < 0)
            {
                Console.WriteLine("Digite uma quantidade valida de vendas!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            comissionamento = qtdeVendas * 300;

            Console.WriteLine("Qual o seu total de vendas atingido até o momento?");
            valorTotalVendas = int.Parse(Console.ReadLine());
            comissaoTaxa = valorTotalVendas * 0.05;
            if (valorTotalVendas < 0)
            {
                Console.WriteLine("Digite uma quantidade valida de vendas!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }


            salarioFinal = salarioBase + comissaoTaxa + comissionamento;
            Console.WriteLine($"seu salário atual está girando em torno de: {salarioFinal}");
            Console.ReadKey();
        }
        void exercicio4()
        {
            /*  Escreva um algoritmo para ler as dimensões de um retângulo(base e altura), calcular e
               escrever a área do retângulo.A área do é a base X altura.
           */

            int fundo, altura, area;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("----------- Calculadora de área de retangulos -----------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digute a base em cm:");
            fundo = int.Parse(Console.ReadLine());
            if (fundo < 0)
            {
                Console.WriteLine("Digite uma quantidade valida de tamanho!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Digite a altura em cm:");
            altura = int.Parse(Console.ReadLine());
            if (altura < 0)
            {
                Console.WriteLine("Digite uma quantidade de tamanho!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            area = fundo * altura;

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine($"A área total do retângulo corresponde a {area}cm!");

            Console.ReadKey();


        }
        void exercicio5()
        {
            /*
        Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu
       antecessor
    */

            int numero, antecessor;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------- Mágia negra ----------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite um número:");
            numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            antecessor = numero - 1;

            Console.WriteLine($"O número {numero} tem como seu antecessor o número : {antecessor}!!");
            Console.ReadKey();
        }
        void exercicio6()
        {
            /*
            *  Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e
               escrever o valor correspondente em graus Celsius (baseado na fórmula abaixo): 
            */
            double Fahrenheit, celsius;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------- Clima tempo ----------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite a temperatura atual em Fahrenheit:");
            Fahrenheit = int.Parse(Console.ReadLine());
            if (Fahrenheit < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            celsius = (Fahrenheit - 32) / 1.8;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Estão fazendo {Fahrenheit}ºF ou {celsius}ºC !! ");
            Console.ReadKey();

        }
        void exercicio7()
        {
            /*
          *  As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se
             forem compradas pelo menos 12. Escreva um programa que leia o número de maçãs
             compradas, calcule e escreva o custo total da compra.
         */
            double qtdeMacas, custoTotal;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------- Tropa da maçã --------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Quantas maçãs foram compradas?");
            qtdeMacas = int.Parse(Console.ReadLine());
            if (qtdeMacas < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            if (qtdeMacas < 12)
            {
                custoTotal = qtdeMacas * 1.30;
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Total da compra: R${custoTotal}");
                Console.ReadKey();
                return;

            }
            else
            {
                custoTotal = qtdeMacas * 1;
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Total da compra: R${custoTotal}");
                Console.ReadKey();
                return;
            }

        }
        void exercicio8()
        {
            /*
      * Ler dois valores (considere que não serão lidos valores iguais) e escrever o maior deles.
     */

            int numero1, numero2;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------- Maior Numero? --------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite o numero 1:");
            numero1 = int.Parse(Console.ReadLine());
            if (numero1 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Digite o numero 2:");
            numero2 = int.Parse(Console.ReadLine());
            if (numero2 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            if (numero1 > numero2)
            {
                Console.WriteLine($"O numero maior é o numero1: {numero1}");
                Console.ReadKey();
            }

            else if (numero1 < numero2)
            {
                Console.WriteLine($"O numero maior é o numero2: {numero2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("numeros inválidos, digite numeros diferentes !!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

        }
        void exercicio9()
        {
            /*
          Ler dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem
          crescente.
       */
            int numero1, numero2;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("--------------------- Ordem crescente -------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite o numero 1:");
            numero1 = int.Parse(Console.ReadLine());
            if (numero1 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Digite o numero 2:");
            numero2 = int.Parse(Console.ReadLine());
            if (numero2 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }


            if (numero1 > numero2)
            {
                Console.WriteLine($"Em ordem crescente: {numero1}, {numero2}");
                Console.ReadKey();
            }

            else if (numero1 < numero2)
            {
                Console.WriteLine($"Em ordem crescente: {numero2}, {numero1}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("numeros inválidos, digite numeros diferentes !!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
        }
        void exercicio10()
        {
            /*
          Ler 3 valores (considere que não serão informados valores iguais) e escrever a soma
          dos 2 maiores.
       */
            int numero1, numero2, numero3, soma;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-------------------- Soma dos maiores -------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite o numero 1:");
            numero1 = int.Parse(Console.ReadLine());
            if (numero1 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Digite o numero 2:");
            numero2 = int.Parse(Console.ReadLine());
            if (numero2 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }


            Console.WriteLine("Digite o numero 3:");
            numero3 = int.Parse(Console.ReadLine());
            if (numero3 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }


            if (numero1 < numero2)
            {
                if (numero2 < 3)
                {
                    soma = numero2 + numero3;
                    Console.WriteLine($"A soma dos dois maiores resulta no número: {soma}");
                    Console.ReadKey();

                }


            }
            else if (numero2 < 3)
            {
                if (numero2 < numero3)
                {
                    soma = numero1 + numero3;
                    Console.WriteLine($"A soma dos dois maiores resulta no número: {soma}");
                    Console.ReadKey();
                }

            }
            else
            {
                if (numero1 < numero2)
                {
                    soma = numero1 + numero2;
                    Console.WriteLine($"A soma dos dois maiores resulta no número: {soma}");
                    Console.ReadKey();
                }

            }
        }
        void exercicio11()
        {
            /*
                        *  Ler 3 valores (considere que não serão informados valores iguais) e escrevê-los em
                           ordem crescente.
                        */
            int numero1, numero2, numero3;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("--------------------- Ordem crescente -------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite o numero 1:");
            numero1 = int.Parse(Console.ReadLine());
            if (numero1 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Digite o numero 2:");
            numero2 = int.Parse(Console.ReadLine());
            if (numero2 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Digite o numero 3:");
            numero3 = int.Parse(Console.ReadLine());
            if (numero3 < 0)
            {
                Console.WriteLine("Digite um número válido!!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }


            if (numero1 > numero2 && numero2 > numero3)
            {
                Console.WriteLine($"Em ordem crescente: {numero1}, {numero2}");
                Console.ReadKey();
            }

            else if (numero1 < numero2 && numero3 > numero1)
            {
                Console.WriteLine($"Em ordem crescente: {numero2}, {numero3}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Em ordem crescente: {numero1}, {numero3}");
                Console.ReadKey();
            }
        }
        void exercicio12()
        {
            int x, y, z;
            string resposta;
            Console.WriteLine("Digite o valor de X:");
            x = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor de y:");
            y = int.Parse(Console.ReadLine());


            z = (x * y) + 5;
            if (z < 0)
            {
                resposta = "A";
                Console.WriteLine($"Resposta {resposta}!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            else if (z <= 100)
            {
                resposta = "B";
                Console.WriteLine($"Resposta {resposta}!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            else
            {
                resposta = "c";
                Console.WriteLine($"Resposta {resposta}!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
        }
        void exercicio13()
        {
            int numero = 8;
            int tabuada;
            for (int i = 1; i < 11; i++)
            {
                tabuada = numero * i;
                Console.WriteLine($" do 8 x {i} = {tabuada}!");
            }

            Console.ReadKey();
        }
    }
}

