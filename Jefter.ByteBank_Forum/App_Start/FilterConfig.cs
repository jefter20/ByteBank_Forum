﻿using System.Web;
using System.Web.Mvc;

namespace Jefter.ByteBank_Forum
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
