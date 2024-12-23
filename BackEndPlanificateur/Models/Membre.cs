namespace BackEndPlanificateur.Models
{
    public class Membre
    {
        protected user user_Id;
        protected voyage voyage_Id;
        protected Role role;
        protected float budget;
        public Membre() { }
        public Membre(user user_Id, voyage voyage_Id, Role role, float budget)
        {
            this.user_Id = user_Id;
            this.voyage_Id = voyage_Id;
            this.role = role;
            this.budget = budget;
        }
    }
}
