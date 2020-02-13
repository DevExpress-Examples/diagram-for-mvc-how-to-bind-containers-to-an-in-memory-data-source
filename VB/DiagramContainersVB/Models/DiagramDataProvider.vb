Imports DevExpress.Web.ASPxDiagram

Public Class DiagramDataProvider
    Private Shared ReadOnly Property Items As List(Of Item)
        Get
            Dim data = TryCast(HttpContext.Current.Session("DiagramNodes"), List(Of Item))

            If data Is Nothing Then
                data = New List(Of Item) From {
                    New Item(1, Nothing, DiagramShapeType.VerticalContainer, "Development", 0.5, 0.5, 7.25, 5),
                    New Item(2, 1, DiagramShapeType.VerticalContainer, "ASP.NET Team", 0.75, 1, 1.5, 4),
                    New Item(3, 1, DiagramShapeType.VerticalContainer, "JavaScript Team", 2.5, 1, 1.5, 4),
                    New Item(4, 1, DiagramShapeType.VerticalContainer, "WPF Team", 4.25, 1, 1.5, 4),
                    New Item(5, 1, DiagramShapeType.VerticalContainer, "WinForms Team", 6, 1, 1.5, 4),
                    New Item(6, 2, DiagramShapeType.Rectangle, "Laurence Lebihan", 1, 1.5, 1, 0.75),
                    New Item(7, 2, DiagramShapeType.Rectangle, "Elizabeth Lincoln", 1, 2.5, 1, 0.75),
                    New Item(8, 3, DiagramShapeType.Rectangle, "Patricio Simpson", 2.75, 1.5, 1, 0.75),
                    New Item(9, 3, DiagramShapeType.Rectangle, "Francisco Chang", 2.75, 2.5, 1, 0.75),
                    New Item(10, 4, DiagramShapeType.Rectangle, "Christina Berglund", 4.5, 1.5, 1, 0.75),
                    New Item(11, 4, DiagramShapeType.Rectangle, "Hanna Moos", 4.5, 2.5, 1, 0.75),
                    New Item(12, 4, DiagramShapeType.Rectangle, "Frederique Citeaux", 4.5, 3.5, 1, 0.75),
                    New Item(13, 5, DiagramShapeType.Rectangle, "Ana Trujillo", 6.25, 1.5, 1, 0.75),
                    New Item(14, 5, DiagramShapeType.Rectangle, "Antonio Moreno", 6.25, 2.5, 1, 0.75)
                }
                HttpContext.Current.Session("DiagramNodes") = data
            End If

            Return data
        End Get
    End Property

    Public Shared Function GetItems() As List(Of Item)
        Return Items
    End Function

    Public Shared Function InsertItem(ByVal item As Item) As Integer
        item.ID = If(Items.Count = 0, 1, Items.Max(Function(i) i.ID) + 1)
        Items.Add(item)
        Return item.ID
    End Function

    Public Shared Sub UpdateItem(ByVal item As Item)
        Dim itemToUpdate = Items.Find(Function(i) i.ID = item.ID)
        itemToUpdate.ContainerID = item.ContainerID
        itemToUpdate.Type = item.Type
        itemToUpdate.Text = item.Text
        itemToUpdate.X = item.X
        itemToUpdate.Y = item.Y
        itemToUpdate.Width = item.Width
        itemToUpdate.Height = item.Height
    End Sub

    Public Shared Sub DeleteItem(ByVal key As Integer)
        Items.RemoveAll(Function(x) x.ID = key)
    End Sub
End Class
