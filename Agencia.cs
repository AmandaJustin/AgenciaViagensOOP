// Classe Agencia
// Representa uma agência de viagens, gerenciando destinos, clientes e pacotes turísticos
public class Agencia 
{
    // Listas que armazenam destinos, clientes e pacotes cadastrados na agência
    private List<Destino> Destinos{ get; set; } = new List<Destino>();
    private List<Cliente> Clientes { get; set; } = new List<Cliente>();
    private List<PacoteTuristico> Pacotes { get; set; } = new List<PacoteTuristico>();


    // Método para cadastrar um novo destino na lista de destinos
    public void CadastrarDestino(Destino destino)
    {
        // Verifica se o destino é válido e se já não existe na lista
        if (destino != null && !Destinos.Exists(d => d.Codigo == destino.Codigo))
        {
            Destinos.Add(destino);
            Console.WriteLine($"Destino {destino.NomeLocal} cadastrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Destino já cadastrado ou inválido.");
        }
    }

    // Método para consultar um destino por seu código
    public Destino ConsultarDestinoPorCodigo(string codigo)
    {
        return Destinos.Find(d => d.Codigo == codigo); // Encontra e retorna o destino correspondente ao código
    }

    // Método para listar todos os destinos cadastrados
    public void ListarDestinos()
    {
        foreach (var destino in Destinos)
        {
            destino.ExibirInformacoes(); // Chama o método ExibirInformacoes de cada destino
        }
    }

  // Método para cadastrar um novo cliente na lista de clientes
    public void CadastrarCliente(Cliente cliente)
    {
        // Verifica se o cliente é válido e se já não existe na lista
        if (cliente != null && !Clientes.Exists(c => c.NumeroIdentificacao == cliente.NumeroIdentificacao))
        {
            Clientes.Add(cliente); // Adiciona o cliente à lista
            Console.WriteLine($"Cliente {cliente.Nome} cadastrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Cliente já cadastrado ou inválido.");
        }
    }

    // Método para consultar um cliente pelo seu número de identificação
    public Cliente ConsultarClientePorID(string numeroIdentificacao)
    {
        return Clientes.Find(c => c.NumeroIdentificacao == numeroIdentificacao); // Encontra e retorna o cliente correspondente ao número de identificação
    }

    // Método para listar todos os clientes cadastrados
    public void ListarClientes()
    {
        foreach (var cliente in Clientes)
        {
            cliente.ExibirInformacoes(); // Chama o método ExibirInformacoes de cada cliente
        }
    }

     // Método para cadastrar um novo pacote turístico na lista de pacotes
    public void CadastrarPacote(PacoteTuristico pacote)
    {
        // Verifica se o pacote é válido e se já não existe na lista
        if (pacote != null && !Pacotes.Exists(p => p.Codigo == pacote.Codigo))
        {
            Pacotes.Add(pacote); // Adiciona o pacote à lista
            Console.WriteLine($"Pacote para {pacote.Destino.NomeLocal} cadastrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Pacote já cadastrado ou inválido.");
        }
    }

    // Método para consultar um pacote por seu código
    public PacoteTuristico ConsultarPacotePorCodigo(string codigo)
    {
        // Encontra e retorna o pacote correspondente ao código
        return Pacotes.Find(p => p.Codigo == codigo);
    }

    // Método para listar todos os pacotes turísticos cadastrados
    public void ListarPacotes()
    {
        // Itera por todos os pacotes e exibe suas informações
        foreach (var pacote in Pacotes)
        {
            // Método para exibir informações de pacotes turísticos cadastrados
            // Exibe o nome do destino, preço e vagas disponíveis no pacote

            Console.WriteLine($"Pacote para {pacote.Destino.NomeLocal}, Preço: {pacote.Preco}, Vagas Disponíveis: {pacote.VagasDisponiveis}");
        }
    }

    // Método para reservar um pacote turístico com base no código do pacote e cliente
    public void ReservarPacote(string codigoPacote, Cliente cliente)
{
    // Consulta o pacote utilizando o código fornecido
    var pacote = ConsultarPacotePorCodigo(codigoPacote);
    // Se o pacote não for encontrado, exibe uma mensagem de erro e retorna
    if (pacote == null)
    {
        Console.WriteLine("Pacote não encontrado.");
        return;
    }

    // Verifica se o cliente existe na lista de clientes cadastrados
    if (!Clientes.Exists(c => c.NumeroIdentificacao == cliente.NumeroIdentificacao))
    {
        Console.WriteLine("Cliente não encontrado.");
        return;
    }

    // Se o pacote e o cliente forem encontrados, realiza a reserva
    pacote.Reservar();
}

    // Método para cancelar uma reserva de um pacote turístico com base no código do pacote
    public void CancelarReserva(string codigoPacote)
    {
        // Consulta o pacote utilizando o código fornecido
        var pacote = ConsultarPacotePorCodigo(codigoPacote);
        // Se o pacote for encontrado, chama o método para cancelar a reserva
        if (pacote != null)
        {
            pacote.Cancelar();
        }
        else
        {
            // Se o pacote não for encontrado, exibe uma mensagem de erro
            Console.WriteLine("Pacote não encontrado.");
        }
    }

}