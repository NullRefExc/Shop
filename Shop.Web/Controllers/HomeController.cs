
using Shop.IBLL;
using Shop.Model;
using System;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class HomeController : Controller
    {
        private ISysUserService sysUserService = BLLContainer.Container.Resolve<ISysUserService>();
        // GET: Home
        public ActionResult Index()
        {
            //SysUser sysUser = new SysUser()
            //{
            //    UserName = "辛生",
            //    UserPwd = "123456",
            //    Mobile = "13265156313",
            //    CreateTime = DateTime.Now
            //};
            //sysUserService.Add(sysUser);

            SysUser sysUser = sysUserService.GetModel(s => s.UserId == 1);
            return View();
        }
    }
}