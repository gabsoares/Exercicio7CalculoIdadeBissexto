namespace Exercicio7CalculoIdadeBissexto
{
    internal class Pessoa
    {
        string nome;
        int idade;
        string profissao;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public string getProfissao()
        {
            return profissao;
        }

        public string getIdadeBissexto()
        {
            int idade, anoBissexto = 0;
            int anoAtual = DateTime.Now.Year;
            Console.Write("Digite o ano de seu nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNascimento;

            for (int i = anoNascimento; i < anoAtual; i++)
            {
                if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    anoBissexto++;
                }
            }
            return $"{idade}\nIdade em Bissexto: {anoBissexto}";
        }
        public override string? ToString()
        {
            return $"\nImpressão\n\nNome: {nome}\nIdade: {getIdadeBissexto()}\nProfissão: {profissao}";
        }
    }
}
