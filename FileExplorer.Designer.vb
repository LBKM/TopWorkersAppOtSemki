<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileExplorer
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FileListBox = New System.Windows.Forms.ListBox()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.SetPictureButton = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FileListBox
        '
        Me.FileListBox.FormattingEnabled = True
        Me.FileListBox.Location = New System.Drawing.Point(12, 12)
        Me.FileListBox.Name = "FileListBox"
        Me.FileListBox.Size = New System.Drawing.Size(544, 173)
        Me.FileListBox.TabIndex = 0
        '
        'BrowseButton
        '
        Me.BrowseButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BrowseButton.Location = New System.Drawing.Point(12, 193)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(112, 23)
        Me.BrowseButton.TabIndex = 1
        Me.BrowseButton.Text = "Обзор"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'SetPictureButton
        '
        Me.SetPictureButton.ForeColor = System.Drawing.Color.Green
        Me.SetPictureButton.Location = New System.Drawing.Point(444, 193)
        Me.SetPictureButton.Name = "SetPictureButton"
        Me.SetPictureButton.Size = New System.Drawing.Size(112, 23)
        Me.SetPictureButton.TabIndex = 2
        Me.SetPictureButton.Text = "Установить"
        Me.SetPictureButton.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar.Location = New System.Drawing.Point(130, 193)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(190, 23)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 3
        Me.ProgressBar.UseWaitCursor = True
        Me.ProgressBar.Visible = False
        '
        'ButtonClose
        '
        Me.ButtonClose.ForeColor = System.Drawing.Color.Red
        Me.ButtonClose.Location = New System.Drawing.Point(326, 193)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(112, 23)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.Text = "Закрыть"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FileExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 226)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.SetPictureButton)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.FileListBox)
        Me.Name = "FileExplorer"
        Me.Text = "FileExplorer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FileListBox As ListBox
    Friend WithEvents BrowseButton As Button
    Friend WithEvents SetPictureButton As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents ButtonClose As Button
End Class
