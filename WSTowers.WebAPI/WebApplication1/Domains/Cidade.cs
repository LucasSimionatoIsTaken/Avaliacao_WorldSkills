using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Cidade
    {
        public Cidade()
        {
            Participantes = new HashSet<Participante>();
        }

        public int Id { get; set; }
        public string? Cidade1 { get; set; }
        public int? EstadoId { get; set; }

        [JsonIgnore]
        public virtual Estado? Estado { get; set; }
        [JsonIgnore]
        public virtual ICollection<Participante> Participantes { get; set; }
    }
}
