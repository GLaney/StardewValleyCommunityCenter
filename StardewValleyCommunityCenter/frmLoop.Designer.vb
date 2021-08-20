<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoop))
        Me.dropSeason = New System.Windows.Forms.ComboBox()
        Me.dropWeather = New System.Windows.Forms.ComboBox()
        Me.dropDay = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewDay = New System.Windows.Forms.Button()
        Me.lblSeason = New System.Windows.Forms.Label()
        Me.lblWeather = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.chkItems = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'dropSeason
        '
        Me.dropSeason.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dropSeason.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.dropSeason.FormattingEnabled = True
        Me.dropSeason.Items.AddRange(New Object() {"Spring", "Summer", "Fall", "Winter"})
        Me.dropSeason.Location = New System.Drawing.Point(37, 48)
        Me.dropSeason.Name = "dropSeason"
        Me.dropSeason.Size = New System.Drawing.Size(121, 21)
        Me.dropSeason.TabIndex = 0
        '
        'dropWeather
        '
        Me.dropWeather.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dropWeather.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.dropWeather.FormattingEnabled = True
        Me.dropWeather.Items.AddRange(New Object() {"Sunny", "Raining", "Windy", "Stormy", "Snowy"})
        Me.dropWeather.Location = New System.Drawing.Point(375, 48)
        Me.dropWeather.Name = "dropWeather"
        Me.dropWeather.Size = New System.Drawing.Size(121, 21)
        Me.dropWeather.TabIndex = 1
        '
        'dropDay
        '
        Me.dropDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dropDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.dropDay.FormattingEnabled = True
        Me.dropDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28"})
        Me.dropDay.Location = New System.Drawing.Point(206, 48)
        Me.dropDay.Name = "dropDay"
        Me.dropDay.Size = New System.Drawing.Size(121, 21)
        Me.dropDay.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(546, 21)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewDay
        '
        Me.btnNewDay.BackgroundImage = CType(resources.GetObject("btnNewDay.BackgroundImage"), System.Drawing.Image)
        Me.btnNewDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewDay.Location = New System.Drawing.Point(544, 50)
        Me.btnNewDay.Name = "btnNewDay"
        Me.btnNewDay.Size = New System.Drawing.Size(75, 23)
        Me.btnNewDay.TabIndex = 4
        Me.btnNewDay.Text = "New Day"
        Me.btnNewDay.UseVisualStyleBackColor = True
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.BackColor = System.Drawing.Color.Transparent
        Me.lblSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeason.ForeColor = System.Drawing.Color.Black
        Me.lblSeason.Location = New System.Drawing.Point(62, 26)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(70, 20)
        Me.lblSeason.TabIndex = 5
        Me.lblSeason.Text = "Season"
        '
        'lblWeather
        '
        Me.lblWeather.AutoSize = True
        Me.lblWeather.BackColor = System.Drawing.Color.Transparent
        Me.lblWeather.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeather.ForeColor = System.Drawing.Color.Black
        Me.lblWeather.Location = New System.Drawing.Point(413, 26)
        Me.lblWeather.Name = "lblWeather"
        Me.lblWeather.Size = New System.Drawing.Size(77, 20)
        Me.lblWeather.TabIndex = 6
        Me.lblWeather.Text = "Weather"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.Black
        Me.lblDay.Location = New System.Drawing.Point(214, 26)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(40, 20)
        Me.lblDay.TabIndex = 7
        Me.lblDay.Text = "Day"
        '
        'chkItems
        '
        Me.chkItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.chkItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItems.FormattingEnabled = True
        Me.chkItems.Items.AddRange(New Object() {"1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "Wild Horseradish"})
        Me.chkItems.Location = New System.Drawing.Point(34, 99)
        Me.chkItems.MultiColumn = True
        Me.chkItems.Name = "chkItems"
        Me.chkItems.Size = New System.Drawing.Size(609, 330)
        Me.chkItems.Sorted = True
        Me.chkItems.TabIndex = 8
        '
        'frmLoop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(660, 450)
        Me.Controls.Add(Me.chkItems)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblWeather)
        Me.Controls.Add(Me.lblSeason)
        Me.Controls.Add(Me.btnNewDay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dropDay)
        Me.Controls.Add(Me.dropWeather)
        Me.Controls.Add(Me.dropSeason)
        Me.DoubleBuffered = True
        Me.Name = "frmLoop"
        Me.Text = "Stardew Valley Community Center Helper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dropSeason As ComboBox
    Friend WithEvents dropWeather As ComboBox
    Friend WithEvents dropDay As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNewDay As Button
    Friend WithEvents lblSeason As Label
    Friend WithEvents lblWeather As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents chkItems As CheckedListBox
End Class
