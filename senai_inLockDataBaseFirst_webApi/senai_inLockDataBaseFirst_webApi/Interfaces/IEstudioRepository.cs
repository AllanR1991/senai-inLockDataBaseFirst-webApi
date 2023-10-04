using senai_inLockDataBaseFirst_webApi.Domains;

namespace senai_inLockDataBaseFirst_webApi.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo EstudioRepository
    /// </summary>
    public interface IEstudioRepository
    {
        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Lista de estúdio</returns>
        List<Estudio> Listar();
        
        /// <summary>
        /// Busca um estúdio através do seu ID
        /// </summary>
        /// <param name="id">Id do estudio que será buscado</param>
        /// <returns>Um estudio buscado</returns>
        Estudio BuscarPorID(int id);

        /// <summary>
        /// Cadastra um novo estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto do tipo Estudio com as novas informações</param>
        void Cadastrar(Estudio novoEstudio);

        /// <summary>
        /// Atualiza um estúdio existente
        /// </summary>
        /// <param name="id">ID do estudio que sera atualizado</param>
        /// <param name="estudioAtualizado">Objeto do tipo Estudio contendo os dados alterados</param>
        void Atualizar(int id, Estudio estudioAtualizado);

        /// <summary>
        /// Deleta um estudio existente
        /// </summary>
        /// <param name="id">Id do estudio que será Deletado.</param>
        void Deletar(int id);

        /// <summary>
        /// Listas todos os estudios com os seus respectivos jogos.
        /// </summary>
        /// <returns>Lista de estudios com seus jogos</returns>
        List<Estudio> ListarJogos();
    }
}
