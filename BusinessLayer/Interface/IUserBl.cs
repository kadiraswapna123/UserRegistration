using CommanLayer.Model;
using RepositryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IUserBl
    {
        UserEntity UserRegistration(Registration registration);
    }
}
