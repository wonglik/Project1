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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudAge = New System.Windows.Forms.NumericUpDown()
        Me.radPass = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFail = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radNoCredit = New System.Windows.Forms.RadioButton()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radT20 = New System.Windows.Forms.RadioButton()
        Me.radM40 = New System.Windows.Forms.RadioButton()
        Me.radB40 = New System.Windows.Forms.RadioButton()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(286, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 22)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age:"
        '
        'nudAge
        '
        Me.nudAge.Location = New System.Drawing.Point(286, 80)
        Me.nudAge.Name = "nudAge"
        Me.nudAge.Size = New System.Drawing.Size(74, 22)
        Me.nudAge.TabIndex = 3
        '
        'radPass
        '
        Me.radPass.AutoSize = True
        Me.radPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPass.Location = New System.Drawing.Point(30, 21)
        Me.radPass.Name = "radPass"
        Me.radPass.Size = New System.Drawing.Size(64, 27)
        Me.radPass.TabIndex = 6
        Me.radPass.TabStop = True
        Me.radPass.Text = "Yes"
        Me.radPass.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFail)
        Me.GroupBox1.Controls.Add(Me.radPass)
        Me.GroupBox1.Location = New System.Drawing.Point(286, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 55)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'radFail
        '
        Me.radFail.AutoSize = True
        Me.radFail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFail.Location = New System.Drawing.Point(118, 21)
        Me.radFail.Name = "radFail"
        Me.radFail.Size = New System.Drawing.Size(55, 27)
        Me.radFail.TabIndex = 7
        Me.radFail.TabStop = True
        Me.radFail.Text = "No"
        Me.radFail.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Pass BM and Sejarah:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Have Five Credits:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radNoCredit)
        Me.GroupBox2.Controls.Add(Me.radCredit)
        Me.GroupBox2.Location = New System.Drawing.Point(286, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 55)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'radNoCredit
        '
        Me.radNoCredit.AutoSize = True
        Me.radNoCredit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNoCredit.Location = New System.Drawing.Point(118, 21)
        Me.radNoCredit.Name = "radNoCredit"
        Me.radNoCredit.Size = New System.Drawing.Size(55, 27)
        Me.radNoCredit.TabIndex = 7
        Me.radNoCredit.TabStop = True
        Me.radNoCredit.Text = "No"
        Me.radNoCredit.UseVisualStyleBackColor = True
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCredit.Location = New System.Drawing.Point(30, 21)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(64, 27)
        Me.radCredit.TabIndex = 6
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "Yes"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(146, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Category:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radT20)
        Me.GroupBox3.Controls.Add(Me.radM40)
        Me.GroupBox3.Controls.Add(Me.radB40)
        Me.GroupBox3.Location = New System.Drawing.Point(286, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 55)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'radT20
        '
        Me.radT20.AutoSize = True
        Me.radT20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radT20.Location = New System.Drawing.Point(203, 21)
        Me.radT20.Name = "radT20"
        Me.radT20.Size = New System.Drawing.Size(65, 27)
        Me.radT20.TabIndex = 8
        Me.radT20.TabStop = True
        Me.radT20.Text = "T20"
        Me.radT20.UseVisualStyleBackColor = True
        '
        'radM40
        '
        Me.radM40.AutoSize = True
        Me.radM40.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radM40.Location = New System.Drawing.Point(118, 21)
        Me.radM40.Name = "radM40"
        Me.radM40.Size = New System.Drawing.Size(70, 27)
        Me.radM40.TabIndex = 7
        Me.radM40.TabStop = True
        Me.radM40.Text = "M40"
        Me.radM40.UseVisualStyleBackColor = True
        '
        'radB40
        '
        Me.radB40.AutoSize = True
        Me.radB40.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radB40.Location = New System.Drawing.Point(30, 21)
        Me.radB40.Name = "radB40"
        Me.radB40.Size = New System.Drawing.Size(66, 27)
        Me.radB40.TabIndex = 6
        Me.radB40.TabStop = True
        Me.radB40.Text = "B40"
        Me.radB40.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("MI LANTING", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(171, 408)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(113, 38)
        Me.BtnSubmit.TabIndex = 14
        Me.BtnSubmit.Text = "SUBMIT"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("MI LANTING", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(308, 408)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(113, 38)
        Me.BtnExit.TabIndex = 15
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Location = New System.Drawing.Point(286, 243)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(192, 55)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(118, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 27)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "No"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(30, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 27)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Yes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Active In Co-Curiculum:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nudAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "University Scholarship System"
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudAge As NumericUpDown
    Friend WithEvents radPass As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents radFail As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radNoCredit As RadioButton
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radT20 As RadioButton
    Friend WithEvents radM40 As RadioButton
    Friend WithEvents radB40 As RadioButton
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label6 As Label
End Class
