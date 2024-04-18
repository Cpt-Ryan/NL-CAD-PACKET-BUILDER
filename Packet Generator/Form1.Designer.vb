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
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        ToolTip1 = New ToolTip(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        CheckBox3 = New CheckBox()
        Label6 = New Label()
        ProgressBar1 = New ProgressBar()
        TESTBOX = New CheckBox()
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
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(407, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(369, 379)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(189, 215)
        Button1.Name = "Button1"
        Button1.Size = New Size(177, 77)
        Button1.TabIndex = 2
        Button1.Text = "Generate "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 164)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 3
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
        TextBox6.Location = New Point(6, 316)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(167, 23)
        TextBox6.TabIndex = 8
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(211, 298)
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
        CheckBox2.Location = New Point(211, 323)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(123, 19)
        CheckBox2.TabIndex = 12
        CheckBox2.Text = "Print Panel Builder"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 65)
        Label1.TabIndex = 13
        Label1.Text = "Packet Builder"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(189, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 15)
        Label2.TabIndex = 14
        Label2.Text = "Please Select Configuration:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 15)
        Label3.TabIndex = 15
        Label3.Text = "Please Enter Sales Order:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 15)
        Label4.TabIndex = 16
        Label4.Text = "Please Enter Kinetic Quote #:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 15)
        Label5.TabIndex = 17
        Label5.Text = "Please Enter FWC #:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(6, 390)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(167, 23)
        TextBox2.TabIndex = 18
        TextBox2.Visible = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(674, 422)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(91, 19)
        CheckBox3.TabIndex = 19
        CheckBox3.Text = "Robs Button"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 369)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 15)
        Label6.TabIndex = 20
        Label6.Text = "Schedule #:"
        Label6.Visible = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(6, 419)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(662, 23)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 21
        ProgressBar1.Tag = "Processing"
        ProgressBar1.Visible = False
        ' 
        ' TESTBOX
        ' 
        TESTBOX.AutoSize = True
        TESTBOX.Location = New Point(316, 392)
        TESTBOX.Name = "TESTBOX"
        TESTBOX.RightToLeft = RightToLeft.No
        TESTBOX.Size = New Size(69, 19)
        TESTBOX.TabIndex = 22
        TESTBOX.Text = "Dev Test"
        TESTBOX.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TESTBOX)
        Controls.Add(ProgressBar1)
        Controls.Add(Label6)
        Controls.Add(CheckBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "NL-Packet Builder 1.2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TESTBOX As CheckBox
End Class
