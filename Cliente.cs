 // Método para exibir informações do cliente
public class Cliente
{
    // Propriedades da classe Cliente
    public string Nome { get; set; } // Nome do cliente
    public string NumeroIdentificacao { get; set; } // Número de identificação único do cliente (ex: CPF ou outro ID)
    public string Contato { get; set; } // Informação de contato do cliente (ex: telefone ou email)

    // Construtor da classe Cliente que inicializa as propriedades
    public Cliente(string nome, string numeroIdentificacao, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Contato = contato;
        
    }

    // Método ExibirInformacoes que exibe as informações do cliente no console
    public void ExibirInformacoes()
    {
        // Exibe no console as informações do cliente, incluindo Nome, Número de Identificação e Contato
        Console.WriteLine($"Nome: {Nome}, Identificação: {NumeroIdentificacao}, Contato {Contato}");
    }
}