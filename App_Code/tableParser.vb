Imports Microsoft.VisualBasic
Imports System.Data

Public Class tableParser

    Function dsToHTML(ByVal ds As DataSet) As String
        Dim htmltable As String = "<table id='table'><thead><tr>"
        For j = 0 To ds.Tables(0).Columns.Count - 1
            htmltable += "<th>" + ds.Tables(0).Columns(j).ColumnName.ToString() + "</th>"
        Next
        htmltable += "</tr></thead><tbody>"
        For i = 0 To ds.Tables(0).Rows.Count - 1
            htmltable += "<tr>"
            For j = 0 To ds.Tables(0).Columns.Count - 1
                htmltable += "<td>" + ds.Tables(0).Rows(i)(j).ToString() + "</td>"
            Next
            htmltable += "</tr>"
        Next
        htmltable += "</tbody></table>"

        Return htmltable
    End Function

End Class
