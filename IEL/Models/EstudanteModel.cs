using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using IEL.Validações;

namespace IEL.Models
{
    public class EstudanteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Nome obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF obrigatório")]
        [ValidacaoCpf(ErrorMessage = "O CPF informado é inválido")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Endereço obrigatório")]
        [MaxLength(200, ErrorMessage = "O Endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Data obrigatória")]
        public DateTime DataDeConclusao { get; set; }
        

    }
}
