using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Regiao
    {
        public Regiao()
        {
            Estados = new HashSet<Estado>();
        }

        public int Id { get; set; }
        public string? Regiao1 { get; set; }

        [JsonIgnore]
        public virtual ICollection<Estado> Estados { get; set; }
    }
}
