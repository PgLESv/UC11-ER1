using ChapterFST1.Models;

namespace ChapterFST1.Interfaces
{
    public interface IUsuarioRepository
    {
        public List<Usuario> Listar();

        public Usuario BuscarPorId(int id);

        void Cadastrar(Usuario usuario);

        void Atualizar(int id, Usuario usuario);

        void Deletar(int id);

        Usuario Login(string email, string senha);
    }
}
