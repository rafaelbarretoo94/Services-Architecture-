using System.ServiceModel;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {

        [OperationContract]
        Cliente Buscar(string nome);
        void Adicionar(Cliente c);
    }
}
