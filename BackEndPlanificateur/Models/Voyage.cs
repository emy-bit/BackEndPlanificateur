namespace BackEndPlanificateur.Models
{
    public class voyage
    { 
        protected int voyageId;
        protected string Nom;
        protected string description;
        protected DateOnly dateDebut;
        protected DateOnly dateFin;
        protected Role organisateur_id;
        public voyage () { }
        public voyage (int Id, string nom, string description, DateOnly dateD, DateOnly dateF, Role org_id)
        {
            this.description = description; 
            this.dateFin = dateF;
            this.dateDebut = dateD;
            this.organisateur_id = org_id;
            this.voyageId = Id;
            this.Nom = nom; 
        }
    }
}
