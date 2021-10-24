Public Class Form1
    Dim diry As Integer
    Dim obj_ascensor As New ascensor()
    Dim piso As Integer
    Dim standby As Boolean

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        obj_ascensor.Asignar(pic_elevator)
        obj_ascensor.pisos(piso)
        obj_ascensor.standby(standby)

        standby = False
        piso = 0
        diry = -5
    End Sub

    Private Sub chk_pb_CheckedChanged(sender As Object, e As EventArgs) Handles chk_pb.CheckedChanged
        piso = 0
        obj_ascensor.pisos(piso)
    End Sub

    Private Sub chk_piso1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_piso1.CheckedChanged
        piso = 1
        obj_ascensor.pisos(piso)
    End Sub

    Private Sub chk_piso2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_piso2.CheckedChanged
        piso = 2
        obj_ascensor.pisos(piso)
    End Sub

    Private Sub chk_piso3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_piso3.CheckedChanged
        piso = 3
        obj_ascensor.pisos(piso)
    End Sub

    Private Sub chk_up_CheckedChanged(sender As Object, e As EventArgs) Handles chk_up.CheckedChanged
        standby = True
        Timer1.Enabled = True
        chk_down.Checked = False
    End Sub

    Private Sub chk_down_CheckedChanged(sender As Object, e As EventArgs) Handles chk_down.CheckedChanged
        standby = True
        Timer1.Enabled = True
        chk_up.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        obj_ascensor.Mover(diry)
        obj_ascensor.pisos(piso)
        pic_elevator.BackColor = Color.SpringGreen

        If standby = True Then

            Timer1.Start()
            pic_elevator.BackColor = Color.Red

            If obj_ascensor.Y = 250 And piso = 1 Then
                Timer1.Stop()
                pic_elevator.BackColor = Color.SpringGreen
            End If

            If obj_ascensor.Y = 150 And piso = 2 Then
                Timer1.Stop()
                pic_elevator.BackColor = Color.SpringGreen
            End If

            If obj_ascensor.Y = 50 And piso = 3 Then
                Timer1.Stop()
                pic_elevator.BackColor = Color.SpringGreen
                diry = -diry
            End If

            If obj_ascensor.Y = 350 And piso = 0 Then
                Timer1.Stop()
                pic_elevator.BackColor = Color.SpringGreen
                diry = -diry
            End If


        End If







    End Sub


End Class
