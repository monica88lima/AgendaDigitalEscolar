using Entidades;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Repositorios.Contexto;
using Repositorios.Interfaces;

namespace Repositorios;

public class ComunicadoTurmaRepositorio : BaseRepositorio<Comunicado_Turmas>, IComunicadoTurmaRepositorio
{
    private readonly AppDbContext _context;

    public ComunicadoTurmaRepositorio(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Comunicados>> BuscarComunicadosPorTurma(int id)
    {
        return await _context.Set<Comunicado_Turmas>()
            .Include(x => x.Comunicado)
            .Where(x => x.TurmaId == id)
            .Select(p => p.Comunicado )
            .ToListAsync();
    }
}
