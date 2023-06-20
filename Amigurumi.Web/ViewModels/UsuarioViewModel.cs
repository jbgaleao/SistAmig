using System;

namespace Amigurumi.Web.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }= DateTime.Now;

    }
}