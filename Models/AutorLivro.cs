namespace Laboratorio11.Models;

public class AutorLivro
{
    //Relacionamento N:1 com Autor
    public Autor? Autor { get; set; }
    public int AutorId { get; set; }

    //Relacionamento N:1 com Livro
    public Livro? Livro { get; set; }
    public int LivroId { get; set; }
}