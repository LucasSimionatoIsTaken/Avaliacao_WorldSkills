using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Estoque
    {
        public int Id { get; set; }
        public int? ProdutoId { get; set; }
        public int? Loja { get; set; }
        public int? Quantidade { get; set; }

        [JsonIgnore]
        public virtual Produto? Produto { get; set; }
    }
}
