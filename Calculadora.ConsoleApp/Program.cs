

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
    string operacaoSelecionada = Console.ReadLine().ToUpper();

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;

        continue; // obriga o loop a voltar ao começo (começo do while)
    }

    else if (
        operacaoSelecionada != "1" && 
        operacaoSelecionada != "2" &&
        operacaoSelecionada != "3" && 
        operacaoSelecionada != "4")
    {
        Console.WriteLine("Opção Inválida");
        Console.ReadLine();
        continue;
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

    // decimal
    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado = 0;

    switch (operacaoSelecionada)
    {
        case "1":            
            
            resultado = resultado = primeiroNumero + segundoNumero;
            break;

        case "2":
            
            resultado = resultado = primeiroNumero - segundoNumero;
            break;

        case "3":
            
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
                resultado = primeiroNumero / segundoNumero;
                break;
            }
        
        default:
        Console.WriteLine("Opção inválida!");
		Console.ReadLine();
        return; 
    }    
    
    Console.WriteLine("Resultado: " + resultado);

    Console.ReadLine();
}

