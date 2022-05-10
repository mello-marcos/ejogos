using E_JOGOS.Models;

namespace E_JOGOS.Interface
{
    public interface IEquipe
    {
        //Contrato
        //Representa os métodos que são obrigatórios em uma classe
        void Criar(Equipe novaequipe);

        List<Equipe> LerEquipes();


    }
}
