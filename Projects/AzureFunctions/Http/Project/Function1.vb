Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.Azure.WebJobs
Imports Microsoft.Azure.WebJobs.Extensions.Http
Imports Microsoft.AspNetCore.Http
Imports Microsoft.Extensions.Logging
Imports Microsoft.Extensions.Primitives

Public Module Function1
  <FunctionName("Function1")>
  Public Function Run(<HttpTrigger(AuthorizationLevel.Function, {"POST", "GET"}, Route:=Nothing)> Request As HttpRequest, Logger As ILogger) As IActionResult
    Dim oValue As StringValues
    Dim sName As String

    Logger.LogInformation("VB HTTP trigger function processed a request.")

    sName = "name"

    Select Case Request.Method.ToUpper
      Case "POST" : oValue = Request.Form(sName)
      Case "GET" : oValue = Request.Query(sName)
    End Select

    If oValue.Count = 0 OrElse oValue = String.Empty Then
      Run = New BadRequestObjectResult("You must pass a name on the query string or in the request body.")
    Else
      Run = New OkObjectResult($"Hello, {oValue}!")
    End If
  End Function
End Module
