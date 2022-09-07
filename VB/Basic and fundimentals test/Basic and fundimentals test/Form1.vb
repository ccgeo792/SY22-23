Public Class Form1
    Private Sub Buttoncancel_Click(sender As Object, e As EventArgs) Handles Buttoncancel.Click
        Me.Close()
    End Sub

    Private Sub Buttonbuy_Click(sender As Object, e As EventArgs) Handles Buttonbuy.Click
        Dim amount As Decimal
        TextBoxname.Clear()
        TextBoxexp.Clear()
        TextBoxnumber.Clear()
        TextBoxexp.Clear()
        TextBoxzip.Clear()
        TextBoxamt.Text = "$199.99"
    End Sub
End Class