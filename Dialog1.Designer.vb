<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FIOTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DepartmentsComboBox = New System.Windows.Forms.ComboBox()
        Me.PostComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PicBoxDialog = New System.Windows.Forms.PictureBox()
        Me.PicButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FileNamesTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PicBoxDialog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(236, 321)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "ОК"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Отмена"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ФИО"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Дата рождения"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Отдел"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Должность"
        '
        'FIOTextBox
        '
        Me.FIOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FIOTextBox.Location = New System.Drawing.Point(12, 30)
        Me.FIOTextBox.Name = "FIOTextBox"
        Me.FIOTextBox.Size = New System.Drawing.Size(375, 22)
        Me.FIOTextBox.TabIndex = 5
        '
        'BirthdayDateTimePicker
        '
        Me.BirthdayDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BirthdayDateTimePicker.Location = New System.Drawing.Point(12, 91)
        Me.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        Me.BirthdayDateTimePicker.Size = New System.Drawing.Size(181, 22)
        Me.BirthdayDateTimePicker.TabIndex = 6
        '
        'DepartmentsComboBox
        '
        Me.DepartmentsComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DepartmentsComboBox.FormattingEnabled = True
        Me.DepartmentsComboBox.Location = New System.Drawing.Point(12, 152)
        Me.DepartmentsComboBox.Name = "DepartmentsComboBox"
        Me.DepartmentsComboBox.Size = New System.Drawing.Size(181, 24)
        Me.DepartmentsComboBox.TabIndex = 7
        '
        'PostComboBox
        '
        Me.PostComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PostComboBox.FormattingEnabled = True
        Me.PostComboBox.Location = New System.Drawing.Point(12, 213)
        Me.PostComboBox.Name = "PostComboBox"
        Me.PostComboBox.Size = New System.Drawing.Size(181, 24)
        Me.PostComboBox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Изображение"
        '
        'PicBoxDialog
        '
        Me.PicBoxDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBoxDialog.Location = New System.Drawing.Point(216, 91)
        Me.PicBoxDialog.Name = "PicBoxDialog"
        Me.PicBoxDialog.Size = New System.Drawing.Size(164, 164)
        Me.PicBoxDialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxDialog.TabIndex = 11
        Me.PicBoxDialog.TabStop = False
        '
        'PicButton
        '
        Me.PicButton.Location = New System.Drawing.Point(216, 274)
        Me.PicButton.Name = "PicButton"
        Me.PicButton.Size = New System.Drawing.Size(164, 21)
        Me.PicButton.TabIndex = 12
        Me.PicButton.Text = "Выбор картинки"
        Me.PicButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Файл"
        '
        'FileNamesTextBox
        '
        Me.FileNamesTextBox.Location = New System.Drawing.Point(12, 274)
        Me.FileNamesTextBox.Name = "FileNamesTextBox"
        Me.FileNamesTextBox.Size = New System.Drawing.Size(181, 20)
        Me.FileNamesTextBox.TabIndex = 14
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(394, 362)
        Me.Controls.Add(Me.FileNamesTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PicButton)
        Me.Controls.Add(Me.PicBoxDialog)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PostComboBox)
        Me.Controls.Add(Me.DepartmentsComboBox)
        Me.Controls.Add(Me.BirthdayDateTimePicker)
        Me.Controls.Add(Me.FIOTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Добавление сотрудника"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PicBoxDialog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FIOTextBox As TextBox
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents DepartmentsComboBox As ComboBox
    Friend WithEvents PostComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PicBoxDialog As PictureBox
    Friend WithEvents PicButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents FileNamesTextBox As TextBox
End Class
