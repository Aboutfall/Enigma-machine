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
        Me.addRotor = New System.Windows.Forms.Button()
        Me.RotorV = New System.Windows.Forms.ComboBox()
        Me.RotorIV = New System.Windows.Forms.ComboBox()
        Me.R5pos = New System.Windows.Forms.ComboBox()
        Me.R4pos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.R3pos = New System.Windows.Forms.ComboBox()
        Me.R2pos = New System.Windows.Forms.ComboBox()
        Me.R1pos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RotorII = New System.Windows.Forms.ComboBox()
        Me.RotorIII = New System.Windows.Forms.ComboBox()
        Me.RotorI = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Encrypt = New System.Windows.Forms.Button()
        Me.RemRotor = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'addRotor
        '
        Me.addRotor.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRotor.Location = New System.Drawing.Point(92, 116)
        Me.addRotor.Name = "addRotor"
        Me.addRotor.Size = New System.Drawing.Size(96, 29)
        Me.addRotor.TabIndex = 33
        Me.addRotor.Text = "Add rotor"
        Me.addRotor.UseVisualStyleBackColor = True
        Me.addRotor.UseWaitCursor = True
        '
        'RotorV
        '
        Me.RotorV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotorV.Enabled = False
        Me.RotorV.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotorV.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.RotorV.Location = New System.Drawing.Point(450, 167)
        Me.RotorV.Name = "RotorV"
        Me.RotorV.Size = New System.Drawing.Size(82, 26)
        Me.RotorV.TabIndex = 32
        Me.RotorV.UseWaitCursor = True
        '
        'RotorIV
        '
        Me.RotorIV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotorIV.Enabled = False
        Me.RotorIV.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotorIV.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.RotorIV.Location = New System.Drawing.Point(345, 167)
        Me.RotorIV.Name = "RotorIV"
        Me.RotorIV.Size = New System.Drawing.Size(82, 26)
        Me.RotorIV.TabIndex = 31
        Me.RotorIV.UseWaitCursor = True
        '
        'R5pos
        '
        Me.R5pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.R5pos.Enabled = False
        Me.R5pos.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R5pos.FormattingEnabled = True
        Me.R5pos.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"})
        Me.R5pos.Location = New System.Drawing.Point(450, 280)
        Me.R5pos.Name = "R5pos"
        Me.R5pos.Size = New System.Drawing.Size(82, 26)
        Me.R5pos.TabIndex = 30
        Me.R5pos.UseWaitCursor = True
        '
        'R4pos
        '
        Me.R4pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.R4pos.Enabled = False
        Me.R4pos.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R4pos.FormattingEnabled = True
        Me.R4pos.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"})
        Me.R4pos.Location = New System.Drawing.Point(345, 280)
        Me.R4pos.Name = "R4pos"
        Me.R4pos.Size = New System.Drawing.Size(82, 26)
        Me.R4pos.TabIndex = 29
        Me.R4pos.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Plugboard"
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(194, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Rotor position"
        Me.Label2.UseWaitCursor = True
        '
        'R3pos
        '
        Me.R3pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.R3pos.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R3pos.FormattingEnabled = True
        Me.R3pos.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"})
        Me.R3pos.Location = New System.Drawing.Point(240, 280)
        Me.R3pos.Name = "R3pos"
        Me.R3pos.Size = New System.Drawing.Size(82, 26)
        Me.R3pos.TabIndex = 26
        Me.R3pos.UseWaitCursor = True
        '
        'R2pos
        '
        Me.R2pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.R2pos.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2pos.FormattingEnabled = True
        Me.R2pos.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"})
        Me.R2pos.Location = New System.Drawing.Point(134, 280)
        Me.R2pos.Name = "R2pos"
        Me.R2pos.Size = New System.Drawing.Size(82, 26)
        Me.R2pos.TabIndex = 25
        Me.R2pos.UseWaitCursor = True
        '
        'R1pos
        '
        Me.R1pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.R1pos.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1pos.FormattingEnabled = True
        Me.R1pos.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"})
        Me.R1pos.Location = New System.Drawing.Point(26, 280)
        Me.R1pos.Name = "R1pos"
        Me.R1pos.Size = New System.Drawing.Size(82, 26)
        Me.R1pos.TabIndex = 24
        Me.R1pos.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Rotor config"
        Me.Label1.UseWaitCursor = True
        '
        'RotorII
        '
        Me.RotorII.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotorII.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotorII.FormattingEnabled = True
        Me.RotorII.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.RotorII.Location = New System.Drawing.Point(134, 167)
        Me.RotorII.Name = "RotorII"
        Me.RotorII.Size = New System.Drawing.Size(82, 26)
        Me.RotorII.TabIndex = 22
        Me.RotorII.UseWaitCursor = True
        '
        'RotorIII
        '
        Me.RotorIII.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotorIII.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotorIII.FormattingEnabled = True
        Me.RotorIII.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.RotorIII.Location = New System.Drawing.Point(240, 167)
        Me.RotorIII.Name = "RotorIII"
        Me.RotorIII.Size = New System.Drawing.Size(82, 26)
        Me.RotorIII.TabIndex = 21
        Me.RotorIII.UseWaitCursor = True
        '
        'RotorI
        '
        Me.RotorI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotorI.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotorI.FormattingEnabled = True
        Me.RotorI.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.RotorI.Location = New System.Drawing.Point(26, 167)
        Me.RotorI.Name = "RotorI"
        Me.RotorI.Size = New System.Drawing.Size(82, 26)
        Me.RotorI.TabIndex = 20
        Me.RotorI.UseWaitCursor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(938, 210)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(382, 20)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.UseWaitCursor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Modern No. 20", 20.0!)
        Me.Title.Location = New System.Drawing.Point(547, 33)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(207, 29)
        Me.Title.TabIndex = 18
        Me.Title.Text = "Enigma Machine"
        Me.Title.UseWaitCursor = True
        '
        'Encrypt
        '
        Me.Encrypt.Enabled = False
        Me.Encrypt.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Encrypt.Location = New System.Drawing.Point(1052, 318)
        Me.Encrypt.Name = "Encrypt"
        Me.Encrypt.Size = New System.Drawing.Size(141, 47)
        Me.Encrypt.TabIndex = 17
        Me.Encrypt.Text = "Encrypt"
        Me.Encrypt.UseVisualStyleBackColor = True
        Me.Encrypt.UseWaitCursor = True
        '
        'RemRotor
        '
        Me.RemRotor.Enabled = False
        Me.RemRotor.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemRotor.Location = New System.Drawing.Point(300, 116)
        Me.RemRotor.Name = "RemRotor"
        Me.RemRotor.Size = New System.Drawing.Size(110, 29)
        Me.RemRotor.TabIndex = 34
        Me.RemRotor.Text = "Remove rotor"
        Me.RemRotor.UseVisualStyleBackColor = True
        Me.RemRotor.UseWaitCursor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(938, 454)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(382, 20)
        Me.TextBox2.TabIndex = 35
        Me.TextBox2.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1083, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Enter text"
        Me.Label4.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1083, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Output"
        Me.Label5.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Reflector"
        Me.Label6.UseWaitCursor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(18, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 26)
        Me.ComboBox1.TabIndex = 39
        Me.ComboBox1.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1410, 731)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.RemRotor)
        Me.Controls.Add(Me.addRotor)
        Me.Controls.Add(Me.RotorV)
        Me.Controls.Add(Me.RotorIV)
        Me.Controls.Add(Me.R5pos)
        Me.Controls.Add(Me.R4pos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.R3pos)
        Me.Controls.Add(Me.R2pos)
        Me.Controls.Add(Me.R1pos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RotorII)
        Me.Controls.Add(Me.RotorIII)
        Me.Controls.Add(Me.RotorI)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Encrypt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addRotor As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Title As Label
    Friend WithEvents Encrypt As Button
    Friend WithEvents RemRotor As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RotorV As ComboBox
    Friend WithEvents RotorIV As ComboBox
    Friend WithEvents R5pos As ComboBox
    Friend WithEvents R4pos As ComboBox
    Friend WithEvents R3pos As ComboBox
    Friend WithEvents R2pos As ComboBox
    Friend WithEvents R1pos As ComboBox
    Friend WithEvents RotorII As ComboBox
    Friend WithEvents RotorIII As ComboBox
    Friend WithEvents RotorI As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
