namespace PrincipioSOLID.Console.LSP;

public class NomeCompletoLSP : UsuarioLSP
{
    public string Apelido { get; set; }

    public NomeCompletoLSP(string nome, string sobrenome, string apelido)
        : base(nome, sobrenome)
        => Apelido = apelido;

    public string NomeCompletoApelido()
    {
        return $"Meu nome é: {Nome} e sobrenome: {Sobrenome} e o meu apelido: {Apelido}";
    }
}