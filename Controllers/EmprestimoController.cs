using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Laboratorio11.Data;
namespace Laboratorio11.Controllers;
//using DemoWebServiceEntityFramework2.DTOs;

[ApiController]
[Route("[controller]")]
[EnableCors("AllowAll")]

public class EmprestimoController : ControllerBase
{

    private readonly ILogger<EmprestimoController > _logger;
    private readonly IAutorRepository _autorRepository;
    //private readonly ILivroRepository _livroRepository;
    //private readonly IEmprestimoRepository _emprestimoRepository;

    public EmprestimoController (ILogger<EmprestimoController> logger, IAutorRepository autorRepository)
    {
        _logger = logger;
        _autorRepository = autorRepository;
        //_livroRepository = livroRepository;
        //_emprestimoRepository = emprestimoRepository;
    }
}
