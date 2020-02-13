@Code
    ViewData("Title") = "Diagram for MVC - How to bind containers to an in-memory data source"
End Code

@ModelType IEnumerable(Of DiagramContainersVB.Item)

@Html.DevExpress().Diagram(Sub(settings)

                                    settings.Name = "Diagram"
                                    settings.BatchUpdateRouteValues = New With {.Controller = "Home", .Action = "DiagramUpdate"}

                                    settings.Width = Unit.Percentage(100)
                                    settings.Height = Unit.Pixel(600)

                                    settings.SimpleView = True

                                    settings.SettingsToolbox.Groups.Add(Sub(g)
                                                                            g.Category = DevExpress.Web.ASPxDiagram.DiagramShapeCategory.Containers
                                                                        End Sub)
                                    settings.SettingsToolbox.Groups.Add(Sub(g)
                                                                            g.Category = DevExpress.Web.ASPxDiagram.DiagramShapeCategory.General
                                                                        End Sub)

                                    settings.Mappings.Node.Key = "ID"
                                    settings.Mappings.Node.ContainerKey = "ContainerID"
                                    settings.Mappings.Node.Type = "Type"
                                    settings.Mappings.Node.Text = "Text"
                                    settings.Mappings.Node.Left = "X"
                                    settings.Mappings.Node.Top = "Y"
                                    settings.Mappings.Node.Width = "Width"
                                    settings.Mappings.Node.Height = "Height"
                                End Sub).Bind(Model).GetHtml()