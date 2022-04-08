using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Categorium
    {
        public Categorium()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string? Categoria { get; set; }

        [JsonIgnore]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
