using MVC_Layout.Models.Entity;

namespace MVC_Layout.Models.Repository
{
    public interface IUser
    {
        public void Create(User user);
        public string Validation(string username,string password);
    }
}
