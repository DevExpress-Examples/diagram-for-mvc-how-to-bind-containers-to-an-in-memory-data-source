Imports DevExpress.Web.Mvc

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View(DiagramDataProvider.GetItems())
    End Function

    Public Function DiagramUpdate(ByVal nodeUpdateValues As MVCxDiagramNodeUpdateValues(Of Item, Integer)) As ActionResult
        For Each item In nodeUpdateValues.Update
            DiagramDataProvider.UpdateItem(item)
        Next

        For Each itemKey In nodeUpdateValues.DeleteKeys
            DiagramDataProvider.DeleteItem(itemKey)
        Next

        For Each item In nodeUpdateValues.Insert
            Dim key = DiagramDataProvider.InsertItem(item)
            nodeUpdateValues.MapInsertedItemKey(item, key)
        Next

        Return DiagramExtension.GetBatchUpdateResult(nodeUpdateValues)
    End Function
End Class