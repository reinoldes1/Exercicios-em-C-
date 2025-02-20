class Program
{
    static string nome;
    static int idade;
    static double altura;
    static int peso;
    static double IMC;

    static void pegaNome() 
    {
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome cadastrado!");
    }

    static void pegaIdade() 
    {
        
        while (true)
        {
            Console.Write("Digite a sua idade: ");
            if (int.TryParse(Console.ReadLine(), out idade))
                break;
            Thread.Sleep(1200);
            Console.WriteLine("Valor incorreto. Digite sua idade novamente por exemplo: 25");
            Thread.Sleep(1000);

        }
        Console.WriteLine("Idade cadastrada!");
    }

    static void pegaAltura()
    {
        while (true)
        {
            Console.Write("Digite a sua altura: ");
            if (double.TryParse(Console.ReadLine(), out altura))
                break;
            Thread.Sleep(1200);
            Console.WriteLine("Valor incorreto. Digite sua altura novamente por exemplo: 1.70");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Altura cadastrada!");
    }

    static void pegaPeso()
    {
        while (true)
        {
            Console.Write("Digite o seu peso: ");
            if (int.TryParse(Console.ReadLine(), out peso))
                break;
            Thread.Sleep(1200);
            Console.WriteLine("Valor incorreto. Digite seu peso novamente por exemplo: 70");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Peso cadastrado!");
    }

    static void calculaIMC()
    {
        IMC = peso / (altura * altura);
    }

    static void Main()
    {
        pegaNome();
        pegaIdade();
        pegaAltura();
        pegaPeso();
        calculaIMC();
        Console.WriteLine("Pegando a suas informações...");
        Thread.Sleep(1000);
        Console.WriteLine("Calculando o seu IMC...");
        Thread.Sleep(1000);
        Console.WriteLine($"O seu nome é {nome}, você tem {idade} anos e {altura:f2}m de altura!");
        Console.WriteLine($"O seu IMC é {IMC:f2}");
        if (IMC <= 18.5)
        {
            Console.WriteLine("Você está abaixo do peso");
        }
        else if (IMC >= 18.6 && IMC <= 24.9)
        {
            Console.WriteLine("Você está no peso ideal!");
        }
        else if (IMC >= 25.0 && IMC <= 29.9)
        {
            Console.WriteLine("Você está no sobrepeso");
        }
        else if (IMC >= 30.0 && IMC <= 34.9)
        {
            Console.WriteLine("Você está na obesidade grau I");
        }
        else if (IMC >= 35.0 && IMC <= 39.9)
        {
            Console.WriteLine("Você está na obesidade grau II");
        }
        else if (IMC >= 40)
        {
            Console.WriteLine("Você está na obesidade grau II");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}