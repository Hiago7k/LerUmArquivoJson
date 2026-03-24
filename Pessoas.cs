using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerUmArquivoJson;

internal class Pessoas
{
    public string nome { get; set; }
    public string email { get; set; }
    public int idade { get; set; }


    
    public List<Usuario> usuarios { get; set; }
}


