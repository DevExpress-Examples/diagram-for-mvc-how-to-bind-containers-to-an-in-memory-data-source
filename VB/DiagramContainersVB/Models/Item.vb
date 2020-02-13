Imports DevExpress.Web.ASPxDiagram

Public Class Item
    Public Property ID As Integer
    Public Property ContainerID As Integer?
    Public Property Type As DiagramShapeType
    Public Property Text As String
    Public Property X As Double
    Public Property Y As Double
    Public Property Width As Double
    Public Property Height As Double

    Public Sub New(ByVal id As Integer, ByVal containerId As Integer?, ByVal type As DiagramShapeType, ByVal text As String, ByVal x As Double, ByVal y As Double, ByVal width As Double, ByVal height As Double)
        Me.ID = id
        Me.ContainerID = containerId
        Me.Type = type
        Me.Text = text
        Me.X = x
        Me.Y = y
        Me.Width = width
        Me.Height = height
    End Sub

    Public Sub New()
    End Sub
End Class

