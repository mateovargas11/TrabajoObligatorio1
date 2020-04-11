Imports System
Imports BibliotecaClases

Module Program
    Sub Main(args As String())

        Dim salario As Double
        Dim op, opC, opTel As String
        Dim ced As Integer
        Dim tel As ArrayList = New ArrayList
        Dim nombre, pApe, sApe, dir As String
        Dim persona As New Persona()
        Dim emp As New Empleado()

        Do
            Console.WriteLine("Bienvenido!")
            Console.WriteLine("1.Registro de empleado")
            Console.WriteLine("2.Importe total a pagar")
            'Console.WriteLine("3. Ver contactos por empleado")
            Console.WriteLine("0.Salir")
            op = Console.ReadLine()

            Select Case op
                Case 1
                    Console.WriteLine("Ingrese cedula de identidad")
                    ced = Console.ReadLine()
                    tel.Add(ced)

                    Console.WriteLine("Ingrese Primer Nombre: ")
                    nombre = Console.ReadLine()

                    Console.WriteLine("Ingrese Primer Apellido: ")
                    pApe = Console.ReadLine()

                    Console.WriteLine("Ingrese Segundo Apellido: ")
                    sApe = Console.ReadLine()

                    Console.WriteLine("Ingrese domocilio: ")
                    dir = Console.ReadLine()

                    Console.WriteLine("Ingrese contacto: ")
                    tel.Add(Console.ReadLine())
                    Console.WriteLine("Desea agregar alguno mas? ")
                    Console.WriteLine("1.Si")
                    Console.WriteLine("2.No")
                    opTel = Console.ReadLine()
                    If opTel = "1" Then
                        Console.WriteLine("Cuantos numeros de contacto desea agregar?")
                        Dim cantTel As Integer = Console.ReadLine()
                        For i As Integer = 0 To cantTel - 1
                            Console.Write("ingrese el telefono " & (i + 1) & ": ")
                            tel.Add(Console.ReadLine())
                        Next
                    End If

                    Console.WriteLine("Ingrese sueldo: ")
                    salario = Console.ReadLine()

                    Console.WriteLine("Ingrese el cargo del empleado:")
                    Console.WriteLine("1.Gerente")
                    Console.WriteLine("2.Operario")
                    Console.WriteLine("3.Administrativo")
                    opC = Console.ReadLine()

                    Select Case opC
                        Case 1
                            Dim ger As New Empleado(ced, nombre, pApe, sApe, dir, tel, "Gerente", salario)
                            emp.setTotal(ger.calcMonto("Gerente", salario))
                            persona.add(ger)
                            If opTel = "1" Then
                                emp.AddTel(tel)
                            End If
                            tel.Clear()

                        Case 2
                            Dim oper As New Empleado(ced, nombre, pApe, sApe, dir, tel, "Operario", salario)
                            emp.setTotal(oper.calcMonto("Operario", salario))
                            persona.add(oper)
                            If opTel = "1" Then
                                emp.AddTel(tel)
                            End If
                            tel.Clear()

                        Case 3
                            Dim admin As New Empleado(ced, nombre, pApe, sApe, dir, tel, "Administrativo", salario)
                            emp.setTotal(admin.calcMonto("Administrativo", salario))
                            persona.add(admin)
                            If opTel = "1" Then
                                emp.AddTel(tel)
                            End If
                            tel.Clear()

                        Case 0

                        Case Else
                            Console.WriteLine("ingrese un cargo valido!")
                    End Select

                Case 2
                    persona.verLista()
                    Console.WriteLine("Total a pagar: " & emp.propTotalPagar())

                Case 3
                    'Work in progress
                    'Console.WriteLine("Ingrese la cedula del empleado: ")
                    'ced = Console.ReadLine()
                    'Console.WriteLine(emp.buscarTel(ced))

                Case Else
                    Console.WriteLine("ingrese un valor correcto!")

            End Select

        Loop While (op <> "0")
    End Sub
End Module
