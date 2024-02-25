using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cl1 = new Cliente(01, "Rôner Lima", "045.371.670-92", "ronerdpl@gmail.com", "Dino");
        Cliente cl2 = new Cliente(02, "Giovana Márcia Analu Moraes", "286.028.876-71", "giovana.marcia.moraes@hotmai.com", "Flapor");
        Cliente cl3 = new Cliente(03, "Simone Catarina Ana da Costa", "798.719.209-03", "simone_dacosta@daruma.com.br", "Ushoar");
        Cliente cl4 = new Cliente(04, "Lúcia Aparecida Freitas", "002.881.407-02", "lucia_aparecida_freitas@phocus.com.br", "Vetaos");
        Cliente cl5 = new Cliente(05, "Gustavo Yago Figueiredo", "896.595.090-22", "gustavo_figueiredo@digitalsj.com.br", "Leicio");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cl1);
        listaClientes.Add(cl2);
        listaClientes.Add(cl3);
        listaClientes.Add(cl4);
        listaClientes.Add(cl5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor f1 = new Fornecedor(01, "Rações e Cia LTDA", "14.182.102/0001-80", "racoesecia@gmail.com");
        Fornecedor f2 = new Fornecedor(02, "C&G Brasil", "58.456.951/0001-99", "cg@br.com.br");
        Fornecedor f3 = new Fornecedor(03, "Mundo Pet e Cia", "32.558.985/0001-20", "petecia@petcia.com.br");
        Fornecedor f4 = new Fornecedor(04, "Banho e Tosa AUAU", "12.585.659/0001-58", "auau@banhoetosa.com");
        Fornecedor f5 = new Fornecedor(05, "Produtos Pet", "25.885.666/0001-82", "pet@produtos.com.br");

        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(f1);
        listaFornecedor.Add(f2);
        listaFornecedor.Add(f3);
        listaFornecedor.Add(f4);
        listaFornecedor.Add(f5);

        ViewBag.listaFornecedores = listaFornecedor;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
