<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewData("Title")</title>

    @Html.DevExpress().GetStyleSheets(
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout },
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors },
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.Diagram }
    )
    @Html.DevExpress().GetScripts(
        New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout },
        New Script With {.ExtensionSuite = ExtensionSuite.Editors },
        New Script With {.ExtensionSuite = ExtensionSuite.Diagram }
    )
</head>

<body>
    @RenderBody()
</body>
</html>