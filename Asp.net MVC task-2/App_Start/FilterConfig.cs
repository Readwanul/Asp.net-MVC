﻿using System.Web;
using System.Web.Mvc;

namespace Asp.net_MVC_task_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
