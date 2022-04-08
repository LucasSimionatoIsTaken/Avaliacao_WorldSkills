using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Estado
    {
        public Estado()
        {
            Cidades = new HashSet<Cidade>();
        }

        public int Id { get; set; }
        public string? Estado1 { get; set; }
        public string? Sigla { get; set; }
        public int? RegiaoId { get; set; }

        [JsonIgnore]
        public virtual Regiao? Regiao { get; set; }
        [JsonIgnore]
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
