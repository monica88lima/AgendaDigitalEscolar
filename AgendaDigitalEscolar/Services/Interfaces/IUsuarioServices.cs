
using Repositorios.Interfaces;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUsuarioServices
    {

        bool Login(string email, string password);


        UsuarioDto CadastrarUsuario(UsuarioDto usuario);


        bool ValidarEmailUnico(string email);


        bool RedefinirSenha(string email, string password);
      
    }
}
