Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputred As Integer
        Dim inputgreen As Integer
        Dim inputblue As Integer

        Integer.TryParse(TextBox1.Text, inputred)
        Integer.TryParse(TextBox2.Text, inputgreen)
        Integer.TryParse(TextBox3.Text, inputblue)

        PictureBox1.BackColor = Color.FromArgb(inputred, inputblue, inputgreen)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
