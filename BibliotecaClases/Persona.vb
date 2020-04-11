Public Class Persona

    Private lista As List(Of Empleado)
    Private contactos As ArrayList


    Public Sub New()
        lista = New List(Of Empleado)
        contactos = New ArrayList()
    End Sub

    Public Property propList() As List(Of Empleado)
        Get
            Return lista
        End Get
        Set(value As List(Of Empleado))
            lista = value
        End Set
    End Property

    Public Property propContactos() As ArrayList
        Get
            Return contactos
        End Get
        Set(value As ArrayList)
            Me.contactos = value
        End Set
    End Property

    Public Function Listsize() As Integer
        Return lista.Count()
    End Function

    Public Function add(empleado As Empleado)
        lista.Add(empleado)
    End Function

    Public Sub verLista()
        For Each i In lista
            Console.WriteLine("{0} ", i)
        Next i
    End Sub





End Class
