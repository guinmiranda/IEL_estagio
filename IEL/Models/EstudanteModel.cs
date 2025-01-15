using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using IEL.Validações;

namespace IEL.Models
{
    public class EstudanteModel
    {
        // Identificador único do estudante
        public int Id { get; set; }

        // Nome do estudante com validação: obrigatório e com limite de 100 caracteres
        [Required(ErrorMessage = "Nome obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        // CPF do estudante com validação: obrigatório e formato de CPF válido
        [Required(ErrorMessage = "CPF obrigatório")]
        [ValidacaoCpf(ErrorMessage = "O CPF informado é inválido")]
        public string CPF { get; set; }

        // Endereço do estudante com validação: obrigatório e com limite de 200 caracteres
        [Required(ErrorMessage = "Endereço obrigatório")]
        [MaxLength(200, ErrorMessage = "O Endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; }

        // Data de conclusão do curso do estudante com validação: obrigatória
        [Required(ErrorMessage = "Data obrigatória")]
        public DateTime DataDeConclusao { get; set; }
    }
}
