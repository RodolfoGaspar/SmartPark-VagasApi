public class Vaga
{
    public Vaga() { }
    public Vaga(Guid id, Guid idEstacionamento, StatusVagaEnum status, TipoVagaEnum tipoVaga, double valorHora)
    {
        Id = id.ToString();
        IdEstacionamento = idEstacionamento.ToString();
        Status = status;
        TipoVaga = tipoVaga;
        ValorHora = valorHora;
    }

    public string Id { get; set; }
    public string IdEstacionamento { get; set; }
    public StatusVagaEnum Status { get; set; }
    public string? StatusDescricao => Enum.GetName(Status);
    public TipoVagaEnum TipoVaga { get; set; }
    public string? TipoVagaDescricao => Enum.GetName(TipoVaga);
    public double ValorHora { get; set; }
}
