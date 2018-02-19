Public Class Form1
    Dim Flag As Boolean = False
    Dim PosX As Integer
    Dim PosY As Integer
    Private Sub Label1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        Flag = True
        PosX = Windows.Forms.Cursor.Position.X - Me.Left
        PosY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If Flag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - PosY
            Me.Left = Windows.Forms.Cursor.Position.X - PosX
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        Flag = False
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DTP1.Value = New Date(2013, 2, 26)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim myDate As DateTime = DTP1.Value.Date + DTP2.Value.TimeOfDay
        Dim a = 0
    End Sub
End Class
