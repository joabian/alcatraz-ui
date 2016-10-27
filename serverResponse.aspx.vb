Imports System.Data


Partial Class serverResponse
    Inherits System.Web.UI.Page

    Dim myfunction As String
    Dim reports As New reports()
    Dim tableParser As New tableParser()
    Dim reportData As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _REQUEST()
        If myfunction = "getUserInfo" Then getUserInfo()
        If myfunction = "getReportUsuariosConHuellas" Then getReportUsuariosConHuellas()
    End Sub

    Sub _REQUEST()
        myfunction = Request("option")
    End Sub

    Sub getUserInfo()
        Response.Write("")
    End Sub

    Sub getReportUsuariosConHuellas()
        'Dim myReport As String = "No data"
        'Dim reportData As DataSet = reports.ReportUsuariosConHuellas()
        'If reportData.Tables(0).Rows.Count > 0 Then
        '    myReport = tableParser.dsToHTML(reportData)
        'End If
        'Response.Write(myReport)
    End Sub

End Class
