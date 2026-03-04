

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

    
    // decimal
    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado = 0;

    switch (operacaoSelecionada)
    {
        case "1":
            Console.WriteLine("O primeiro número digitado foi: " + primeiroNumero);
            Console.WriteLine("O segundo número digitado foi: " + segundoNumero);

            Console.WriteLine();
            resultado = resultado = primeiroNumero + segundoNumero;
            break;

        case "2":
            Console.WriteLine("O primeiro número digitado foi: " + primeiroNumero);
            Console.WriteLine("O segundo número digitado foi: " + segundoNumero);

            Console.WriteLine();
            resultado = resultado = primeiroNumero - segundoNumero;
            break;

        case "3":
            Console.WriteLine("O primeiro número digitado foi: " + primeiroNumero);
            Console.WriteLine("O segundo número digitado foi: " + segundoNumero);

            Console.WriteLine();
            resultado = resultado = primeiroNumero * segundoNumero;
            break;

        case "4":
            if (segundoNumero == 0)
            {                
                Console.WriteLine("Não é possível fazer uma divisão por zero. Tente novamente.");
                return; 
            } 

            else
            {
                Console.WriteLine("O primeiro número digitado foi: " + primeiroNumero);
                Console.WriteLine("O segundo número digitado foi: " + segundoNumero);

                Console.WriteLine();
                resultado = primeiroNumero / segundoNumero;
                break;
            }
        
        default:
        Console.WriteLine("Opção inválida!");
		Console.ReadLine();
        return;

    

    }    
    

    Console.WriteLine("A soma dos dois números resulta em: " + resultado);

    Console.ReadLine();
}

