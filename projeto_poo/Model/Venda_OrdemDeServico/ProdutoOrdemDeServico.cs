﻿using System;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Model
{
    [Table("tb_produto_ordemdeservico")]
    public class ProdutoOrdemDeServico
    {
        [Key]
        int IdProdutoOrdemDeServico { get; set; }
        int ProdutoId { get; set; }
        Produto Produto { get; set; }
        double Quantidade { get; set; }
    }
}
