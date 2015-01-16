using System.Web.Mvc;

namespace bootstrap_3._0._2_dev.Controllers
{
    public class Series5StylesController : Controller
    {
        public ActionResult Index()
        {
            var view = View();
            view.MasterName = "~/Views/Shared/_Series5Layout.cshtml";
            return view;
        }
        public ActionResult Asset()
        {
            var view = View();
            view.MasterName = "~/Views/Shared/_Series5Layout.cshtml";
            return view;
        }

        public ActionResult LookupMaint()
        {
            var view = View();
            view.MasterName = "~/Views/Shared/_Series5Layout.cshtml";
            return view;
        }
        public ActionResult LookupMaintAdd()
        {
            var view = View();
            view.MasterName = "~/Views/Shared/_Series5Layout.cshtml";
            return view;
        }

        public ActionResult AssetReadonly()
        {
            var view = View();
            view.MasterName = "~/Views/Shared/_Series5Layout.cshtml";
            return view;
        }
    }
}
