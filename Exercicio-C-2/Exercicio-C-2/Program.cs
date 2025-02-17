class Program
{

    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
           
        string mensagem = $"Olá, {nome + " " + sobrenome}! Seja muito bem-vindo!";
        
        Console.WriteLine(mensagem);
        
     }
}