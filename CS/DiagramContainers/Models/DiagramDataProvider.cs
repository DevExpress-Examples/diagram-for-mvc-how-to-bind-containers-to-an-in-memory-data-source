using DevExpress.Web.ASPxDiagram;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagramContainers.Models
{
    public class DiagramDataProvider
    {
        private static List<Item> Items
        {
            get
            {
                var data = HttpContext.Current.Session["DiagramNodes"] as List<Item>;
                if (data == null)
                {
                    data = new List<Item>
                    {
                        new Item(1, null, DiagramShapeType.VerticalContainer.ToString(), "Development", 0.5, 0.5, 7.25, 5),
                        new Item(2, 1, DiagramShapeType.VerticalContainer.ToString(), "ASP.NET Team", 0.75, 1, 1.5, 4),
                        new Item(3, 1, DiagramShapeType.VerticalContainer.ToString(), "JavaScript Team", 2.5, 1, 1.5, 4),
                        new Item(4, 1, DiagramShapeType.VerticalContainer.ToString(), "WPF Team", 4.25, 1, 1.5, 4),
                        new Item(5, 1, DiagramShapeType.VerticalContainer.ToString(), "WinForms Team", 6, 1, 1.5, 4),
                        new Item(6, 2, DiagramShapeType.Rectangle.ToString(), "Laurence Lebihan", 1, 1.5, 1, 0.75),
                        new Item(7, 2, DiagramShapeType.Rectangle.ToString(), "Elizabeth Lincoln", 1, 2.5, 1, 0.75),
                        new Item(8, 3, DiagramShapeType.Rectangle.ToString(), "Patricio Simpson", 2.75, 1.5, 1, 0.75),
                        new Item(9, 3, DiagramShapeType.Rectangle.ToString(), "Francisco Chang", 2.75, 2.5, 1, 0.75),
                        new Item(10, 4, DiagramShapeType.Rectangle.ToString(), "Christina Berglund", 4.5, 1.5, 1, 0.75),
                        new Item(11, 4, DiagramShapeType.Rectangle.ToString(), "Hanna Moos", 4.5, 2.5, 1, 0.75),
                        new Item(12, 4, DiagramShapeType.Rectangle.ToString(), "Frederique Citeaux", 4.5, 3.5, 1, 0.75),
                        new Item(13, 5, DiagramShapeType.Rectangle.ToString(), "Ana Trujillo", 6.25, 1.5, 1, 0.75),
                        new Item(14, 5, DiagramShapeType.Rectangle.ToString(), "Antonio Moreno", 6.25, 2.5, 1, 0.75)
                    };
                    HttpContext.Current.Session["DiagramNodes"] = data;
                }
                return data;
            }
        }

        public static List<Item> GetItems()
        {
            return Items;
        }

        public static int InsertItem(Item item)
        {
            item.ID = Items.Count == 0 ? 1 : Items.Max(i => i.ID) + 1;
            Items.Add(item);
            return item.ID;
        }

        public static void UpdateItem(Item item)
        {
            var itemToUpdate = Items.Find(i => i.ID == item.ID);
            itemToUpdate.ContainerID = item.ContainerID;
            itemToUpdate.Type = item.Type;
            itemToUpdate.Text = item.Text;
            itemToUpdate.X = item.X;
            itemToUpdate.Y = item.Y;
            itemToUpdate.Width = item.Width;
            itemToUpdate.Height = item.Height;
        }

        public static void DeleteItem(int key)
        {
            Items.RemoveAll(x => x.ID == key);
        }
    }
}