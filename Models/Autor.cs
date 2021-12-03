namespace Laboratorio11.Models;

public class Autor
{
    public int AutorId { get; set; }
    public string? primeiroNome { get; set; }
    public string? ultimoNome { get; set; }

    public List<Livro> Livros { get; set; } = null!;
}