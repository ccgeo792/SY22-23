Public Class Form1
    Dim First As Decimal
    Dim Second As Decimal
    Dim Oper As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Buttondot.Click, Button0.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        TextBoxdisp.Text = sender.text
    End Sub
    Private Sub Buttonclr_Click(sender As Object, e As EventArgs) Handles Buttonclr.Click
        TextBoxdisp.Clear()
    End Sub
    Private Sub Buttonplus_Click(sender As Object, e As EventArgs) Handles Buttonplus.Click
        Decimal.TryParse(TextBoxdisp.Text, First)
        Oper = sender.text
        TextBoxdisp.Clear()
    End Sub
    Private Sub Buttonequ_Click(sender As Object, e As EventArgs) Handles Buttonequ.Click
        Decimal.TryParse(TextBoxdisp.Text, Second)
        If Oper = "+" Then
            TextBoxdisp.Text = First + Second
        End If
        If Oper = "-" Then
            TextBoxdisp.Text = First - Second
        End If
        If Oper = "X" Then
            TextBoxdisp.Text = First * Second
        End If
        If Oper = "/" Then
            TextBoxdisp.Text = First / Second
        End If
    End Sub
    Private Sub Buttonminus_Click(sender As Object, e As EventArgs) Handles Buttonminus.Click
        Decimal.TryParse(TextBoxdisp.Text, First)
        Oper = sender.text
        TextBoxdisp.Clear()
    End Sub
    Private Sub Buttonmult_Click(sender As Object, e As EventArgs) Handles Buttonmult.Click
        Decimal.TryParse(TextBoxdisp.Text, First)
        Oper = sender.text
        TextBoxdisp.Clear()
    End Sub
    Private Sub Buttondiv_Click(sender As Object, e As EventArgs) Handles Buttondiv.Click
        Decimal.TryParse(TextBoxdisp.Text, First)
        Oper = sender.text
        TextBoxdisp.Clear()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Decimal.TryParse(TextBoxdisp.Text, First)
        TextBoxdisp.Text = Math.Sqrt(First)
    End Sub
End Class