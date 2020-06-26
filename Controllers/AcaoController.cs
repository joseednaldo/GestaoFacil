using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoFacil.Dados.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFacil.Controllers
{
    public class AcaoController : Controller
    {
        private readonly IAcaoRepository _acaoRepository;

        public AcaoController(IAcaoRepository acaoRepository)
        {
            _acaoRepository = acaoRepository;
        }

        public IActionResult List()
        {
            var lstAcoes = _acaoRepository.GetAll();
            return View(lstAcoes);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}