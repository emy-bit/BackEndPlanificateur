namespace BackEndPlanificateur.Models
{
    public class Role
    { 
        protected int Id_role { get; set; }
        protected string RoleName { get; set; }

        public Role () { }
        public Role (int id, string roleName) {
            this.Id_role = id;
            this.RoleName = roleName;
    }
}
