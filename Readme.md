<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/240296406/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T862049)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Diagram for MVC - How to bind containers to an in-memory data source

This example demonstrates to bind the [Diagram](https://docs.devexpress.com/AspNetMvc/401417/components/diagram) extension to an in-memory data source and wrap shapes in horizontal and vertical containers. Use the [ContainerKey](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDiagram.DiagramNodeMappingInfo.ContainerKey) property to specify the name of a data source field that provides the key of a shape's parent container shape.

## Files to Review
* [Index.cshtml](./CS/DiagramContainers/Views/Home/Index.cshtml) (VB: [Index.vbhtml](./VB/DiagramContainersVB/Views/Home/Index.vbhtml))
* [HomeController.cs](./CS/DiagramContainers/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DiagramContainersVB/Controllers/HomeController.vb))
* [Item.cs](./CS/DiagramContainers/Models/Item.cs) (VB: [Item.vb](./VB/DiagramContainersVB/Models/Item.vb))
* [DiagramDataProvider.cs](./CS/DiagramContainers/Models/DiagramDataProvider.cs) (VB: [DiagramDataProvider.vb](./VB/DiagramContainersVB/Models/DiagramDataProvider.vb))

## More Examples
* [Diagram for MVC - Node and Edge data sources - How to bind the extension to in-memory data sources](https://github.com/DevExpress-Examples/diagram-for-mvc-node-and-edge-data-sources-how-to-bind-the-extension-to-in-memory-data-sources)  
* [Diagram for MVC - Tree from Linear Data Structure - How to bind the extension to an in-memory data source](https://github.com/DevExpress-Examples/diagram-for-mvc-tree-from-linear-data-structure-how-to-bind-to-an-in-memory-data-source)
