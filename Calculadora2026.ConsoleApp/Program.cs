/*REQUISITOS
1. Nossa calculadora deve ter a possibilidade de somar dois números [x]
2. Nossa calculadora deve ter a possibilidade de subtrair dois números [x]
3. Nossa calculadora deve ter a possibilidade de multiplicar dois números [x]
4. Nossa calculadora deve ter a possibilidade de dividir dois números [x]
5. A calculadora deve ter a possibilidade de executar operações em continuidade [x]

versão 2
1. Nossa calculadora deve produzir uma tabuada do número informado [x]
2. A calculadora deve armazenar um histórico de operações anteriores [x]
*/
bool deveContinuarExecutando = true;

string[] operacoes = new string[100]; //array de strings de 3 posições
int contadorOp = 0;

while (deveContinuarExecutando)
{
    Console.Clear();

    Console.WriteLine("-------------------------------");
    Console.WriteLine("Calculadora - Semana 2 - 2026");
    Console.WriteLine("-------------------------------");

    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico de Operações");
    Console.WriteLine("S - Sair");
    Console.WriteLine("-------------------------------");
    Console.Write("Escolha uma opção válida: ");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        deveContinuarExecutando = false;
        break; //só existe dentro de loop como o continue, break encerraria o loop
        //continue; //volta para o início do loop linha 10 nesse caso
        //return; //fecha o programa, vai para a última linha, roda fora de loops também
    }

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("Digite uma opção válida!");
        Console.ReadLine();
        continue;
    }

    if (opcao == "5")
    {
        Console.Clear();
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Função Tabuada...");
        Console.WriteLine("-------------------------------");
        Console.Write("Digite um número inteiro: ");
        string strNumeroDigitado = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

        for (int i = 1; i <= 10; i++)
        {
            //string linhaTabuada = numeroDigitado + " x " + i + " = " + numeroDigitado * i;
            string linhaTabuada = $"{numeroDigitado} x {i} = {numeroDigitado * i}";
            Console.WriteLine(linhaTabuada);
        }
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Pressione Enter para voltar ao menu inicial!");
        Console.ReadLine();
        continue;
    }

    if (opcao == "6")
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Histórico de operações...");
        Console.WriteLine("-------------------------------");

        for (int i = 0; i < operacoes.Length; i++)
        {
            if (operacoes[i] != null) //se não estiver vazia
            {
                Console.WriteLine(operacoes[i]);
            }
        }
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Pressione Enter para voltar ao menu inicial!");
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine();
    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);

    Console.Write("Digite o segundo número: ");
    string strSegundoNumero = Console.ReadLine();
    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado = 0;
    string textoOperacao = "";

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }

    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
    }

    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
    }

    else if (opcao == "4")
    {
        resultado = primeiroNumero / segundoNumero;
        textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
    }

    operacoes[contadorOp] = textoOperacao;
    contadorOp++;

    Console.WriteLine("O resultado é: " + resultado);
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Pressione Enter para voltar ao menu inicial!");

    Console.ReadLine();
}


