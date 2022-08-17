<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.labelfunction = New System.Windows.Forms.Label()
        Me.Labelprice = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Buttonram = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBoxhdd = New System.Windows.Forms.PictureBox()
        Me.PictureBoxram = New System.Windows.Forms.PictureBox()
        Me.PictureBoxmobo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxcpu = New System.Windows.Forms.PictureBox()
        Me.PictureBoxgpu = New System.Windows.Forms.PictureBox()
        Me.PictureBoxdisp = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Labelreq = New System.Windows.Forms.Label()
        CType(Me.PictureBoxhdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxmobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxcpu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxgpu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxdisp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CPU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(738, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(738, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Function"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(738, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Average Price"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(738, 25)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(0, 16)
        Me.LabelName.TabIndex = 7
        '
        'labelfunction
        '
        Me.labelfunction.AutoSize = True
        Me.labelfunction.Location = New System.Drawing.Point(738, 75)
        Me.labelfunction.Name = "labelfunction"
        Me.labelfunction.Size = New System.Drawing.Size(0, 16)
        Me.labelfunction.TabIndex = 8
        '
        'Labelprice
        '
        Me.Labelprice.AutoSize = True
        Me.Labelprice.Location = New System.Drawing.Point(738, 127)
        Me.Labelprice.Name = "Labelprice"
        Me.Labelprice.Size = New System.Drawing.Size(0, 16)
        Me.Labelprice.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "GPU"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Motherboard"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Buttonram
        '
        Me.Buttonram.Location = New System.Drawing.Point(291, 424)
        Me.Buttonram.Name = "Buttonram"
        Me.Buttonram.Size = New System.Drawing.Size(75, 23)
        Me.Buttonram.TabIndex = 14
        Me.Buttonram.Text = "RAM"
        Me.Buttonram.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(372, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "HDD"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBoxhdd
        '
        Me.PictureBoxhdd.Image = CType(resources.GetObject("PictureBoxhdd.Image"), System.Drawing.Image)
        Me.PictureBoxhdd.Location = New System.Drawing.Point(365, 546)
        Me.PictureBoxhdd.Name = "PictureBoxhdd"
        Me.PictureBoxhdd.Size = New System.Drawing.Size(82, 10)
        Me.PictureBoxhdd.TabIndex = 17
        Me.PictureBoxhdd.TabStop = False
        Me.PictureBoxhdd.Visible = False
        '
        'PictureBoxram
        '
        Me.PictureBoxram.Image = CType(resources.GetObject("PictureBoxram.Image"), System.Drawing.Image)
        Me.PictureBoxram.Location = New System.Drawing.Point(278, 546)
        Me.PictureBoxram.Name = "PictureBoxram"
        Me.PictureBoxram.Size = New System.Drawing.Size(82, 10)
        Me.PictureBoxram.TabIndex = 15
        Me.PictureBoxram.TabStop = False
        Me.PictureBoxram.Visible = False
        '
        'PictureBoxmobo
        '
        Me.PictureBoxmobo.Image = CType(resources.GetObject("PictureBoxmobo.Image"), System.Drawing.Image)
        Me.PictureBoxmobo.Location = New System.Drawing.Point(190, 546)
        Me.PictureBoxmobo.Name = "PictureBoxmobo"
        Me.PictureBoxmobo.Size = New System.Drawing.Size(82, 10)
        Me.PictureBoxmobo.TabIndex = 13
        Me.PictureBoxmobo.TabStop = False
        Me.PictureBoxmobo.Visible = False
        '
        'PictureBoxcpu
        '
        Me.PictureBoxcpu.Image = CType(resources.GetObject("PictureBoxcpu.Image"), System.Drawing.Image)
        Me.PictureBoxcpu.Location = New System.Drawing.Point(12, 546)
        Me.PictureBoxcpu.Name = "PictureBoxcpu"
        Me.PictureBoxcpu.Size = New System.Drawing.Size(82, 10)
        Me.PictureBoxcpu.TabIndex = 11
        Me.PictureBoxcpu.TabStop = False
        Me.PictureBoxcpu.Visible = False
        '
        'PictureBoxgpu
        '
        Me.PictureBoxgpu.Image = CType(resources.GetObject("PictureBoxgpu.Image"), System.Drawing.Image)
        Me.PictureBoxgpu.Location = New System.Drawing.Point(102, 546)
        Me.PictureBoxgpu.Name = "PictureBoxgpu"
        Me.PictureBoxgpu.Size = New System.Drawing.Size(82, 10)
        Me.PictureBoxgpu.TabIndex = 3
        Me.PictureBoxgpu.TabStop = False
        Me.PictureBoxgpu.Visible = False
        '
        'PictureBoxdisp
        '
        Me.PictureBoxdisp.Location = New System.Drawing.Point(12, 13)
        Me.PictureBoxdisp.Name = "PictureBoxdisp"
        Me.PictureBoxdisp.Size = New System.Drawing.Size(720, 405)
        Me.PictureBoxdisp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxdisp.TabIndex = 2
        Me.PictureBoxdisp.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(738, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Required to run"
        '
        'Labelreq
        '
        Me.Labelreq.AutoSize = True
        Me.Labelreq.Location = New System.Drawing.Point(741, 182)
        Me.Labelreq.Name = "Labelreq"
        Me.Labelreq.Size = New System.Drawing.Size(0, 16)
        Me.Labelreq.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1180, 456)
        Me.Controls.Add(Me.Labelreq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBoxhdd)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBoxram)
        Me.Controls.Add(Me.Buttonram)
        Me.Controls.Add(Me.PictureBoxmobo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBoxcpu)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Labelprice)
        Me.Controls.Add(Me.labelfunction)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxgpu)
        Me.Controls.Add(Me.PictureBoxdisp)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "HardDex"
        CType(Me.PictureBoxhdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxmobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxcpu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxgpu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxdisp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBoxdisp As PictureBox
    Friend WithEvents PictureBoxgpu As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents labelfunction As Label
    Friend WithEvents Labelprice As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBoxcpu As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBoxmobo As PictureBox
    Friend WithEvents Buttonram As Button
    Friend WithEvents PictureBoxram As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBoxhdd As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Labelreq As Label
End Class
