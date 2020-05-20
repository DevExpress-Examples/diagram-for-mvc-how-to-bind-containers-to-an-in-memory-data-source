using DevExpress.Web.ASPxDiagram;

namespace DiagramContainers.Models
{
    public class Item
    {
        public int ID { set; get; }
        public int? ContainerID { set; get; }
        public string Type { set; get; }
        public string Text { set; get; }
        public double X { set; get; }
        public double Y { set; get; }
        public double Width { set; get; }
        public double Height { set; get; }

        public Item(int id, int? containerId, string type, string text, double x, double y, double width, double height)
        {
            ID = id;
            ContainerID = containerId;
            Type = type;
            Text = text;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public Item() { }
    }
}