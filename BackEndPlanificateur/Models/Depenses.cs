namespace BackEndPlanificateur.Models
{
    public class Depenses
    {
        public int Id { get; set; }
        public int MembreId { get; set; }
        public MembreVoyage Membre { get; set; }
        public int ActiviteId { get; set; }
        public Activite Activite { get; set; }
        public decimal Montant { get; set; }
    }
}
