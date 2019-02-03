using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(EspecialidadeMetadado))]
    public partial class Especialidades { }
    public class EspecialidadeMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o nome")]
        [StringLength(80, ErrorMessage = "O nome deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }
    }
}