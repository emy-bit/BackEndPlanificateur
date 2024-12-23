using System.Globalization;

namespace BackEndPlanificateur.Models
{
    public class User
    {
        public int Id { get; set; }
        protected string name;
        protected string email;
        protected string password;
        protected string preferences;
        public user() { }
        public user(int Id , string name , string email , string password , String preferences ) {
            this.Id = Id;
            this.email = email; 
            this.name = name;
            this.password = password;
            this.preferences = preferences;
        }
    }
}
