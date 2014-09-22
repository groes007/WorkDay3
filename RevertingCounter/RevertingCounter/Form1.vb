Option Strict On


Public Class Form1
    Dim Count As Double
    Private Sub btnCounter_Click(sender As System.Object, e As System.EventArgs) Handles btnCounter.Click

        Count = 1
        Count = Count * 2

        btnCounter.Text = CStr(count)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
