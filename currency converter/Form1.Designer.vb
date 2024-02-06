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
        Me.from_Currency = New System.Windows.Forms.ComboBox()
        Me.to_Currency = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.calculate = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Label()
        Me.help = New System.Windows.Forms.Button()
        Me.showResult = New System.Windows.Forms.Label()
        Me.Conversion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(218, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency converter "
        '
        'from_Currency
        '
        Me.from_Currency.FormattingEnabled = True
        Me.from_Currency.Location = New System.Drawing.Point(220, 106)
        Me.from_Currency.Name = "from_Currency"
        Me.from_Currency.Size = New System.Drawing.Size(121, 23)
        Me.from_Currency.TabIndex = 1
        '
        'to_Currency
        '
        Me.to_Currency.FormattingEnabled = True
        Me.to_Currency.Location = New System.Drawing.Point(462, 106)
        Me.to_Currency.Name = "to_Currency"
        Me.to_Currency.Size = New System.Drawing.Size(121, 23)
        Me.to_Currency.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(245, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(508, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To"
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(346, 191)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(140, 23)
        Me.amount.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(242, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Amount "
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(382, 232)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(75, 23)
        Me.calculate.TabIndex = 9
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.result.Location = New System.Drawing.Point(259, 260)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(73, 30)
        Me.result.TabIndex = 10
        Me.result.Text = "Result"
        '
        'help
        '
        Me.help.Location = New System.Drawing.Point(692, 311)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(75, 23)
        Me.help.TabIndex = 11
        Me.help.Text = "Help"
        Me.help.UseVisualStyleBackColor = True
        '
        'showResult
        '
        Me.showResult.AutoSize = True
        Me.showResult.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.showResult.Location = New System.Drawing.Point(405, 265)
        Me.showResult.Name = "showResult"
        Me.showResult.Size = New System.Drawing.Size(169, 25)
        Me.showResult.TabIndex = 12
        Me.showResult.Text = "Result shows here "
        '
        'Conversion
        '
        Me.Conversion.Location = New System.Drawing.Point(346, 162)
        Me.Conversion.Name = "Conversion"
        Me.Conversion.Size = New System.Drawing.Size(140, 23)
        Me.Conversion.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(258, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Rate"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 347)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Conversion)
        Me.Controls.Add(Me.showResult)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.to_Currency)
        Me.Controls.Add(Me.from_Currency)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Converter | Home"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents from_Currency As ComboBox
    Friend WithEvents to_Currency As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents amount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents calculate As Button
    Friend WithEvents result As Label
    Friend WithEvents help As Button
    Friend WithEvents showResult As Label
    Friend WithEvents Conversion As TextBox
    Friend WithEvents Label4 As Label

End Class
