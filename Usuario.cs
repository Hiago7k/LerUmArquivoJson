using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LerUmArquivoJson;

internal class Usuario
{
    public String? NomeDoUsuario { get;  }
    public String? Email { get;  }
    public int Idade { get;  }

}
