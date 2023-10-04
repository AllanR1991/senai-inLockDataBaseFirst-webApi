using Microsoft.EntityFrameworkCore;
using senai_inLockDataBaseFirst_webApi.Contexts;
using senai_inLockDataBaseFirst_webApi.Domains;
using senai_inLockDataBaseFirst_webApi.Interfaces;

namespace senai_inLockDataBaseFirst_webApi.Repositories
{
    /// <summary>
    /// Classe responsavel pelo repositorio dos Estudios
    /// </summary>
    public class EstudioRepository : IEstudioRepository
    {
        /// <summary>
        /// Instanciando Objeto ctx do tipo InLockContext por onde serão chamados os métodos do EF Core.
        /// </summary>
        InLockContext ctx = new InLockContext();


        /// <summary>
        /// Atualiza um estúdio existente
        /// </summary>
        /// <param name="id">ID do estudio que sera atualizado</param>
        /// <param name="estudioAtualizado">Objeto do tipo Estudio contendo os dados alterados</param>
        public void Atualizar(int id, Estudio estudioAtualizado)
        {
            // Busca um estúdio através do id
            Estudio estudioBuscado = ctx.Estudios.Find(id);

            // Verifica se o nome do estúdio foi informado
            if (estudioAtualizado.NomeEstudio != null)
            {
                // Atribui os novos valoes aos campos existentes
                estudioBuscado.NomeEstudio = estudioAtualizado.NomeEstudio;
            }

            // Atualiza o estúdio que foi buscado
            ctx.Estudios.Update(estudioBuscado);

            //Salva as informações para serem gravadas no banco de dados.
            ctx.SaveChanges();
        }

        /// <summary>
        /// Busca um estúdio através do seu ID
        /// </summary>
        /// <param name="id">Id do estudio que será buscado</param>
        /// <returns>Um estudio buscado</returns>
        public Estudio BuscarPorID(int id)
        {
            // Retorna o primeiro esstudio encontrado para o ID informado
                                               // O lambda cria um objeto da entidade Estudio                         
            return ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id);
        }

        /// <summary>
        /// Cadastra um novo estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto do tipo Estudio com as novas informações</param>
        public void Cadastrar(Estudio novoEstudio)
        {
            // Adiciona este novoEstudio
            ctx.Estudios.Add(novoEstudio);

            //Salva as informações para serem gravadas no banco de dados.
            ctx.SaveChanges();

        }


        /// <summary>
        /// Deleta um estudio existente
        /// </summary>
        /// <param name="id">Id do estudio que será Deletado.</param>
        public void Deletar(int id)
        {
            // Busca um estudio atraves do seu id
            Estudio estucioBuscado = ctx.Estudios.Find(id);

            // Remode o estudio encontado
            ctx.Estudios.Remove(estucioBuscado);

            //Salva a informação
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Lista de estúdio</returns>
        public List<Estudio> Listar()
        {
            return ctx.Estudios.ToList();
        }

        /// <summary>
        /// Listas todos os estudios com os seus respectivos jogos.
        /// </summary>
        /// <returns>Lista de estudios com seus jogos</returns>
        public List<Estudio> ListarJogos()
        {
            // Retorna uma lista de estudios com seus jogos.
            return ctx.Estudios.Include(e => e.Jogos).ToList();
        }
    }
}
