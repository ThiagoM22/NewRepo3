using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Clientes
    {
        public Guid ClientesId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O limite do campo é de 100 digitos")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter, no minimo, 3 caracteres")]
        public string ClientesName { get; set; }


        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório")]
        [MaxLength(2, ErrorMessage = "O limite do campo é 2 caracteres")]
        [MinLength(2, ErrorMessage = "O minimo do campo é 2 caracteres")]
        public string UF { get; set; }


        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        [MaxLength(8, ErrorMessage = "O limite do campo é 8 caracteres")]
        [MinLength(8, ErrorMessage = "O minimo do campo é 8 caracteres")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string Bairro { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo E-mail é obrigatório")]
        public string Email { get; set; }
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O campo Celular é obrigatório")]
        [MaxLength(11, ErrorMessage = "O limite do campo é 11 caracteres")]
        [MinLength(11, ErrorMessage = "O minimo do campo é 11 caracteres")]
        public string Celular { get; set; }

        [Display(Name = "Tipo de Pessoa")]
        [Required(ErrorMessage = "O Campo tipo de pessoa é obrigadtório")]
        public string TipoPessoa { get; set; }

        [Display(Name = "CPF / CNPJ")]
        [Required(ErrorMessage = "O Campo tipo CPF/CNPJ é obrigadtório")]
        public string CpfCnpj { get; set; }
        [Display(Name = "Data de cadastro ")]
        [Required(ErrorMessage = "O Campo tipo Data de Cadastro é obrigadtório")]
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Data Nasc. / Fundação ")]
        [Required(ErrorMessage = "O Campo é obrigadtório")]
        public DateOnly DataNascFund { get; set; }
        [Display(Name = "Ativo?")]
        public bool CadastroAtivo { get; set; }
        [Display(Name = "Observação ")]
        [Required(ErrorMessage = "O Campo é obrigadtório")]
        public string Observacao { get; set; }
        [Display(Name = "Numero ")]
        [Required(ErrorMessage = "O Campo é obrigadtório")]
        public string numero { get; set; }



    }
}
