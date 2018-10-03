using System.Runtime.Serialization;

namespace Passagens
{
    [DataContract]
    public class Cliente
    {
        private string _nome;
        private string _cpf;

        [DataMember]
        public string Nome
        {
            get { return _nome; }
            set { Nome = _nome; }
        }

        [DataMember]
        public string Cpf
        {
            get { return _cpf; }
            set { Nome = _cpf; }
        }
    }
}
