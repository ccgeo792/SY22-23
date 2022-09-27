Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()
        Highlight(Color.Red)
    End Sub
    Sub Clear()
        TextBoxL.Clear()
        TextBoxW.Clear()
        LabelA.Text = ""
        LabelP.Text = ""
    End Sub
    Sub Highlight(C As Color)
        TextBoxL.BackColor = C
        TextBoxW.BackColor = C
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim length As Integer
        Dim width As Integer
        Integer.TryParse(TextBoxL.Text, length)
        Integer.TryParse(TextBoxW.Text, width)
        LabelA.Text = Area(length, width)
        LabelP.Text = Perimiter(length, width)
    End Sub
    Function Area(L As Integer, W As Integer)
        Return L * W
    End Function
    Function Perimiter(L As Integer, W As Integer)
        Return 2 * L + W
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, Button5.Click, Button4.Click, Button3.Click
        Highlight(sender.backcolor)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class