﻿using System.Web;
using System.Web.Mvc;

namespace NTLA1721050223
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
