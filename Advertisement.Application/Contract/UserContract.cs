using System;
using System.Linq;
using Advertisement.Application.Entities;
using Advertisement.Application.Helpers;
using Advertisement.Application.Infrastructure;
using Advertisement.Application.Messaging;
using Advertisement.Application.ViewModel;
using AutoMapper;

namespace Advertisement.Application.Contract
{

    public interface IUserContract : IBaseContract<User>
    {
        BaseMessage Register(RegisterViewModel model);

        UserMessage Login(LoginViewModel model);
    }

    internal class UserContract : BaseContract<User>, IUserContract
    {
        public UserContract(AdvDbDbContext advDbDbContext) : base(advDbDbContext)
        {
        }

        public BaseMessage Register(RegisterViewModel model)
        {
            var message = new BaseMessage();

            try
            {
                var user = Mapper.Map<RegisterViewModel, User>(model);
                user.Password = Cryptography.Hash(user.Password);
                user.CreateDate = DateTime.Now;
                user.UpdateDate = DateTime.Now;
                Entities.Add(user);
                Commit();
            }
            catch (Exception exception)
            {
                message.Failed = true;
                message.Body = "خطایی در ثبت نام رخ داده است";
            }

            return message;
        }

        public UserMessage Login(LoginViewModel model)
        {
            var message = new UserMessage();

            try
            {
                var user = Entities.SingleOrDefault(c => c.Email == model.Email);

                if (user != null)
                {
                    if (!Cryptography.IsValidated(model.Password, user.Password))
                    {
                        message.Failed = true;
                        message.Body = "نام کاربری یا رمز عبور اشتباه است";
                        return message;
                    }

                    message.User = Mapper.Map<User, UserViewModel>(user);
                }
            }
            catch (Exception exception)
            {
                message.Failed = true;
                message.Body = "خطا در ورود به سایت";
            }

            return message;
        }
    }
}
