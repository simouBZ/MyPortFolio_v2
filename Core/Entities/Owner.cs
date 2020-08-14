namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public Adress Adress { get; set; }
    }
}
