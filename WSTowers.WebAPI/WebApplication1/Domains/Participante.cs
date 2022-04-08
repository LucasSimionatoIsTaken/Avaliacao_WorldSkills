using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Participante
    {
        public Participante()
        {
            Venda = new HashSet<Venda>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public int? CidadeId { get; set; }
        public int? GeneroId { get; set; }

        [JsonIgnore]
        public virtual Cidade? Cidade { get; set; }
        [JsonIgnore]
        public virtual Genero? Genero { get; set; }
        [JsonIgnore]
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
