using System;

namespace Calcular_salario_liquido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos trabalhadores vai inserir?");
            int numtrab = Convert.ToInt32(Console.ReadLine());
            Empresa empresa = new Empresa("Empresa");
            empresa.Lista = new Trabalhador[numtrab];

            for (int contador = 0; contador < numtrab; contador++)
            {
                int nif, dependentes, titulares;
                double salario;
                string nome;
                bool defeciencia;

                Console.WriteLine("Escreva o nome completo do trabalhador "+(contador + 1) + " :");
                nome = Console.ReadLine();

                Console.WriteLine("Escreva o nif do trabalhador " + (contador + 1) + " :");
                while (true)
                {
                    string num = Console.ReadLine();
                    bool repetido = false;
                    if (num.Length == 9)
                    {
                        for(int i = contador - 1 ; i >= 0; i--)
                        {
                            if (empresa.Lista[i].Nif == Convert.ToInt32(num))
                            {
                                Console.WriteLine("O nif ja existe!");
                                repetido = true;
                            }
                        }
                        if (!repetido)
                        {
                            nif = Convert.ToInt32(num);
                            break;
                        }
                        
                    }
                    Console.WriteLine("O nif deve ter 9 números!");
                }


                Console.WriteLine("Escreva o numero de dependentes do trabalhador " + (contador + 1) + " :");
                while (true)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num >= 0)
                    {
                        dependentes = num;
                        break;
                    }
                    Console.WriteLine("O número não deve ");
                }


                Console.WriteLine("O trabalhador " + (contador + 1) + " tem defeciencia? (Sim / Não)");
                while (true)
                {
                    string aux = Console.ReadLine();
                    if (aux == "N" || aux == "n" || aux == "Nao" || aux == "nao")
                    {
                        defeciencia = false;
                        break;
                    }
                    else if (aux == "S" || aux == "s" || aux == "Sim" || aux == "sim")
                    {
                        defeciencia = true;
                        Console.WriteLine("O programa não está preparado para trabalhadores com defeciencia!");
                    }
                    else
                    {
                        Console.WriteLine("Deve responder com sim ou não!");
                    }
                }

                Console.WriteLine("Escreva o numero de titulares do formulario do trabalhador " + (contador + 1) + " :");
                while (true)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 2)
                    {
                        titulares = num;
                        break;
                    }
                    Console.WriteLine("O programa não está preparado para menos de 2 titulares!");
                }

                Console.WriteLine("Escreva o salário do trabalhador " + (contador + 1) + " :");
                while (true)
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    if (num > 0)
                    {
                        salario = num;
                        break;
                    }
                    Console.WriteLine("O salário deve ser positivo!");
                }

                Trabalhador trabalhador = new Trabalhador(nome, nif, dependentes, defeciencia, titulares, salario);
                SalarioLiquido salariotrabalhador = new SalarioLiquido(trabalhador);
                trabalhador.Salarioliq = Math.Round(salariotrabalhador.CalcularSalario(),2);
                Console.WriteLine("O salário líquido do trabalhador " + (contador + 1) + " é:" + (trabalhador.Salarioliq) + " euros");
                empresa.Lista[contador] = trabalhador;
            }
            string estrutura = "Nome | Nif | Dependentes | Defeciencia | Titulares | Salario Base | Salario Liquido";
            Console.WriteLine("Lista de trabalhadores:");
            Console.WriteLine(estrutura);
            for (int cenas = 0; cenas < empresa.Lista.Length; cenas++)
            {
                Console.WriteLine(empresa.Lista[cenas]);
            }
            Console.WriteLine("Deseja ordenar a lista por nomes ou dependentes (a/b)");
            while (true)
            {
                string resposta = Console.ReadLine();
                if(resposta == "c" || resposta == "C")
                {
                    for (int cenas = 0; cenas < empresa.Lista.Length; cenas++)
                    {
                        Console.WriteLine(empresa.Lista[cenas]);
                    }
                }
                if (resposta == "a" || resposta == "A")
                {
                    Console.WriteLine(estrutura);
                    for (int cenas = 0; cenas < empresa.Lista.Length; cenas++)
                    {
                        Console.WriteLine(empresa.OrdenarNomes()[cenas]);
                    }
                }
                else if (resposta == "b"|| resposta == "B")
                {
                    Console.WriteLine(estrutura);
                    for (int cenas = 0; cenas < empresa.Lista.Length; cenas++)
                    {
                        Console.WriteLine(empresa.OrdenarDependentes()[cenas]);
                    }
                }
                else
                {
                    Console.WriteLine("Deve selecionar a(ordenar por nomes), ou b(ordenar por dependentes)");
                }
            }
        }
    }
}
