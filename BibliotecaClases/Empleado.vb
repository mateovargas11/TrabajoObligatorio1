Public Class Empleado

    Private ci As Integer
    Private priNom As String
    Private priApe As String
    Private segApe As String
    Private direccion As String
    Private telefono As ArrayList
    Private tipoEmp As String
    Private sueldoBase As Double
    Private sueldoIncr As Double
    Private totalPagar As Double

    Public Sub New()
    End Sub
    Public Sub New(ci As String, tel As ArrayList)
        Me.ci = ci
        Me.telefono = telefono
    End Sub
    Public Sub New(ci As Integer, priNom As String, priApe As String, segApe As String, direccion As String, telefono As ArrayList, tipoEmp As String, sueldoBase As Double)
        Me.ci = ci
        Me.priNom = priNom
        Me.priApe = priApe
        Me.segApe = segApe
        Me.direccion = direccion
        Me.telefono = telefono
        Me.tipoEmp = tipoEmp
        Me.sueldoBase = sueldoBase
    End Sub

    Public Property propCi() As String
        Get
            Return ci
        End Get
        Set(value As String)
            Me.ci = value
        End Set
    End Property

    Public Property propPriNom() As String
        Get
            Return priNom
        End Get
        Set(value As String)
            Me.priNom = value
        End Set
    End Property

    Public Property propPriApe() As String
        Get
            Return priApe
        End Get
        Set(value As String)
            Me.priApe = value
        End Set
    End Property

    Public Property propSegApe() As String
        Get
            Return segApe
        End Get
        Set(value As String)
            Me.segApe = value
        End Set
    End Property

    Public Property propDireccion() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            Me.direccion = value
        End Set
    End Property

    Public Property propTel() As Integer
        Get
            Return telefono(0)
        End Get
        Set(value As Integer)
            Me.telefono(0) = value
        End Set
    End Property

    Public Property propTipoEmp() As String
        Get
            Return tipoEmp
        End Get
        Set(value As String)
            Me.tipoEmp = value
        End Set
    End Property

    Public Property propSueldoBase() As Double
        Get
            Return sueldoBase
        End Get
        Set(value As Double)
            Me.sueldoBase = value
        End Set
    End Property

    Public Property propSueldoIncr() As Double
        Get
            Return sueldoIncr
        End Get
        Set(value As Double)
            Me.sueldoIncr = value
        End Set
    End Property

    Public Property propTotalPagar() As Double
        Get
            Return totalPagar
        End Get
        Set(value As Double)
            Me.totalPagar = value
        End Set
    End Property

    Public Overrides Function toString() As String
        Return String.Format("cedula: " & ci & " Nombre: " & priNom & "  Apellido: " & priApe & " Sueldo a pagar:  " & sueldoIncr)
    End Function

    Public Function calcMonto(tipo As String, salario As Double) As Double
        Dim porciento As Double
        If tipo = "Gerente" Then
            porciento = salario * 0.97
            Me.sueldoIncr = (porciento + Me.sueldoBase)
            setTotal(Me.sueldoIncr)

        Else
            If tipo = "operarios" Then
                porciento = salario * 0.38
                Me.sueldoIncr = (porciento + Me.sueldoBase)
                setTotal(sueldoIncr)

            Else
                porciento = salario * 0.27
                Me.sueldoIncr = (porciento + Me.sueldoBase)
                setTotal(sueldoIncr)

            End If
        End If

        Return Me.sueldoIncr
    End Function

    Public Sub AddTel(tel As ArrayList)
        Me.telefono.Add(tel)
    End Sub

    Public Function buscarTel(ci) As Boolean
        For i = 0 To telefono.Count
            If telefono(i).name = ci Then
                Return telefono(i)
            Else
                Return -1
            End If
        Next
    End Function

    Public Function getTotal() As Double
        Return Me.totalPagar
    End Function

    Public Function setTotal(money As Double)
        Me.totalPagar += money
        Return Me.totalPagar
    End Function

End Class
