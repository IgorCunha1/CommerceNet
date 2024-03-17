﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModel.Produto
{
    public class CadastroProdutoViewModel
    {
        public string Nome { get; set; } = string.Empty;
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
    }
}