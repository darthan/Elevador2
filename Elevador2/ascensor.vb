Public Class ascensor
    Private ascensor As PictureBox
    Public Sub Asignar(pic As PictureBox)
        ascensor = pic
    End Sub


    Private Property X As Integer
        Get
            Return ascensor.Location.X
        End Get
        Set(value As Integer)
            ascensor.Location = New Point(value, Y)

        End Set
    End Property

    Public Property Y As Integer

        Get
            Return ascensor.Location.Y
        End Get
        Set(value As Integer)
            ascensor.Location = New Point(X, value)
        End Set
    End Property

    Public Sub Mover()

        ascensor.Location = New Point(X, Y - 10)

    End Sub

    Public Sub Mover(diy As Integer)
        'ascensor.Location = New Point(X, Y + diy)
        Y += diy


    End Sub

    Public Sub pisos(p As Integer)
        Dim piso = New String() {"PB", "1", "2", "3"}

        For i = 0 To piso.Length
            piso(p) = i
        Next

    End Sub


End Class
