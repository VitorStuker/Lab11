namespace Laboratorio11.Models;

public class Emprestimo
{
    public int EmprestimoId { get; set; }
    public DateTime dataRetirada { get; set; }
    public DateTime dataDevolucao { get; set; }
    public bool entregue { get; set; }
    public Livro? Livro { get; set; }
    public int LivroId { get; set; }
}