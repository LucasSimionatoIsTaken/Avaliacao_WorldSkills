﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Produto
    {
        public Produto()
        {
            Estoques = new HashSet<Estoque>();
            Venda = new HashSet<Venda>();
        }

        public int Id { get; set; }
        public string? Produto1 { get; set; }
        public int? Valor { get; set; }
        public int? CategoriaId { get; set; }

        [JsonIgnore]
        public virtual Categorium? Categoria { get; set; }
        [JsonIgnore]
        public virtual ICollection<Estoque> Estoques { get; set; }
        [JsonIgnore]
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
