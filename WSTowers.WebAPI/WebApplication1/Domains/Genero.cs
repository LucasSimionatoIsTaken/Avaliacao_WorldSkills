using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Genero
    {
        public Genero()
        {
            Participantes = new HashSet<Participante>();
        }

        public int Id { get; set; }
        public string? Genero1 { get; set; }

        [JsonIgnore]
        public virtual ICollection<Participante> Participantes { get; set; }
    }
}
