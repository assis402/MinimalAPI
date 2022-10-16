using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalAPI.Models
{
    [Table("fornecedores")]
    public class Fornecedor
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("documento")]
        public string? Documento { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; }
    }
}