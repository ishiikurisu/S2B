using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPOO.classes
{
    public abstract class Cliente
    {
        /* Propriedades */
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        /* Construtores */
        public Cliente()
        {

        }

        public Cliente(string nome, string telefone, string email)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

        /* Métodos */
        public virtual string VerificarEmail()
        {
            return "email válido";
        }

        public abstract void MensagemCliente();
    }
}
