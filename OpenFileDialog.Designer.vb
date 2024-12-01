<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenFileDialog
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
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WorkersKSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers_KSVDataSet = New WindowsAppWorkers_KSV.Workers_KSVDataSet()
        Me.WorkersKSVDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.PictureTableAdapter()
        Me.TableAdapterManager = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.TableAdapterManager()
        Me.Departments_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Departments_KSVTableAdapter()
        Me.Posts_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Posts_KSVTableAdapter()
        Me.Workers_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersKSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersKSVDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(502, 237)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(73, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Закрыть"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox1.Location = New System.Drawing.Point(431, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 13)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(413, 97)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Код файла"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Имя файла"
        Me.ColumnHeader2.Width = 240
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Код сотрудника"
        Me.ColumnHeader3.Width = 94
        '
        'PictureDataGridView
        '
        Me.PictureDataGridView.AllowUserToAddRows = False
        Me.PictureDataGridView.AutoGenerateColumns = False
        Me.PictureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PictureDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PictureDataGridView.DataSource = Me.PictureBindingSource
        Me.PictureDataGridView.Location = New System.Drawing.Point(12, 116)
        Me.PictureDataGridView.Name = "PictureDataGridView"
        Me.PictureDataGridView.ReadOnly = True
        Me.PictureDataGridView.Size = New System.Drawing.Size(413, 140)
        Me.PictureDataGridView.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Location = New System.Drawing.Point(432, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Предпросмотр файла:"
        '
        'WorkersKSVBindingSource
        '
        Me.WorkersKSVBindingSource.DataMember = "Workers_KSV"
        Me.WorkersKSVBindingSource.DataSource = Me.WorkersKSVDataSetBindingSource
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(431, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Добавить изображение"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Picture"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Код файла"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 79
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NameFile"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Имя файла"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Worker"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Код сотрудника"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'PictureBindingSource
        '
        Me.PictureBindingSource.DataMember = "Picture"
        Me.PictureBindingSource.DataSource = Me.Workers_KSVDataSet
        '
        'Workers_KSVDataSet
        '
        Me.Workers_KSVDataSet.DataSetName = "Workers_KSVDataSet"
        Me.Workers_KSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkersKSVDataSetBindingSource
        '
        Me.WorkersKSVDataSetBindingSource.DataSource = Me.Workers_KSVDataSet
        Me.WorkersKSVDataSetBindingSource.Position = 0
        '
        'PictureTableAdapter
        '
        Me.PictureTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Departments_KSVTableAdapter = Nothing
        Me.TableAdapterManager.PictureTableAdapter = Me.PictureTableAdapter
        Me.TableAdapterManager.Posts_KSVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers_KSVTableAdapter = Nothing
        '
        'Departments_KSVTableAdapter
        '
        Me.Departments_KSVTableAdapter.ClearBeforeFill = True
        '
        'Posts_KSVTableAdapter
        '
        Me.Posts_KSVTableAdapter.ClearBeforeFill = True
        '
        'Workers_KSVTableAdapter
        '
        Me.Workers_KSVTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(587, 278)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureDataGridView)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpenFileDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OpenFileDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersKSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersKSVDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Workers_KSVDataSet As Workers_KSVDataSet
    Friend WithEvents PictureTableAdapter As Workers_KSVDataSetTableAdapters.PictureTableAdapter
    Friend WithEvents TableAdapterManager As Workers_KSVDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Departments_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Departments_KSVTableAdapter
    Friend WithEvents Posts_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Posts_KSVTableAdapter
    Friend WithEvents Workers_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter
    Friend WithEvents PictureBindingSource As BindingSource
    Friend WithEvents PictureDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents WorkersKSVBindingSource As BindingSource
    Friend WithEvents WorkersKSVDataSetBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
