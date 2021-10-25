namespace teste.Models
{
    public class Contexto : DbContext
    {

        public Dbset<Veiculo> Veiculos { get; set; }
    }
}

    
