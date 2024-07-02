namespace TesteMVC.Models

    public class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
}

public class ListaDeClientes
{
    private List<Cliente> clientes = new List<Cliente>();

    public void AdicionarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public List<Cliente> ObterClientes()
    {
        return clientes;
    }

    public Cliente ObterCliente(int id)
    {
        return clientes[id];
    }

    public void AtualizarCliente(int id, Cliente clienteAtualizado)
    {
        if (id >= 0 && id < clientes.Count)
        {
            clientes[id] = clienteAtualizado;
        }
    }

    public void RemoverCliente(int id)
    {
        if (id >= 0 && id < clientes.Count)
        {
            clientes.RemoveAt(id);
        }
    }
}

