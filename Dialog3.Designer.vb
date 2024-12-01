<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog3
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxPhotoName = New System.Windows.Forms.TextBox()
        Me.ButtonSelectFile = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Workers_KSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers_KSVDataSet = New WindowsAppWorkers_KSV.Workers_KSVDataSet()
        Me.Workers_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableAdapterManager = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.TableAdapterManager()
        Me.FIOTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers_KSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(276, 197)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Название файла:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Код сотрудника:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Location = New System.Drawing.Point(277, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Предпросмотр файла:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox1.Location = New System.Drawing.Point(276, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'TextBoxPhotoName
        '
        Me.TextBoxPhotoName.Location = New System.Drawing.Point(15, 39)
        Me.TextBoxPhotoName.Name = "TextBoxPhotoName"
        Me.TextBoxPhotoName.ReadOnly = True
        Me.TextBoxPhotoName.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxPhotoName.TabIndex = 9
        '
        'ButtonSelectFile
        '
        Me.ButtonSelectFile.Location = New System.Drawing.Point(276, 168)
        Me.ButtonSelectFile.Name = "ButtonSelectFile"
        Me.ButtonSelectFile.Size = New System.Drawing.Size(147, 23)
        Me.ButtonSelectFile.TabIndex = 10
        Me.ButtonSelectFile.Text = "Выбрать файл"
        Me.ButtonSelectFile.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Workers_KSVBindingSource
        Me.ComboBox1.DisplayMember = "ID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 173)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(245, 21)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.ValueMember = "ID"
        '
        'Workers_KSVBindingSource
        '
        Me.Workers_KSVBindingSource.DataMember = "Workers_KSV"
        Me.Workers_KSVBindingSource.DataSource = Me.Workers_KSVDataSet
        '
        'Workers_KSVDataSet
        '
        Me.Workers_KSVDataSet.DataSetName = "Workers_KSVDataSet"
        Me.Workers_KSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Workers_KSVTableAdapter
        '
        Me.Workers_KSVTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Departments_KSVTableAdapter = Nothing
        Me.TableAdapterManager.PictureTableAdapter = Nothing
        Me.TableAdapterManager.Posts_KSVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers_KSVTableAdapter = Me.Workers_KSVTableAdapter
        '
        'FIOTextBox
        '
        Me.FIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers_KSVBindingSource, "FIO", True))
        Me.FIOTextBox.Enabled = False
        Me.FIOTextBox.Location = New System.Drawing.Point(15, 200)
        Me.FIOTextBox.Name = "FIOTextBox"
        Me.FIOTextBox.ReadOnly = True
        Me.FIOTextBox.Size = New System.Drawing.Size(245, 20)
        Me.FIOTextBox.TabIndex = 12
        '
        'Dialog3
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(440, 244)
        Me.Controls.Add(Me.FIOTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonSelectFile)
        Me.Controls.Add(Me.TextBoxPhotoName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Добавление ногового изображения"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers_KSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxPhotoName As TextBox
    Friend WithEvents ButtonSelectFile As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Workers_KSVDataSet As Workers_KSVDataSet
    Friend WithEvents Workers_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents Workers_KSVBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As Workers_KSVDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FIOTextBox As TextBox
End Class
