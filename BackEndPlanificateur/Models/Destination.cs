namespace BackEndPlanificateur.Models
{

    public class Destination
    { 
        protected int Id { get; set; }
        protected voyage voyage_Id;
        protected string NameDes;
        protected string DescriptionDes;
        protected int duree;

        public Destination() { }
        public Destination(int id, voyage voyage_Id, string nameDes, string descriptionDes, int duree)
        {
            Id = id;
            this.voyage_Id = voyage_Id;
            NameDes = nameDes;
            DescriptionDes = descriptionDes;
            this.duree = duree;
        }
    }
}
