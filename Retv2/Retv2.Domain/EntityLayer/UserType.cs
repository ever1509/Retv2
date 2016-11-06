using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.EntityLayer
{
    [Table("UserType")]
    public class UserType
    {
        public UserType()
        {

        }
        public UserType(Int32? usertype)
        {
            UserTypeID = usertype;
        }
        public Int32? UserTypeID { get; set; }
        public String UserTypeName { get; set; }
        public String Description { get; set; }

        public Collection<User> User { get; set; }
    }
}
