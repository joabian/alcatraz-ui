Imports Microsoft.VisualBasic

Public Class Employee
    Public Property date_update() As String
        Get
            Return m_date_update
        End Get
        Set(value As String)
            m_date_update = value
        End Set
    End Property
    Private m_date_update As String
    Public Property numero_matricula() As String
        Get
            Return m_numero_matricula
        End Get
        Set(value As String)
            m_numero_matricula = value
        End Set
    End Property
    Private m_numero_matricula As String
    Public Property name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = Value
        End Set
    End Property
    Private m_name As String
    Public Property userupdate() As String
        Get
            Return m_userupdate
        End Get
        Set(value As String)
            m_userupdate = value
        End Set
    End Property
    Private m_userupdate As String
    Public Property calidad() As String
        Get
            Return m_calidad
        End Get
        Set(value As String)
            m_calidad = value
        End Set
    End Property
    Private m_calidad As String
    Public Property finger() As String
        Get
            Return m_finger
        End Get
        Set(value As String)
            m_finger = value
        End Set
    End Property
    Private m_finger As String

End Class
