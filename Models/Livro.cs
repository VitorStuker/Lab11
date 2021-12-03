namespace Laboratorio11.Models;

public class Livro
{
    public int LivroId { get; set; }
    public string? titulo { get; set; }
    public List<Autor> Autores { get; set; } = null!;
    public List<Emprestimo> Emprestimos { get; set; } = null!;
}