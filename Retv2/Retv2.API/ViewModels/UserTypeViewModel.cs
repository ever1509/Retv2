using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retv2.API.ViewModels
{
    public class UserTypeViewModel
    {
        public UserTypeViewModel()
        {

        }
        public UserTypeViewModel(UserType entity)
        {
            UserTypeID = entity.UserTypeID;
            UserTypeName = entity.UserTypeName;
            Description = entity.Description;
        }
        public Int32? UserTypeID { get; set; }
        public String UserTypeName { get; set; }
        public String Description { get; set; }

    }
}