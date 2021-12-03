using Laboratorio11.Models;
using Laboratorio11.DTOs;

namespace Laboratorio11.Data;

//endereco/api/autor/ultimonome


public interface IAutorRepository
{
    Task<Autor?> GetAsync(int id);

    Task<Autor?> GetAsyncUltimoNome(string ultimoNome);

    Task<Autor?> AddAsync(Autor autor);

    Task<Autor?> UpdateAsync(int id, AutorDTO autorDTO);

}