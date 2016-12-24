using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaGit.ViewModels
{
    public class PersonaViewModel
    {
        [HiddenInput]
        public int IdPersona { get; set; }
        public string Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
    }
}