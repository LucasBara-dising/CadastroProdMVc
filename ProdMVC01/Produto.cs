using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace ProdMVC01.Models
{
    public class Produto
    {
        [Display(Name ="Codigo")]
        [Required(ErrorMessage ="O Código é obrigatorio")]
        public int CodigoProd { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O nome do produto é obrigatorio")]
        [StringLength(80, ErrorMessage ="O Nome esta muito longo")]
        public string NomeProd { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A descrição do produto é obrigatoria")]
        [StringLength(150, ErrorMessage = "A descrição do produto esta muito longa")]
        public string DescProd { get; set; }

        [Display(Name = "Peso(g)")]
        [Required(ErrorMessage = "O peso é obrigatorio")]
        public int PesoProd { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "A categoria do produto é obrigatorio")]
        [StringLength(80, ErrorMessage = "A descrição do produto esta muito longa")]
        public string CategoriaProd { get; set; }

        [Required(ErrorMessage = "O valor é obrigatorio")]
        [Display(Name = "Valor")]
        //[DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal ValorUni { get; set; }
    }
}