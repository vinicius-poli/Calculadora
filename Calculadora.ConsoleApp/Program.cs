

bool  deveContinuar = true;

while (deveContinuar == true)
{
    //Concole.Clear();

    Console.WriteLine("-------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("-------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("S - Sair");

    Console.Write("Selecione uma opção válida: ");
    string operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;

        continue; // obriga o loop a voltar ao começo (começo do while)
    }


    Console.Write("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.Write("Digite o segundo número: ");
    string strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

    Console.WriteLine();

    // int = numero inteiro
    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado;

    if (operacaoSelecionada == "1")
    {
        resultado = primeiroNumero + segundoNumero;
    }

    else if (operacaoSelecionada == "2")
    {
        resultado = primeiroNumero - segundoNumero;
    }

    else if (operacaoSelecionada == "3")
    {
        resultado = primeiroNumero * segundoNumero;
    }

    else
    {
        if (segundoNumero == 0)
        {
        Console.WriteLine("Não é possível fazer uma divisão por zero. Tente novamente.");  

        return; 

        }
        resultado = primeiroNumero / segundoNumero;
        
    }

    Console.WriteLine("A soma dos dois números resulta em: " + resultado);

    Console.ReadLine();
}

