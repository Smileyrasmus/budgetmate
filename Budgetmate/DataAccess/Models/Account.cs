namespace DataAccess.Models
{
    public class Account
    {
        public string Name { get; set; }
        public Account(string name)
        {
            this.Name = name;
        }
    }
}
