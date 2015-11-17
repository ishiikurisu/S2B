using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPOO.classes
{
    public class ClienteJuridico : Cliente
    {
        public string CNPJ { get; set; }
        public ClienteJuridico() : base()
        {
            
        }

        public ClienteJuridico(string nome,
                               string telefone,
                               string email,
                               string cnpj) : base(nome, telefone, email)
        {
            this.CNPJ = cnpj;
        }

        public override void MensagemCliente()
        {
            throw new NotImplementedException();
        }

        public override string VerificarEmail()
        {
            return base.VerificarEmail();
        }
    }
}
