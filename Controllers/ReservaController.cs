using GS_GreenCycle.Filters;
using GS_GreenCycle.Helper;
using GS_GreenCycle.Models;
using GS_GreenCycle.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GS_GreenCycle.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ReservaController : Controller
    {
        private readonly IReservaRepositorio _reservaRepositorio;
        private readonly ISessao _sessao;
        public ReservaController(IReservaRepositorio reservaRepositorio,
                                 ISessao sessao)
        {
            _reservaRepositorio = reservaRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
            List<ReservaModel> reservas = _reservaRepositorio.BuscarTodos(usuarioLogado.Id);
            return View(reservas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ReservaModel reserva = _reservaRepositorio.ListarPorId(id);
            return View(reserva);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ReservaModel reserva = _reservaRepositorio.ListarPorId(id);
            return View(reserva);
        }

        
        public IActionResult Apagar(int id)
        {
            try 
            {
                bool apagado = _reservaRepositorio.Apagar(id);

                if(apagado)
                {
                    TempData["MensagemSucesso"] = "Reserva apagada com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = $"Sinto muito, um erro aconteceu ao tentar apagar sua reserva.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Sinto muito, um erro aconteceu ao tentar apagar sua reserva. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }
        
        [HttpPost]
        public IActionResult Criar(ReservaModel reserva)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
                    reserva.UsuarioId = usuarioLogado.Id;
                    _reservaRepositorio.Adicionar(reserva);
                    TempData["MensagemSucesso"] = "Reserva cadastrada com sucesso";
                    return RedirectToAction("Index");
                }

                return View(reserva);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Sinto muito, um erro aconteceu ao tentar cadastrar sua reserva. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(ReservaModel reserva)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
                    reserva.UsuarioId = usuarioLogado.Id;
                    reserva = _reservaRepositorio.Atualizar(reserva);
                    TempData["MensagemSucesso"] = "Reserva alterada com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", reserva);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Sinto muito, um erro aconteceu ao tentar editar sua reserva. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

            
        }
    }
}