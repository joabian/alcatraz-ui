Imports Microsoft.VisualBasic

Public Class Clientsvencer
    Public Property customer() As String
        Get
            Return m_customer
        End Get
        Set(ByVal value As String)
            m_customer = value
        End Set
    End Property
    Private m_customer As String


    Public Property sale_status() As String
        Get
            Return m_sale_status
        End Get
        Set(ByVal value As String)
            m_sale_status = value
        End Set
    End Property
    Private m_sale_status As String


    Public Property payment_status() As String
        Get
            Return m_payment_status
        End Get
        Set(ByVal value As String)
            m_payment_status = value
        End Set
    End Property
    Private m_payment_status As String


    Public Property reference_no() As String
        Get
            Return m_reference_no
        End Get
        Set(ByVal value As String)
            m_reference_no = value
        End Set
    End Property
    Private m_reference_no As String


    Public Property fecha_inicio_membresia() As String
        Get
            Return m_fecha_inicio_membresia
        End Get
        Set(ByVal value As String)
            m_fecha_inicio_membresia = value
        End Set
    End Property
    Private m_fecha_inicio_membresia As String



    Public Property fecha_fin_membresia() As String
        Get
            Return m_fecha_fin_membresia
        End Get
        Set(ByVal value As String)
            m_fecha_fin_membresia = value
        End Set
    End Property
    Private m_fecha_fin_membresia As String

End Class
