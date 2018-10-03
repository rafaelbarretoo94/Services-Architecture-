namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public void Adicionar(Cliente c)
        {
            ClienteDAO cliente = new ClienteDAO();
            cliente.AdicionarCliente(c);
        }
        public Cliente Buscar(string nome)
        {
            ClienteDAO cliente = new ClienteDAO();
            return cliente.Buscar(nome);
        }
    }
}
