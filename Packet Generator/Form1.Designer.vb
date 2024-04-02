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
        components = New ComponentModel.Container()
        ComboBox1 = New ComboBox()
        ImageList1 = New ImageList(components)
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(189, 164)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(177, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(407, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(369, 379)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(207, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 102)
        Button1.TabIndex = 2
        Button1.Text = "Generate and Print Packet"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 164)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(6, 135)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(167, 23)
        TextBox2.TabIndex = 4
        TextBox2.Text = "Please Enter Sales Order:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(189, 135)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(177, 23)
        TextBox3.TabIndex = 5
        TextBox3.Text = "Please Select Configuration:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 30F)
        TextBox4.Location = New Point(43, 33)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(306, 61)
        TextBox4.TabIndex = 6
        TextBox4.Text = "Packet Builder"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(6, 243)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(167, 23)
        TextBox5.TabIndex = 7
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(6, 323)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(167, 23)
        TextBox6.TabIndex = 8
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(6, 214)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(167, 23)
        TextBox7.TabIndex = 9
        TextBox7.Text = "Please Enter Kinetic Quote #:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(6, 294)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(167, 23)
        TextBox8.TabIndex = 10
        TextBox8.Text = "Please Enter FWC#:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(208, 350)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(116, 19)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Print CAD Packet"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Checked = True
        CheckBox2.CheckState = CheckState.Checked
        CheckBox2.Location = New Point(208, 375)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(123, 19)
        CheckBox2.TabIndex = 12
        CheckBox2.Text = "Print Panel Builder"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "NL-Packet Builder"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
