using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.EntityLayer
{
    [Table("Users")]
    public class User
    {
        public User()
        {

        }
        public User(Int32? user)
        {
            UserID = user;
        }
        public Int32? UserID { get; set; }
        public Int32? UserTypeID { get; set; }
        public String UserName { get; set; }
        public String NickName { get; set; }
        public String Password { get; set; }
        public String UserStatus { get; set; }
        public String TableStatus { get; set; }
        public Int16? MaximumPerson { get; set; }

        public virtual UserType fkUserTypes { get; set; }

        public Collection<Order> Order { get; set; }

    }
}
