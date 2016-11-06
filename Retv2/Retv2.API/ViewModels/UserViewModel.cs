using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retv2.API.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {

        }
        public UserViewModel(User entity)
        {
            UserID = entity.UserID;
            UserTypeID = entity.UserTypeID;
            NickName = entity.NickName;
            Password = entity.Password;
            UserStatus = entity.UserStatus;
            TableStatus = entity.TableStatus;
            MaximumPerson = entity.MaximumPerson;

        }
        public Int32? UserID { get; set; }
        public Int32? UserTypeID { get; set; }
        public String UserName { get; set; }
        public String NickName { get; set; }
        public String Password { get; set; }
        public String UserStatus { get; set; }
        public String TableStatus { get; set; }
        public Int16? MaximumPerson { get; set; }
    }
}