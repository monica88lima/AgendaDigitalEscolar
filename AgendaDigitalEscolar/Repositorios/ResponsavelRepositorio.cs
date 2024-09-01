using Repositorios.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class ResponsavelRepositorio
    {
        private readonly AppDbContext _context;
        public ResponsavelRepositorio(AppDbContext context)
        {
            _context = context;
        }


    }
}
