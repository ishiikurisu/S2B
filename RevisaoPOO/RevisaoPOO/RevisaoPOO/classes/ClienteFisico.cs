using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPOO.classes
{
    public class ClienteFisico : Cliente, ICalculo
    {
        public string CPF { get; set; }

        public ClienteFisico() : base()
        {
            
        }
        public ClienteFisico(string nome, 
                             string telefone, 
                             string email, 
                             string cpf) : base(nome, telefone, email)
        {
            this.CPF = cpf;
        }

        public override void MensagemCliente()
        {
            throw new NotImplementedException();
        }

        void ICalculo.Testar()
        {
            throw new NotImplementedException();
        }

        void ICalculo.Experimentar()
        {
            throw new NotImplementedException();
        }

        void ICalculo.Brincar()
        {
            throw new NotImplementedException();
        }
    }
}
