Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Price As Decimal
        Decimal.TryParse(TextBox1.Text, Price)
        Dim Total As Decimal

        If RadioButton1.Checked Then
            Total = Price
        End If
        If RadioButton2.Checked Then
            Total = Price * 1.05
        End If
        If RadioButton3.Checked Then
            Total = Price * 1.1
        End If

        Labeltotal.Text = (Total * 1.0625).ToString("C2")
    End Sub
End Class