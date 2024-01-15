menu();

void menu()
{
    Console.WriteLine("***********************************************");
    Console.WriteLine("**        CALCULADORA MEGA ULTRA 2.0         **");
    Console.WriteLine("***********************************************");
    Console.WriteLine("**   Seja bem vindos amigos do ACELERA.NET   **");
    Console.WriteLine("***********************************************");
    int opcao;

    do
    {
        Console.WriteLine("\nEscolha o calculo que deseja: \n");

        Console.WriteLine("1 - CALCULAR MÉDIA DE NOTAS");
        Console.WriteLine("2 - CALCULAR IMC");
        Console.WriteLine("3 - SAIR\n");
        Console.Write("Opção: ");

        opcao = (Convert.ToInt32(Console.ReadLine()));

        switch (opcao)
        {
            case 1:
                calculaMedia();
                break;
            case 2:
                calculaIMC();
                break;
            case 3:
                Console.Write("Até mais!\n");
                break;
            default:
                Console.Write("Opção inválida!\n");
                break;
        }

    } while (opcao != 3);
}


void calculaIMC()
{
    Console.Write("Digite o nome: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o peso (kg): ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a altura (cm): ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a idade: ");
    double idade = Convert.ToDouble(Console.ReadLine());

    double IMC = 0;

    altura /= 100;
    IMC = peso / (altura * altura);

    Console.WriteLine("\nO IMC de {0} é: " + IMC.ToString("F"), nome);

    Console.WriteLine("Classificação: " + classificaIMC(IMC));
}

string classificaIMC(double IMC)
{
    string classificacao = "";

    if (IMC < 18.5)
        classificacao = "MAGREZA";
    else if (IMC < 24.9)
        classificacao = "NORMAL";
    else if (IMC < 29.9)
        classificacao = "SOBREPESO";
    else if (IMC < 39.9)
        classificacao = "OBESIDADE";
    else if (IMC > 40)
        classificacao = "OBESIDADE GRAVE";

    return classificacao;
}

void calculaMedia()
{
    double[] notas = new double[3];
    Console.WriteLine("Digite a primeira nota:");
    notas[0] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite a segunda nota:");
    notas[1] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite a terceira nota:");
    notas[2] = Convert.ToDouble(Console.ReadLine());

    double media = (notas[0] + notas[1] + notas[2]) / 3;

    Console.WriteLine("\nO aluno foi " + verificaAprovacao(media));

    Console.WriteLine("Média: " + media.ToString("F"));
}

string verificaAprovacao(double media)
{
    string resultado = "";
    if (media < 5)
        resultado = "REPROVADO";
    else if (media < 7)
        resultado = "RECUPERAÇÃO";
    else if (media >= 7)
        resultado = "APROVADO";

    return (resultado);
}