Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim decaf As Decimal
        Dim normal As Decimal
        Dim Totallbs As Decimal
        Dim Price As Decimal
        Decimal.TryParse(TextBox3.Text, normal)
        Decimal.TryParse(TextBox2.Text, decaf)
        Totallbs = decaf + normal
        Price = Totallbs * 4.99
        TextBox4.Text = Totallbs
        TextBox1.Text = Price
    End Sub
End Class