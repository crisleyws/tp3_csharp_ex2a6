using tp3_csharp_ex2a6;

public class Program
{
    public static void Main()
    {
        Ingresso ingresso = new Ingresso();
        ingresso.NomeDoShow = "Show do C#";
        ingresso.Preco = (150.50);
        ingresso.QuantidadeDisponivel = (800);
        ingresso.ExibirIngresso();

        Console.WriteLine();
        Console.WriteLine("atualizado");
        Console.WriteLine();

        ingresso.AtualizarPreco(100);
        ingresso.AtualizarQuantidade(1000);
        ingresso.ExibirIngresso();

        Console.WriteLine();
        Console.WriteLine("Usando get e set");
        Console.WriteLine();

        Ingresso ingresso2 = new Ingresso();
        ingresso2.SetNomeDoShow("Show do C# com get e set");
        ingresso2.SetPreco(150.50);
        ingresso2.SetQuantidadeDisponivel(800);
        ingresso2.ExibirIngresso();

        Console.WriteLine();
        Console.WriteLine("atualizado com get e set");
        Console.WriteLine();

        ingresso2.SetPreco(180.0);
        ingresso2.SetQuantidadeDisponivel(650);
        ingresso2.ExibirIngressoGet();
    }
}