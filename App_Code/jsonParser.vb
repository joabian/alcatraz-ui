Imports Microsoft.VisualBasic
Imports System.Data
Imports Newtonsoft.Json
Imports System.IO


Public Class jsonParser

    Public Function Serialize(myds As DataSet) As String
        Dim type As Type = myds.[GetType]()

        Dim json As New Newtonsoft.Json.JsonSerializer()

        json.NullValueHandling = NullValueHandling.Ignore

        json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace
        json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore
        json.ReferenceLoopHandling = ReferenceLoopHandling.Ignore

        Dim sw As New StringWriter()
        Dim writer As Newtonsoft.Json.JsonTextWriter = New JsonTextWriter(sw)
        writer.Formatting = Formatting.None
        
        writer.QuoteChar = """"c
        json.Serialize(writer, myds)

        Dim output As String = sw.ToString()
        writer.Close()
        sw.Close()

        Return output
    End Function

    Public Function Deserialize(jsonText As String, valueType As Type) As Object
        Dim json As New Newtonsoft.Json.JsonSerializer()

        json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
        json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace
        json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore
        json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore

        Dim sr As New StringReader(jsonText)
        Dim reader As Newtonsoft.Json.JsonTextReader = New JsonTextReader(sr)
        Dim result As Object = json.Deserialize(reader, valueType)
        reader.Close()

        Return result
    End Function

End Class
