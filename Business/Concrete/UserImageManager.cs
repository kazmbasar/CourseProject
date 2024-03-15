using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class UserImageManager : IUserImagesService
    {
        IUserImageDal _userImageDal;
        IFileHelper _fileHelper;
        public UserImageManager(IUserImageDal userImageDal, IFileHelper fileHelper)
        {
            _userImageDal = userImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, UserImage userImage)
        {
            IResult result = BusinessRules.Run(CheckIfUserImageLimit(userImage.UserId));
            if (result != null) { return result; }
            userImage.ImagePath = _fileHelper.Upload(file, ImagePath.Path);
            userImage.Date = DateTime.Now;
            _userImageDal.Add(userImage);


            return new Result(true);
        }

        public IResult Delete(UserImage userImage)
        {
            _fileHelper.Delete(ImagePath.Path + userImage.ImagePath);
            _userImageDal.Delete(userImage);
            return new Result(true);
        }

        public IResult Update(IFormFile file, UserImage userImage)
        {
            userImage.ImagePath = _fileHelper.Update(file, ImagePath.Path + userImage.ImagePath, ImagePath.Path);
            userImage.Date = DateTime.Now;
            _userImageDal.Update(userImage);
            return new Result(true);
        }
        private IResult CheckIfUserImageLimit(int userId)
        {
            var result = _userImageDal.GetAll(u => u.UserId == userId).Count;
            if (result >=1 )
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

    }
}
