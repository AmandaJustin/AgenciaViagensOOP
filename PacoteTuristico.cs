using System.Data;

// Classe PacoteTuristico que herda de ServicoViagem
// Representa um pacote turístico com destino, preço e datas de início e fim
public class PacoteTuristico : ServicoViagem
{
    public Destino Destino {get; set; } // Referência a um objeto da classe Destino
    public DateTime DataInicio {get; set; } // Data de início do pacote
    public DateTime DataFim {get; set; }  // Data de término do pacote
    public decimal Preco {get; set; } // Preço do pacote
    public int VagasDisponiveis { get; set; } // Número de vagas disponíveis no pacote

    // Construtor do PacoteTuristico, que inicializa as propriedades e chama o construtor base
    public PacoteTuristico(Destino destino, DateTime dataInicio, DateTime dataFim, decimal preco, int vagasDisponiveis, string codigo, string descricao) : base(codigo, descricao) // Chama o construtor da classe base (ServicoViagem)
    {
        Destino = destino;
        DataInicio = dataInicio;
        DataFim = dataFim;
        Preco = preco;
        VagasDisponiveis = vagasDisponiveis;
    }

    // Implementação do método Reservar
    // Verifica se há vagas disponíveis e, se houver, decrementa o número de vagas
    public override void Reservar()
    {
        if (VagasDisponiveis > 0)
        {
            VagasDisponiveis--; // Reduz o número de vagas disponíveis
            Console.WriteLine($"Vagas diponíveis: {VagasDisponiveis}");
        }
        else
        {
            Console.WriteLine("Não há vagas disponíveis");
        }
    }

    // Implementação do método Cancelar
    // Exibe uma mensagem de cancelamento da reserva
    public override void Cancelar()
    {
        VagasDisponiveis++;
        Console.WriteLine($"Reserva cancelada! Vagas disponíveis: {VagasDisponiveis}");
    }

    // Implementação do método para pesquisar o pacote por código
    // Retorna o pacote se o código coincidir
    public object? PesquisarPorCodigo(string codigo)
    {
        return Codigo == codigo ? this : null;
    }

    // Implementação do método para pesquisar o pacote por nome do destino
    // Retorna o pacote se o nome do destino coincidir
    public object? PesquisarPorNome(string nome)
    {
        return Destino.NomeLocal == nome ? this : null;
    }
}