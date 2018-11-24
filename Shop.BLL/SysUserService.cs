using Shop.IBLL;
using Shop.IDAL;
using Shop.Model;

namespace Shop.BLL
{
    public class SysUserService : BaseService<SysUser>, ISysUserService
    {
        private ISysUserDAL sysUserDal = DALContainer.Container.Resolve<ISysUserDAL>();
        public override void SetDal()
        {
            Dal = sysUserDal;
        }
    }
}
