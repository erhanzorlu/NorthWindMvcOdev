using Microsoft.EntityFrameworkCore.Storage;
using MVC_Layout.Models.Context;
using MVC_Layout.Models.Entity;
using MVC_Layout.Models.Repository;

namespace MVC_Layout.Models.Service
{
    public class UserService : IUser
    {
        DatabaseContext db = new DatabaseContext();
        public void Create(User user)
        {
        db.Users.Add(user);
            db.SaveChanges();
          
        }

        public string Validation(string username,string password)
        {
            string uyari = "";
            foreach (var item in db.Users)
            {
                if (item.Username==username && item.Password==password)
                {
                    uyari = "Kullanıcı kayıtlı";
                    break;
                }
                else
                {
                    uyari = "kullanıcı kayıtlı değil";
                }
               
            }
            return uyari;
        }
    }
}
