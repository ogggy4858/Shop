using Data.Common;
using Data.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MVC.DAO
{
    public class MenuTypeDAO : Common.Admin<MenuType>
    {

        public MenuTypeDAO()
        { }

        public override MenuType Add(MenuType entity)
        {
            return base.Add(entity);
        }

        public override bool Insert(MenuType entity)
        {
            return base.Insert(entity);
        }

        public override bool Update2(MenuType entity)
        {
            return base.Update2(entity);
        }

        public override bool Delete2(MenuType entity)
        {
            return base.Delete2(entity);
        }

        public override MenuType ViewDetails(int ID)
        {
            return base.ViewDetails(ID);
        }

    }
}
