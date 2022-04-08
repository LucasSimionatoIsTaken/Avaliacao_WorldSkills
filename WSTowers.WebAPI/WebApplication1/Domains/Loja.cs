using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Loja
    {
        public Loja()
        {
            Venda = new HashSet<Venda>();
        }

        public int Id { get; set; }
        public string? Loja1 { get; set; }

        [JsonIgnore]
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
