using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Fornecedor
    {
        public Guid FornecedorID { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O limite do campo é de 100 digitos")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter, no minimo, 3 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "O Campo tipo CPF/CNPJ é obrigadtório")]
        public string CNPJ { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo E-mail é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        [MaxLength(11, ErrorMessage = "O limite do campo é 11 caracteres")]
        [MinLength(10, ErrorMessage = "O minimo do campo é 10 caracteres")]
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
