using Jose_Estrella_P2_AP1.DAL;
using Jose_Estrella_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Jose_Estrella_P2_AP1.Services;

public class EncuestaServices(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Encuestas.AnyAsync(c => c.EncuestasId == id);
    }
    private async Task<bool> Insertar(Encuestas encuesta)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Encuestas.Add(encuesta);

        return await contexto.SaveChangesAsync() > 0;
    }
    private async Task<bool> Modificar(Encuestas encuesta)
    {
        await using var _context = await DbFactory.CreateDbContextAsync();
        var local = _context.Encuestas.Local
            .FirstOrDefault(i => i.EncuestasId == encuesta.EncuestasId);
        _context.Entry(encuesta).State = EntityState.Modified;
        return await _context.SaveChangesAsync() > 0;
    }
    public async Task<bool> Guardar(Encuestas encuesta)
    {
        if (!await Existe(encuesta.EncuestasId))
            return await Insertar(encuesta);
        else
            return await Modificar(encuesta);
    }
    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var encuesta = await contexto.Encuestas
            .Where(i => i.EncuestasId == id).ExecuteDeleteAsync();
        return encuesta > 0;
    }
    public async Task<Encuestas?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Encuestas.AsNoTracking().
            FirstOrDefaultAsync(i => i.EncuestasId == id);
    }
    public async Task<List<Encuestas>> Listar(Expression<Func<Encuestas, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Encuestas.AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}
