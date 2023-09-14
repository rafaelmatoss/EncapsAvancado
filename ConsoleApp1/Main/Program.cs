namespace Main{
using EncapsPessoa;
class Program
{
    static void Main()
    {
        // Criando uma instância da classe Pessoa
        Pessoa pessoa = new Pessoa("João", 30);

        // Testando a propriedade somente leitura Nome
        Console.WriteLine("Nome da Pessoa: " + pessoa.Nome);

        // Testando a propriedade somente escrita Idade
        Console.Write("Informe uma nova idade: ");
        int novaIdade = int.Parse(Console.ReadLine());
        try
        {
            pessoa.Idade = novaIdade; // Tenta atribuir a nova idade
            Console.WriteLine("Idade atualizada para: " + pessoa.Idade);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro ao definir a idade: " + ex.Message);
        }

        // Testando o método público RealizarAlgumaAcaoPublica
        pessoa.RealizarAlgumaAcaoPublica();
        Console.WriteLine("Método público RealizarAlgumaAcaoPublica chamado com sucesso.");

        // Tentando acessar o método privado RealizarAlgumaAcaoPrivada (não é possível)
        // pessoa.RealizarAlgumaAcaoPrivada(); // Isso geraria um erro de compilação

        // Tentando acessar o método protegido RealizarAlgumaAcaoProtegida (não é possível)
        // pessoa.RealizarAlgumaAcaoProtegida(); // Isso geraria um erro de compilação
    }
}
}