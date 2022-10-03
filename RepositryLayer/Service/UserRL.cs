using CommanLayer.Model;
using RepositryLayer.Context;
using RepositryLayer.Entities;
using RepositryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositryLayer.Service
{
    public class UserRL:IUserRL
    {
        private readonly FundooContext fundooDBContext;

        public UserRL(FundooContext fundooDBContext)
        {
            this.fundooDBContext = fundooDBContext;
        }

        public UserEntity UserRegistration(Registration registration)
        {
            try
            {
                UserEntity userEntity = new UserEntity();
                userEntity.FirstName = registration.FirstName;
                userEntity.LastName = registration.LastName;
                userEntity.EmailId = registration.EmailId;
                userEntity.Password = registration.Password;
                fundooDBContext.UserTable.Add(userEntity);
                int result = fundooDBContext.SaveChanges();
                if(result > 0)
                {
                    return userEntity;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
