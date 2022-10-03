using CommanLayer.Model;
using RepositryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositryLayer.Interface
{
    public interface IUserRL
    {
        UserEntity UserRegistration(Registration registration);
    }
}
