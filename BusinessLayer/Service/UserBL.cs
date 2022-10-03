using BusinessLayer.Interface;
using CommanLayer.Model;
using RepositryLayer.Entities;
using RepositryLayer.Interface;
using RepositryLayer.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class UserBL : IUserBl
    {
        private readonly IUserRL userrl;
        public UserBL(IUserRL userrl)
        {
            this.userrl = userrl;
        }
        public UserEntity UserRegistration(Registration Registration)
        {
            try
            {
                return userrl.UserRegistration(Registration);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

