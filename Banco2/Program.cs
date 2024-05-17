
double saldo = 0, valor = 0, saque;

var senha = 12345;

VerificadorDeSenha();

void Menu()
{

    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkGreen;

    Console.Clear();
    Console.WriteLine("***********************");
    Console.WriteLine("[1] - Consultar Saldo");
    Console.WriteLine("[2] - Depositar      ");
    Console.WriteLine("[3] - Sacar          ");
    Console.WriteLine("[4] - Sair           ");
    Console.WriteLine("\n**********************");

    Console.Write("\nInforme a opção desejada: ");
    byte res = byte.Parse(Console.ReadLine()!);

        switch (res)
        {
            case 1: ConsultarSaldo(); break;
            case 2: Depositar(); break;
            case 3: Sacar(); break;
            case 4: Sair(); break;
            default: Console.WriteLine("Opção Invalida!"); Thread.Sleep(1000); Menu(); break;
        }
}
void ConsultarSaldo()
{
    Console.WriteLine($"\nO saldo atual é: {saldo}\n");
    Thread.Sleep(3000);
    Menu();

}
void Depositar()
{

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("\nInforme o valor para depósito: ");
    valor = double.Parse(Console.ReadLine()!);  

    if (valor != 0)
    {        
        saldo += valor;
        Console.WriteLine($"\nSeu novo saldo é: {saldo}\n");
        Thread.Sleep(3000);
        Menu();
    }
    else
    {
        Console.WriteLine("\nInforme um valor para depósito válido!\n");
        Depositar();
    }
}
void Sacar()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;

    Console.Write("\nInforme o valor para sacar: ");
    saque = double.Parse(Console.ReadLine()!);

    if (saldo >= saque)
    {
        saldo -= saque;
        Console.WriteLine($"\nSeu novo saldo é: {saldo}\n");
    }
    else
    {
        Console.WriteLine($"\nSaldo indisponível, seu saldo atual é: {saldo}\n");
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
        Console.Write("Digite a senha: ");
        int senhaDigitada = int.Parse(Console.ReadLine()!);

        if (senhaDigitada == senha)
        {
            Console.WriteLine("Senha correta!");
            Menu();

        }
    }

 Console.WriteLine("Senha bloqueada! Para sua segurança, dirija-se à um atendente para cadastrar uma nova senha.");
 Sair();
}


