using Newtonsoft.Json;
using Shop.Common;
using Shop.IBLL;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class AdminController : Controller
    {
        private ISysMenuService sysMenuService = BLLContainer.Container.Resolve<ISysMenuService>();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Console()
        {
            return View();
        }

        public ActionResult MenuList()
        {
            ViewBag.sysMenuList = sysMenuService.GetModels(s => s.MenuId > 0).ToList();
            return View();
        }

        public ActionResult MenuDetail()
        {
            int MenuId = RequestHelper.Int("MenuId");
            SysMenu sysMenu = sysMenuService.GetModel(s => s.MenuId == MenuId);
            ViewBag.MenuId = MenuId;
            if (sysMenu != null)
            {
                ViewBag.MenuName = sysMenu.MenuName;
                ViewBag.Url = sysMenu.Url;
            }

            return View();
        }

        public string MenuEdit(int MenuId, string MenuName,string Url)
        {
            Result res = new Result() { Success = false, Info = "操作失败！" };
            try
            {
                SysMenu sysMenu = sysMenuService.GetModel(s => s.MenuId == MenuId);
                if(sysMenu != null)
                {
                    sysMenu.MenuName = MenuName;
                    sysMenu.Url = Url;
                    sysMenuService.Update(sysMenu);
                    res.Info = "修改成功!";
                }
                else
                {
                    sysMenu = new SysMenu()
                    {
                        MenuName = MenuName,
                        Url = Url
                    };
                    sysMenuService.Add(sysMenu);
                    res.Info = "添加成功!";
                }
                res.Success = true;
            }
            catch (Exception ex)
            {
                res.Info += ex.Message;
            }
            return JsonConvert.SerializeObject(res);
        }
    }
}