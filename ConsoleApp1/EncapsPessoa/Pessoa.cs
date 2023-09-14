namespace EncapsPessoa{
public class Pessoa
{
    // Propriedade somente leitura
    public string Nome { get; }
    
    // Propriedade somente escrita (com validação)
    private int _idade;
    public int Idade
    {
        get { return _idade; }
        set
        {
            if (value >= 0 && value <= 120) // Validando a idade
            {
                _idade = value;
            }
            else
            {
                throw new ArgumentException("Idade inválida.");
            }
        }
    }
    
    // Construtor para inicializar a classe
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    
    // Método privado
    private void RealizarAlgumaAcaoPrivada()
    {
        // Lógica interna privada
    }
    
    // Método protegido
    protected void RealizarAlgumaAcaoProtegida()
    {
        // Lógica interna protegida
    }
    
    // Método público
    public void RealizarAlgumaAcaoPublica()
    {
        // Lógica interna pública
        RealizarAlgumaAcaoPrivada(); // Chamando o método privado dentro do método público
    }
}
}