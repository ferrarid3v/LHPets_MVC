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
        //Instância do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "123.456.789-00", "arthur.antunes@df.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "Willian Henry Gates", "999.888.777-66", "willian.henry@df.senai.br", "Bisteca");
        Cliente cliente3 = new Cliente(03, "Felipe de Orleans e Bragança", "144.897.567.78", "orleansebraganca@df.senai.br", "Princípe");
        Cliente cliente4 = new Cliente(04, "Jim Morrinson", "555.444.888.99", "thedoors@df.senai.br", "John Lennon");
        Cliente cliente5 = new Cliente(05, "Janis Joplin Amadeus Mozart", "098.765.432.21", "janisjoplin@df.senai.br", "Rita Lee");

        // Lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // Instância do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "12.182.102/0001-89", "csharp@petsa.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "PetWorld Comércio Ltda", "45.678.123/0001-78", "atendimento@petworld.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Bicho Feliz Produtos Pet", "56.789.234/0001-99", "vendas@bichofeliz.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "PetCare Soluções Animais", "12.345.678/0001-55", "contato@petcare.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Animalia Pet Shop", "98.765.432/0001-21", "contato@animalia.com.br");

        //Lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

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
