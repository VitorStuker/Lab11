using Microsoft.AspNetCore.Mvc;
using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;
using Laboratorio11.DTOs;

namespace Laboratorio11.Data;


//endereco/api/autor/ultimonome


public class AutorRepositoryEF : IAutorRepository
{
    private readonly BdContext _context;

    public AutorRepositoryEF(BdContext context)
    {
        _context = context;
    }

    public async Task<Autor?> GetAsyncUltimoNome(string ultimoNome)
    {
        throw new NotImplementedException();
    }

    public async Task<Autor?> UpdateAsync(int id, AutorDTO autorDTO)
    {
        var autorAux = await _context.Autors.FindAsync(id); //todoItem recebe o todo encontrado
        if(autorAux == null) return NotFound();

        if(id != autorDTO.Id) return BadRequest();

        autorAux.primeiroNome = autorDTO.PrimeiroNome;    //faz as manipulacoes atraves do todoItem (pois ele que se comunica com o DbContext)
        autorAux.ultimoNome = autorDTO.UltimoNome;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    public async Task<Autor?> GetAsync(int id)
    {
        return await _context.Autors.FindAsync(id);
    }
    
    public async Task<Autor?> AddAsync(Autor autor)
    {
        await _context.Autors.AddAsync(autor);
        await _context.SaveChangesAsync();
        return autor;
    }
}