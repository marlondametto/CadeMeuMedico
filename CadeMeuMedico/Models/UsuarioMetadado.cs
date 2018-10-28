using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuario { }
    
    public class UsuarioMetadado
    {
        [Required(ErrorMessage="Obrigatório informar o nome")]
        [StringLength(80, ErrorMessage="O nome deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Obrigatório informar o login")]
        [StringLength(30, ErrorMessage="O login deve possuir no máximo 30 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage="Obrigatório informar a senha")]
        [StringLength(100, ErrorMessage="A senha deve possuir no máximo 100 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage="Obrigatório informar o email")]
        [StringLength(100, ErrorMessage="O email deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }
    }
}