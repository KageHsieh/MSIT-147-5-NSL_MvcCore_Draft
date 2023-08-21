using Nsl_Core.Models.Dtos.Member.Manager;
using Nsl_Core.Models.EFModels;
using Nsl_Core.Models.ViewModels;
using System.Diagnostics.Metrics;
using XAct;

namespace Nsl_Core.Models.Infra.EntitiesTransfer
{
    public static class VMToEntity
    {
        public static Members AdminVMToMember(this AdminVM vm)
        {
            return new Members
            {
                Name = vm.Name,
                Email = vm.Email,
                Password = vm.Password,
                ImageName = vm.ImageName,
                EmailCheck = vm.EmailCheck,
                Role = vm.Role,
            };
        }

        public static Members RegisterVMToMember(this RegisterVM vm, NSL_DBContext db)
        {
            var hp = new HashPassword(db);


            string? hashPassword = null;
            string? salt = null;
            if (vm.Password != null)
            {
                hashPassword = hp.GenerateHashPassword(vm.Password, out salt);
            }

            var emailToken = Guid.NewGuid().GetHashCode().ToString();

            return new Members()
            {
                Name = vm.Name,
                Gender = vm.Gender,
                Birthday = vm.Birthday,
                Phone = vm.Phone,
                CityId = vm.City,
                AreaId = vm.Area,
                ImageName = vm.ImageName,
                Email = vm.Email,
                EmailToken = emailToken,
                Password = vm.Password,
                Salt = salt,
                EncryptedPassword = hashPassword,
            };
        }

        public static Members LineRegisterVMToMember(this LineRegisterVM vm, NSL_DBContext db)
        {
            var hp = new HashPassword(db);


            string? hashPassword = null;
            string? salt = null;
            if (vm.Password != null)
            {
                hashPassword = hp.GenerateHashPassword(vm.Password, out salt);
            }

            var emailToken = Guid.NewGuid().GetHashCode().ToString();

            return new Members()
            {
                Name = vm.Name,
                Gender = vm.Gender,
                Birthday = vm.Birthday,
                Phone = vm.Phone,
                CityId = vm.City,
                AreaId = vm.Area,
                ImageName = vm.ImageName,
                Email = vm.LineId,
                EmailToken = emailToken,
                Password = vm.Password,
                Salt = salt,
                EncryptedPassword = hashPassword,
                EmailCheck = true,
                LineId = vm.LineId,
            };
        }

        public static Members ForgetPasswordVMToMember(this ForgetPasswordVM vm)
        {

            var db = new NSL_DBContext();
            return new Members()
            {
                Name = db.Members.Where(x=>x.Email == vm.Email).Select(x => x.Name).SingleOrDefault().ToString(),
                Gender = db.Members.Where(x=>x.Email == vm.Email).SingleOrDefault().Gender,
                Email = vm.Email,
                EmailToken = db.Members.Where(x => x.Email == vm.Email).Select(x => x.EmailToken).SingleOrDefault().ToString(),
            };
        }


        public static Members MemberDtoToMember(this MemberDto dto)
        {
            return new Members()
            {
                Id = dto.Id,
                Name = dto.Name,
                Password = dto.Password,
                Phone = dto.Phone,
                Email = dto.Email,
                Birthday = dto.Birthday,
                CityId = dto.CityId,
                AreaId = dto.AreaId,
                Gender = dto.Gender,
                EmailCheck = dto.EmailCheck,
                Role = dto.Role,
                ImageName = dto.ImageName
            };
        }
    }
}
