using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Servicos.ViewModels
{
    public class CadastrarSensorViewModel
    {

        [Required(ErrorMessage = "Informe o código do sensor")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Informe o modelo do sensor")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Informe o titulo que o sensor exibirá")]
        public string Titulo { get; set; }

        
        [Required(ErrorMessage = "Informe o texto que o sensor exibirá")]
        public string Texto { get; set; }


        [Required(ErrorMessage = "Informe status do sensor")]
        public string Status { get; set; }



    }
}
