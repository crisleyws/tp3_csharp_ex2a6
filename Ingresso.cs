namespace tp3_csharp_ex2a6
{
    public class Ingresso
    {
        public string NomeDoShow;
        public double Preco;
        public int QuantidadeDisponivel;

        public string GetNomeDoShow()
        {
            return NomeDoShow;
        }

        public void SetNomeDoShow(string novoNome)
        {
            NomeDoShow = novoNome;
        }

        public double GetPreco()
        {
            return Preco;
        }

        public void SetPreco(double novoPreco)
        {
            Preco = novoPreco;
        }


        public int GetQuantidadeDisponivel()
        {
            return QuantidadeDisponivel;
        }

        public void SetQuantidadeDisponivel(int novaQuantidade)
        {
            QuantidadeDisponivel = novaQuantidade;
        }




        public void AtualizarPreco(double novoPreco)
        {
            Preco = novoPreco;
        }

        public void AtualizarQuantidade(int novaQuantidade)
        {
            QuantidadeDisponivel = novaQuantidade;
        }

        public void ExibirIngresso()
        {
            Console.WriteLine("Nome do show: " + NomeDoShow);
            Console.WriteLine("Preço: " + Preco);
            Console.WriteLine("Quantidade disponível: " + QuantidadeDisponivel);
        }

    }
}
