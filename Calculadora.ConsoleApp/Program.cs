string[] historicoOperacoes = new string[100];
int totalOperacoes = 0;

bool  deveContinuar = true;

while (deveContinuar == true)
{
    Console.Clear();

    Console.WriteLine("-------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("-------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico");
    Console.WriteLine("S - Sair");

    Console.Write("Selecione uma opção válida: ");
    string? operacaoSelecionada = Console.ReadLine().ToUpper();

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;

        continue; // obriga o loop a voltar ao começo (começo do while)
    }

    else if (
        operacaoSelecionada != "1" && 
        operacaoSelecionada != "2" &&
        operacaoSelecionada != "3" && 
        operacaoSelecionada != "4" &&
        operacaoSelecionada != "5" &&
        operacaoSelecionada != "6")
    {
        Console.WriteLine("Opção Inválida");
        Console.ReadLine();
        continue;
    }

    //Logica da Tabuada
   else  if (operacaoSelecionada == "5")
    {
        Console.Write("Digite o número que deseja gerar a tabuada: ");

        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        for (int contador = 1; contador <= 10; contador += 1)
        {
            int resultadoTabuada = numeroTabuada * contador;

            string operacaoTabuada = numeroTabuada + " x " + contador + " = " + resultadoTabuada;
            
            Console.WriteLine(operacaoTabuada);
        }

        Console.ReadLine();

        continue;
    }

    else if (operacaoSelecionada == "6")
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Histórico de Operações");
        Console.WriteLine("--------------------------------");

        if (totalOperacoes == 0)
        {
            Console.WriteLine("Nenhuma operação registrada ainda.");
        }
        else
        {
            for (int i = 0; i < totalOperacoes; i++)
            {
                Console.WriteLine(historicoOperacoes[i]);
            }
        }

        Console.ReadLine();
        continue;
    }
    
    //Logica da operações de cálculo

    Console.Write("Digite o primeiro número: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.Write("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if(string.IsNullOrEmpty(strPrimeiroNumero))

    if (primeiroNumeroVazio || segundoNumeroVazio)
    {
        Console.WriteLine("Digite um número válido!");
        Console.ReadLine();
        
        continue;
    }

    // decimal
    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado = 0;
    string operacaoTexto = "";

    switch (operacaoSelecionada)
    {
        case "1":            
            
            resultado = resultado = primeiroNumero + segundoNumero;
            operacaoTexto = primeiroNumero + " + " + segundoNumero + " = " + resultado;
            break;

        case "2":
            
            resultado = resultado = primeiroNumero - segundoNumero;
            operacaoTexto = primeiroNumero + " - " + segundoNumero + " = " + resultado;
            break;

        case "3":
            
            resultado = resultado = primeiroNumero * segundoNumero;
            operacaoTexto = primeiroNumero + " x " + segundoNumero + " = " + resultado;
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
                operacaoTexto = primeiroNumero + " / " + segundoNumero + " = " + resultado;
                break;
            }
        
        default:
        Console.WriteLine("Opção inválida!");
		Console.ReadLine();
        continue; 
    }   

    //Salvar no histórico

    if (totalOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[totalOperacoes] = operacaoTexto;
        totalOperacoes++;
    } 
    
    Console.WriteLine("Resultado: " + resultado);

    Console.ReadLine();
}

