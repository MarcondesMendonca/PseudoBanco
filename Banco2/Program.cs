double saldo = 0, valor = 0, saque;

var senha = 1234;

VerificadorDeSenha();

void Menu()
{

    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkGreen;

    Console.Clear();

    Console.WriteLine(@"
************************
[1] - Consultar Saldo  * 
[2] - Depositar        *
[3] - Sacar            *
[4] - Sair             *
                       *
************************");

    Console.Write("\nInforme a opção desejada: ");

    try
    {
    int res = int.Parse(Console.ReadLine()!);

        switch (res)
        {
            case 1: ConsultarSaldo(); break;
            case 2: Depositar(); break;
            case 3: Sacar(); break;
            case 4: Sair(); break;
            default: Console.WriteLine("Opção Invalida!"); Thread.Sleep(1000); Menu(); break;
        }

    } catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.WriteLine("Opção Invalida, informe um número de 1 a 4!");
        Thread.Sleep(2000);
        Menu();
    }
}
void ConsultarSaldo()
{
    Console.WriteLine($"\nO saldo atual é: {saldo:C}\n");
    Thread.Sleep(3000);
    Menu();
}
void Depositar()
{

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.White;

    Console.Write("\nInforme o valor para depósito: R$ ");
    valor = double.Parse(Console.ReadLine()!);

    if (valor != 0 && valor > 0)
    {
        saldo += valor;
        Console.WriteLine($"\nSeu novo saldo é: {saldo:C}\n");
        Thread.Sleep(3000);
        Menu();

    } else {

        Console.WriteLine("\nInforme um valor para depósito válido!\n");
        Depositar();
    }
}
void Sacar()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.BackgroundColor = ConsoleColor.White;

    Console.Write("\nInforme o valor para sacar: R$ ");
    saque = double.Parse(Console.ReadLine()!);

    if (saldo >= saque && saque != 0)
    {
        saldo -= saque;
        Console.WriteLine($"\nSeu novo saldo é: {saldo:C}\n");
    }

    else

    {
        Console.WriteLine($"\nValor invalido, seu saldo atual é: {saldo:C}\n");
    }

    Thread.Sleep(3000);
    Menu();
}
void Sair()
{
    Console.WriteLine("\nSaindo da aplicação...");
    Thread.Sleep(3000);
    Environment.Exit(0);
}
void VerificadorDeSenha()
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write("Informe a senha: ");

        try
        {
            int senhaDigitada = int.Parse(Console.ReadLine()!);

            if (senhaDigitada == senha)
            {
                Console.WriteLine("Senha correta!");
                Menu();
            }.
        }
        
        catch 
        
        {
            Console.WriteLine("Opção Invalida, informe uma senha de 4 dígitos!");
        }
    }

    Console.WriteLine("Senha bloqueada! Para sua segurança, dirija-se à um atendente para cadastrar uma nova senha.");
    Sair();
}


