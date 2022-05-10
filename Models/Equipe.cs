using E_JOGOS.Interface;
using EJOGOS.Models;

namespace E_JOGOS.Models
{
    //: Herança
    //, Interface (contrato da classe)
    public class Equipe : EquipeBase, IEquipe
    {
        public int idEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        // variavel de dados.
        private const string caminhobd = "Database/equipe.csv";

        public Equipe()//construtor
        {
            //metodo da classe de herança do EquipeBase
            CriarPastaOuArquivo(caminhobd);

        }

        private static string Preparar(Equipe e)
        {
            //return e.idEquipe + ";" + e.Nome + ";" + e.Imagem;
            return $"{e.idEquipe}; {e.Nome}; {e.Imagem}";
        }

        public void Criar(Equipe novaequipe)
        {
           // throw new NotImplementedException();
           // array de strings = na posição 0 temos o retorno do Preparar
            string[] equipe_texto = {Preparar(novaequipe)};
            //arquivo vamos adicionar uma nova linha
            //caminho do arquivo, string em formato array
            File.AppendAllLines(caminhobd, equipe_texto);            


        }

        public List<Equipe> LerEquipes()
        {
           // throw new NotImplementedException();
           List<Equipe> listaEquipes = new List<Equipe>();
            //ler todas as linhas do arquivo csv, armazenar em um array;
            string[] linhas = File.ReadAllLines(caminhobd);
            
            foreach (string item in linhas)
            {
                // 1 ; nome da equipe; caminho da imagem
                string[] linhaEquipe = item.Split(';');
                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);

            }
            return listaEquipes;

        }
    }
}
