Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dollars As Decimal
        Decimal.TryParse(TextBoxinp.Text, Dollars)

        Dim Pesos As Decimal
        Pesos = Dollars * 19.99
        TextBoxout.Text = Pesos.ToString("n2")

        Dim AuDollars As Decimal
        AuDollars = Dollars * 1.45
        TextBoxau.Text = AuDollars.ToString("n2")

        Dim Rubles As Decimal
        Rubles = Dollars * 61
        TextBoxru.Text = Rubles.ToString("n2")

        Dim Yen As Decimal
        Yen = Dollars * 137.45
        TextBoxjap.Text = Yen.ToString("n2")

        Dim Rupee As Decimal
        Rupee = Dollars * 79.94
        TextBoxind.Text = Rupee.ToString("n2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class