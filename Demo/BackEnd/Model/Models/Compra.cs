namespace Model.Models
{
    public class Compra
    {
        public long Id { get; set; }
        public long IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string LivroTitulo { get; set; }
        public long IdLivro { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
