// Classe abstrata ServicoViagem
// Representa um serviço genérico de viagem, que pode ser herdado por classes específicas, como PacoteTuristico
public abstract class ServicoViagem
{
    // Propriedades da classe abstrata ServicoViagem
    public string Codigo {get; set; } // Código identificador do serviço de viagem
    public string Descricao { get; set; } // Descrição do serviço de viagem

    // Construtor da classe ServicoViagem que inicializa as propriedades
    public ServicoViagem(string codigo, string descricao)
    {
        Codigo = codigo;
        Descricao = descricao;
    }

    // Métodos abstratos que devem ser implementados pelas classes derivadas
    public abstract void Reservar(); // Método para reservar o serviço
    public abstract void Cancelar(); // Método para cancelar a reserva do serviço
}