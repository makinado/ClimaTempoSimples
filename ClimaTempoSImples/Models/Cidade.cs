using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempoSImples.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Estado Estado { get; set; }
    }
}