using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_events_service.ExternalServices.Cep
{
    public class CepViewModel
    {
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Localidade { get; set; }

        public string Bairro { get; set; }

        public string UF { get; set; }

        public string DDD { get; set; }
    }
}
