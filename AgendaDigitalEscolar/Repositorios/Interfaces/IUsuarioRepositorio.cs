using Entidades;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        bool Login(string email, string password);

        bool CadastrarUsuario(Usuario usuario);

        bool ValidarEmailUnico(string email);

         bool RedefinirSenha(string email, string password);
        Usuario BuscaUsuarioEmail(string email);
        Usuario BuscaUsuarioID(int id);


    }
}
