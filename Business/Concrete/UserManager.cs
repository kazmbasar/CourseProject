﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
           _userDal.Add(user);
            return new Result(true,Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true,Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
           return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.UserListed);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u  => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true,Messages.UserUpdated);
        }
    }
}
