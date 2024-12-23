namespace BackEndPlanificateur.Models
{
    public class Activites
    {
        protected int Id_Ac;
        protected Destination IdDes;
        protected string nom;
        protected float cout;
        protected TimeOnly horaireD;
        protected TimeOnly horaireF;
        
        public Activites() { }
        public Activites(int Id, Destination Idd, string nom, float cout, TimeOnly horaireD, TimeOnly horairef) {
            this.Id_Ac = Id;
            this.IdDes = Idd;
            this.nom = nom;
            this.cout = cout;
            this.horaireD = horaireD;
            this.horaireF = horairef;
        }

    }
}
