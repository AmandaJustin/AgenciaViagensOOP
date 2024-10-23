// Classe Program (classe principal do programa)
Agencia agencia = new Agencia(); // Cria uma nova instância da classe Agencia

// Cria um novo destino chamado "Rio de Janeiro" e o cadastra na agência
Destino destino = new Destino("Rio de Janeiro", "Brasil", "001", "O Rio de Janeiro continua lindo...");
agencia.CadastrarDestino(destino); // Chama o método CadastrarDestino para adicionar o destino à lista de destinos da agência

// Cria um novo cliente chamado "Anna Todd" e o cadastra na agência
Cliente cliente = new Cliente("Anna Todd", "123456", "AnnaTodd@gmail.com");
agencia.CadastrarCliente(cliente);  // Chama o método CadastrarCliente para adicionar o cliente à lista de clientes da agência

// Cria um novo pacote turístico para o destino "Rio de Janeiro"
// O pacote tem data de início no momento atual (DateTime.Now), dura 7 dias, custa 5000 e tem 10 vagas disponíveis
 PacoteTuristico pacote = new PacoteTuristico(destino, DateTime.Now, DateTime.Now.AddDays(7), 5000, 10, "001", "Pacote para Rio de Janeiro");

    // Cadastra o pacote turístico na agência
        agencia.CadastrarPacote(pacote); // Chama o método CadastrarPacote para adicionar o pacote à lista de pacotes da agência

    // Realiza a reserva do pacote "001" para o cliente "Anna Todd"
        agencia.ReservarPacote("001", cliente); // Chama o método ReservarPacote para reservar o pacote de acordo com o código e o cliente fornecidos

    // Cancela a reserva do pacote "001"
        agencia.CancelarReserva("001"); // Chama o método CancelarReserva para cancelar a reserva do pacote de código "001"

        // Chama o método CancelarReserva para cancelar a reserva do pacote de código "001"
        agencia.ListarDestinos(); // Chama o método ListarDestinos para exibir os detalhes de todos os destinos cadastrados

        // Lista todos os clientes cadastrados na agência
        agencia.ListarClientes(); // Chama o método ListarClientes para exibir os detalhes de todos os clientes cadastrados

        // Lista todos os pacotes turísticos cadastrados na agência
        agencia.ListarPacotes(); // Chama o método ListarPacotes para exibir os detalhes de todos os pacotes turísticos cadastrados
