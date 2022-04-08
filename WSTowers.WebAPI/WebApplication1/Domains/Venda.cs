using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Domains
{
    public partial class Venda
    {
        public int Id { get; set; }
        public int? ParticipanteId { get; set; }
        public int? ProdutoId { get; set; }
        public int? Quantidade { get; set; }
        public int? LojaId { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public long? Transação { get; set; }

        [JsonIgnore]
        public virtual Loja? Loja { get; set; }
        [JsonIgnore]
        public virtual Participante? Participante { get; set; }
        [JsonIgnore]
        public virtual Produto? Produto { get; set; }
    }
}
