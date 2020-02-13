using DevExpress.Web.Mvc;
using DiagramContainers.Models;
using System.Web.Mvc;

namespace DiagramContainers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(DiagramDataProvider.GetItems());
        }

        public ActionResult DiagramUpdate(MVCxDiagramNodeUpdateValues<Item, int> nodeUpdateValues)
        {
            foreach (var item in nodeUpdateValues.Update)
            {
                DiagramDataProvider.UpdateItem(item);
            }
            foreach (var itemKey in nodeUpdateValues.DeleteKeys)
            {
                DiagramDataProvider.DeleteItem(itemKey);
            }
            foreach (var item in nodeUpdateValues.Insert)
            {
                var key = DiagramDataProvider.InsertItem(item);
                nodeUpdateValues.MapInsertedItemKey(item, key);
            }

            return DiagramExtension.GetBatchUpdateResult(nodeUpdateValues);
        }
    }
}