namespace ProjetoPerfilTayla.Domain
{
    public class Esportes 
    { 
        public int Id {get;set;}
        public string Modalidade {get;set;}
        public string Time {get;set;}
        public DateTime DiaDeJogo {get;set;}
        public string HoraDoJogo {get;set;}
    }

    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
    }
}
