// Classe Destino que implementa a interface IPesquisavel
public class Destino : IPesquisavel
{
    // Propriedades da classe Destino
    public string NomeLocal { get; set; } // Nome do local do destino
    public string Pais { get; set; } // País do destino
    public string Codigo { get; set;} // Código identificador único do destino
    public string Descricao { get; set; } // Descrição detalhada do destino

// Construtor que inicializa as propriedades da classe
    public Destino(string nomeLocal, string pais, string codigo, string descricao)
    {
        NomeLocal = nomeLocal;
        Pais = pais;
        Codigo = codigo;
        Descricao = descricao;
    }
    // Construtor que inicializa as propriedades da classe
    // Retorna o objeto atual (this) se o código coincidir, ou null se não coincidir
    public object? PesquisarPorCodigo(string codigo)
    {
        return Codigo == codigo ? this : null; // Retorna o objeto atual se o código for igual
    }

    // Implementação do método da interface para pesquisar um destino pelo nome
    // Retorna o objeto atual (this) se o nome coincidir, ou null se não coincidir
    public object? PesquisarPorNome(string nome)
    {
        return NomeLocal == nome ? this : null; // Retorna o objeto atual se o nome for igual
    }

    // Método para exibir as informações do destino
    // Exibe no console as propriedades NomeLocal, País, Código e Descrição
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Destino: {NomeLocal}, País: {Pais}, Código: {Codigo}, Descrição: {Descricao}");
    }
}