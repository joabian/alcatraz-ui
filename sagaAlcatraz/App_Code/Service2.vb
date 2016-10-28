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
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service2
    Inherits System.Web.Services.WebService

    Public mysql As New mySqlConn()
    Public query As String
    Public query_result As String
    Public ds As DataSet
    Dim reports As New reports()
    Public jsonSer As New jsonParser()


    <WebMethod()> _
    Public Sub GetAllEmployees()
        Dim listClientsvencer As New List(Of Clientsvencer)()
        Dim reportData As DataSet = reports.ReportUsuariosConHuellas()
        If reportData.Tables(0).Rows.Count > 0 Then
            For i = 0 To reportData.Tables(0).Rows.Count - 1
                Dim clientvencer As Clientsvencer = New Clientsvencer()
                clientvencer.customer = reportData.Tables(0).Rows(i)("customer").ToString()
                clientvencer.payment_status = reportData.Tables(0).Rows(i)("payment_status").ToString()
                clientvencer.sale_status = reportData.Tables(0).Rows(i)("sale_status").ToString()
                clientvencer.reference_no = reportData.Tables(0).Rows(i)("reference_no").ToString()
                clientvencer.fecha_inicio_membresia = reportData.Tables(0).Rows(i)("fecha_inicio_membresia").ToString()
                clientvencer.fecha_fin_membresia = reportData.Tables(0).Rows(i)("fecha_fin_membresia").ToString()
                listClientsvencer.Add(clientvencer)
            Next

            Dim js As JavaScriptSerializer = New JavaScriptSerializer()

            Context.Response.Write(js.Serialize(listClientsvencer))
        End If

    End Sub

    <WebMethod()> _
    Public Sub GetAllEmployees2()
        'Dim reportData As DataSet = reports.testData()
        Dim reportData As DataSet = reports.ReportClientesVencidos()
        If reportData.Tables(0).Rows.Count > 0 Then
            'Context.Response.Write(reports.DataSetToJSON(reportData))
            Context.Response.Write(jsonSer.Serialize(reportData))
        End If
    End Sub

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

End Class