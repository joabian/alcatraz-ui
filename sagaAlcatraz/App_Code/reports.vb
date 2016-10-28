Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Web.Script.Serialization

Public Class reports

    Public mysql As New mySqlConn()
    Public query As String
    Public query_result As String
    Public ds As DataSet


    Function ReportUsuariosConHuellas() As DataSet
        'query = "select usrs.numero_matricula,usrs.name,date(usrs.date_update) as date_update,usrs.username_update,fp.quality,fp.finger"
        'query += " from tb_user_fingerprint fp inner join sma_companies usrs on fp.customer_id = usrs.id"
        ' query += " order by date_update desc"
        'query += " limit 100"
        query = "SELECT name, first_name, last_name, phone, email  FROM sma_companies"
        query += " limit 100"
        ds = mysql.executeSQL_dset(query, query_result)

        Return ds
    End Function

    Function ReportClientesVencidos() As DataSet
        'query = "select usrs.numero_matricula,usrs.name,date(usrs.date_update) as date_update,usrs.username_update,fp.quality,fp.finger"
        'query += " from tb_user_fingerprint fp inner join sma_companies usrs on fp.customer_id = usrs.id"
        ' query += " order by date_update desc"
        'query += " limit 100"
        'query = "SELECT name, first_name, last_name, phone, email  FROM sma_companies"
        query = "SELECT customer, sale_status, payment_status, reference_no, fecha_inicio_membresia, fecha_fin_membresia FROM sma_sales"
        query += " limit 100"
        ds = mysql.executeSQL_dset(query, query_result)

        Return ds
    End Function



    Function DataSetToJSON(ds As DataSet) As String
        Dim dict As New Dictionary(Of String, Object)

        For Each dt As DataTable In ds.Tables
            Dim arr(dt.Rows.Count) As Object

            For i As Integer = 0 To dt.Rows.Count - 1
                arr(i) = dt.Rows(i).ItemArray
            Next

            dict.Add(dt.TableName, arr)
        Next

        Dim json As New JavaScriptSerializer
        Return json.Serialize(dict)
    End Function

End Class
