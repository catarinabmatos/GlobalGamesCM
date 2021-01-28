using GlobalGamesCET50.data.entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.Models
{
    public class InscricoesUpViewModel : Inscricoes
    {

        [Display(Name="Image")]

        public IFormFile ImageFile { get; set; }

    }
}
