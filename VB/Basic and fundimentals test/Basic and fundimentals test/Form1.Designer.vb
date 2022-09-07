<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxname = New System.Windows.Forms.TextBox()
        Me.TextBoxnumber = New System.Windows.Forms.TextBox()
        Me.TextBoxexp = New System.Windows.Forms.TextBox()
        Me.TextBoxamt = New System.Windows.Forms.TextBox()
        Me.TextBoxzip = New System.Windows.Forms.TextBox()
        Me.Buttonbuy = New System.Windows.Forms.Button()
        Me.Buttoncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name on Card:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Card Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Expiration Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Zip Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount:"
        '
        'TextBoxname
        '
        Me.TextBoxname.Location = New System.Drawing.Point(130, 6)
        Me.TextBoxname.Name = "TextBoxname"
        Me.TextBoxname.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxname.TabIndex = 5
        '
        'TextBoxnumber
        '
        Me.TextBoxnumber.Location = New System.Drawing.Point(130, 34)
        Me.TextBoxnumber.Name = "TextBoxnumber"
        Me.TextBoxnumber.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxnumber.TabIndex = 6
        '
        'TextBoxexp
        '
        Me.TextBoxexp.Location = New System.Drawing.Point(130, 65)
        Me.TextBoxexp.Name = "TextBoxexp"
        Me.TextBoxexp.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxexp.TabIndex = 7
        '
        'TextBoxamt
        '
        Me.TextBoxamt.Location = New System.Drawing.Point(130, 121)
        Me.TextBoxamt.Name = "TextBoxamt"
        Me.TextBoxamt.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxamt.TabIndex = 8
        Me.TextBoxamt.Text = "$199.99"
        '
        'TextBoxzip
        '
        Me.TextBoxzip.Location = New System.Drawing.Point(130, 93)
        Me.TextBoxzip.Name = "TextBoxzip"
        Me.TextBoxzip.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxzip.TabIndex = 9
        '
        'Buttonbuy
        '
        Me.Buttonbuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttonbuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonbuy.Location = New System.Drawing.Point(70, 167)
        Me.Buttonbuy.Name = "Buttonbuy"
        Me.Buttonbuy.Size = New System.Drawing.Size(126, 50)
        Me.Buttonbuy.TabIndex = 11
        Me.Buttonbuy.Text = "Purchase"
        Me.Buttonbuy.UseVisualStyleBackColor = False
        '
        'Buttoncancel
        '
        Me.Buttoncancel.BackColor = System.Drawing.Color.Firebrick
        Me.Buttoncancel.Location = New System.Drawing.Point(90, 223)
        Me.Buttoncancel.Name = "Buttoncancel"
        Me.Buttoncancel.Size = New System.Drawing.Size(85, 28)
        Me.Buttoncancel.TabIndex = 12
        Me.Buttoncancel.Text = "Cancel"
        Me.Buttoncancel.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(252, 263)
        Me.Controls.Add(Me.Buttoncancel)
        Me.Controls.Add(Me.Buttonbuy)
        Me.Controls.Add(Me.TextBoxzip)
        Me.Controls.Add(Me.TextBoxamt)
        Me.Controls.Add(Me.TextBoxexp)
        Me.Controls.Add(Me.TextBoxnumber)
        Me.Controls.Add(Me.TextBoxname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Buy Now!"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxname As TextBox
    Friend WithEvents TextBoxnumber As TextBox
    Friend WithEvents TextBoxexp As TextBox
    Friend WithEvents TextBoxamt As TextBox
    Friend WithEvents TextBoxzip As TextBox
    Friend WithEvents Buttonbuy As Button
    Friend WithEvents Buttoncancel As Button
End Class
