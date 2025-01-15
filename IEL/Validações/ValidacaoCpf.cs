using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace IEL.Validações  // Namespace atualizado
{
    public class ValidacaoCpf : ValidationAttribute  // Nome da classe alterado para ValidacaoCpf
    {
        public ValidacaoCpf() : base("O CPF informado é inválido.") { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var cpf = value.ToString().Replace(".", "").Replace("-", "");

            // Verifica se o CPF tem exatamente 11 dígitos
            if (cpf.Length != 11 || !Regex.IsMatch(cpf, @"^\d{11}$"))
            {
                return new ValidationResult("CPF inválido. O CPF deve ter exatamente 11 dígitos.");
            }

            // Lógica de validação do CPF
            if (IsCpfValid(cpf))
            {
                // Formatar o CPF no padrão 000.000.000-00
                var cpfFormatado = string.Format("{0:000\\.000\\.000-00}", long.Parse(cpf));
                return ValidationResult.Success; // Pode retornar o CPF formatado se necessário
            }
            else
            {
                return new ValidationResult("O CPF informado é inválido.");
            }
        }

        private bool IsCpfValid(string cpf)
        {
            int[] multiplicador1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cpfTemp;
            string digito;
            int soma;
            int resto;

            // Verifica se todos os dígitos são iguais (ex.: 111.111.111-11)
            if (cpf == new string(cpf[0], cpf.Length))
            {
                return false;
            }

            // Validação do primeiro dígito
            cpfTemp = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpfTemp[i].ToString()) * multiplicador1[i];
            }

            resto = soma % 11;
            if (resto < 2)
            {
                digito = "0";
            }
            else
            {
                digito = (11 - resto).ToString();
            }

            if (digito != cpf[9].ToString())
            {
                return false;
            }

            // Validação do segundo dígito
            soma = 0;
            cpfTemp = cpf.Substring(0, 10);

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpfTemp[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;
            if (resto < 2)
            {
                digito = "0";
            }
            else
            {
                digito = (11 - resto).ToString();
            }

            if (digito != cpf[10].ToString())
            {
                return false;
            }

            return true;
        }
    }
}
