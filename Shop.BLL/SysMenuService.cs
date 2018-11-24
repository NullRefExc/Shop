using Shop.IBLL;
using Shop.IDAL;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL
{
    public class SysMenuService : BaseService<SysMenu>, ISysMenuService
    {
        private ISysMenuDAL sysMenuDal = DALContainer.Container.Resolve<ISysMenuDAL>();
        public override void SetDal()
        {
            Dal = sysMenuDal;
        }
    }
}
