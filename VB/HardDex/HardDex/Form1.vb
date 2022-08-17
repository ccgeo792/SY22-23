Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBoxdisp.Image = PictureBoxcpu.Image
        LabelName.Text = "CPU"
        labelfunction.Text = "Process information from other components and does basic tasks"
        Labelprice.Text = "$50-$850"
        Labelreq.Text = "Yes"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBoxdisp.Image = PictureBoxgpu.Image
        LabelName.Text = "GPU"
        labelfunction.Text = "Process graphical information only. Does complex equations fast"
        Labelprice.Text = "$100-$2500"
        Labelreq.Text = "No"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBoxdisp.Image = PictureBoxmobo.Image
        LabelName.Text = "GPU"
        labelfunction.Text = "Connects all components together. Remembers basic things like time"
        Labelprice.Text = "$80-$800"
        Labelreq.Text = "Yes"
    End Sub

    Private Sub Buttonram_Click(sender As Object, e As EventArgs) Handles Buttonram.Click
        PictureBoxdisp.Image = PictureBoxram.Image
        LabelName.Text = "RAM"
        labelfunction.Text = "Super fast hard drive, but small storage. Used for cache"
        Labelprice.Text = "$20-$250"
        Labelreq.Text = "Yes"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBoxdisp.Image = PictureBoxhdd.Image
        LabelName.Text = "HDD AKA Hard Drive"
        labelfunction.Text = "USed for storage of all things on computer. Size and speed vary"
        Labelprice.Text = "$20-$200"
        Labelreq.Text = "Yes"
    End Sub
End Class