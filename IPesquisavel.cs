// Interface IPesquisavel
// Define métodos de pesquisa por código e nome que serão implementados pelas classes que a utilizam
public interface IPesquisavel
{
    // Método de pesquisa por código
    // Este método será implementado pelas classes que desejam fornecer a funcionalidade de pesquisa por código
    // Recebe um código (string) como parâmetro e retorna um objeto (ou null se não encontrado)
    object? PesquisarPorCodigo(string codigo);
    
    // Método de pesquisa por nome
    object? PesquisarPorNome(string nome);
}