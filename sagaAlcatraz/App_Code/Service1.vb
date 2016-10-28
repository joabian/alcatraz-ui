Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Services
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Script.Serialization


' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service1
    Inherits System.Web.Services.WebService

    Public mysql As New mySqlConn()
    Public query As String
    Public query_result As String
    Public ds As DataSet
    Dim reports As New reports()
    Public jsonSer As New jsonParser()


    <WebMethod()> _
    Public Sub GetAllEmployees()
        Dim listEmployees As New List(Of Employee)()
        Dim reportData As DataSet = reports.ReportUsuariosConHuellas()
        If reportData.Tables(0).Rows.Count > 0 Then
            For i = 0 To reportData.Tables(0).Rows.Count - 1
                Dim employee As Employee = New Employee()
                employee.date_update = reportData.Tables(0).Rows(i)("name").ToString()
                employee.numero_matricula = reportData.Tables(0).Rows(i)("phone").ToString()
                employee.name = reportData.Tables(0).Rows(i)("email").ToString()
                employee.userupdate = reportData.Tables(0).Rows(i)("username_update").ToString()
                employee.calidad = reportData.Tables(0).Rows(i)("memb_date_since").ToString()
                employee.finger = reportData.Tables(0).Rows(i)("finger").ToString()
                listEmployees.Add(employee)
            Next

            Dim js As JavaScriptSerializer = New JavaScriptSerializer()

            Context.Response.Write(js.Serialize(listEmployees))
        End If

    End Sub

    <WebMethod()> _
    Public Sub GetAllEmployees2()
        'Dim reportData As DataSet = reports.testData()
        Dim reportData As DataSet = reports.ReportUsuariosConHuellas()
        If reportData.Tables(0).Rows.Count > 0 Then
            'Context.Response.Write(reports.DataSetToJSON(reportData))
            Context.Response.Write(jsonSer.Serialize(reportData))
        End If
    End Sub

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod(Description:="This method converts a temperature in " & _
       "degrees Fahrenheit to a temperature in degrees Celsius.")> _
    Public Function ConvertTemperature(ByVal dFahrenheit As Double) As Double
        Return ((dFahrenheit - 32) * 5) / 9
    End Function



End Class