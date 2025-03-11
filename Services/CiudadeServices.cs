using Jose_Estrella_P2_AP1.DAL;
using Jose_Estrella_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Jose_Estrella_P2_AP1.Services;

public class CiudadeServices(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<List<Ciudades>> Listar(Expression<Func<Ciudades, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Ciudades
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
}
