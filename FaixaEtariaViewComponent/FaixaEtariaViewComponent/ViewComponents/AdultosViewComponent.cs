using FaixaEtariaViewComponent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaixaEtariaViewComponent.ViewComponents
{
    public class AdultosViewComponent : ViewComponent
    {
        private readonly PessoaContexto _pessoaContexto;

        public AdultosViewComponent(PessoaContexto pessoaContexto)
        {
            _pessoaContexto = pessoaContexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _pessoaContexto.Pessoas.Where(x => x.Idade >= 18 && x.Idade < 60).ToListAsync());
        }
    }
}
