using Laboratorio11.Models;

namespace Laboratorio11.DTOs;
public class AutorDTO
{
    public int Id { get; set; }
    public string? PrimeiroNome { get; set; }
    public string? UltimoNome { get; set; }

    public AutorDTO(int id, string primeiroNome, string ultimoNome)
    {
        Id = id;
        PrimeiroNome = primeiroNome;
        UltimoNome = ultimoNome;
    }

    public static AutorDTO FromProduto(Autor autor)
    {
        return new AutorDTO(autor.AutorId, autor.primeiroNome!, autor.ultimoNome!);
    }
}