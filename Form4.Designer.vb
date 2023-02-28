<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Workers_KSVDataSet = New WindowsAppWorkers_KSV.Workers_KSVDataSet()
        Me.Workers_KSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter()
        Me.TableAdapterManager = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.TableAdapterManager()
        Me.Posts_KSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Posts_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Posts_KSVTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Departments_KSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Departments_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Departments_KSVTableAdapter()
        Me.Departments_KSVDataGridView = New System.Windows.Forms.DataGridView()
        Me.Workers_KSVBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers_KSVDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers_KSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Posts_KSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Departments_KSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Departments_KSVDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers_KSVBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers_KSVDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Workers_KSVDataSet
        '
        Me.Workers_KSVDataSet.DataSetName = "Workers_KSVDataSet"
        Me.Workers_KSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Workers_KSVBindingSource
        '
        Me.Workers_KSVBindingSource.DataMember = "Workers_KSV"
        Me.Workers_KSVBindingSource.DataSource = Me.Workers_KSVDataSet
        '
        'Workers_KSVTableAdapter
        '
        Me.Workers_KSVTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Departments_KSVTableAdapter = Me.Departments_KSVTableAdapter
        Me.TableAdapterManager.Posts_KSVTableAdapter = Me.Posts_KSVTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers_KSVTableAdapter = Me.Workers_KSVTableAdapter
        '
        'Posts_KSVBindingSource
        '
        Me.Posts_KSVBindingSource.DataMember = "Posts_KSV"
        Me.Posts_KSVBindingSource.DataSource = Me.Workers_KSVDataSet
        '
        'Posts_KSVTableAdapter
        '
        Me.Posts_KSVTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Workers_KSVDataGridView)
        Me.GroupBox1.Controls.Add(Me.Departments_KSVDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(809, 255)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Просмотр информации о сотрудниках по выбранному отделу"
        '
        'Departments_KSVBindingSource
        '
        Me.Departments_KSVBindingSource.DataMember = "Departments_KSV"
        Me.Departments_KSVBindingSource.DataSource = Me.Workers_KSVDataSet
        '
        'Departments_KSVTableAdapter
        '
        Me.Departments_KSVTableAdapter.ClearBeforeFill = True
        '
        'Departments_KSVDataGridView
        '
        Me.Departments_KSVDataGridView.AllowUserToAddRows = False
        Me.Departments_KSVDataGridView.AllowUserToDeleteRows = False
        Me.Departments_KSVDataGridView.AutoGenerateColumns = False
        Me.Departments_KSVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Departments_KSVDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Departments_KSVDataGridView.DataSource = Me.Departments_KSVBindingSource
        Me.Departments_KSVDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.Departments_KSVDataGridView.MultiSelect = False
        Me.Departments_KSVDataGridView.Name = "Departments_KSVDataGridView"
        Me.Departments_KSVDataGridView.ReadOnly = True
        Me.Departments_KSVDataGridView.RowHeadersVisible = False
        Me.Departments_KSVDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Departments_KSVDataGridView.Size = New System.Drawing.Size(181, 220)
        Me.Departments_KSVDataGridView.TabIndex = 0
        '
        'Workers_KSVBindingSource1
        '
        Me.Workers_KSVBindingSource1.DataMember = "DepartmentsWorkers"
        Me.Workers_KSVBindingSource1.DataSource = Me.Departments_KSVBindingSource
        '
        'Workers_KSVDataGridView
        '
        Me.Workers_KSVDataGridView.AllowUserToAddRows = False
        Me.Workers_KSVDataGridView.AllowUserToDeleteRows = False
        Me.Workers_KSVDataGridView.AutoGenerateColumns = False
        Me.Workers_KSVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Workers_KSVDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Workers_KSVDataGridView.DataSource = Me.Workers_KSVBindingSource1
        Me.Workers_KSVDataGridView.Location = New System.Drawing.Point(207, 19)
        Me.Workers_KSVDataGridView.Name = "Workers_KSVDataGridView"
        Me.Workers_KSVDataGridView.RowHeadersVisible = False
        Me.Workers_KSVDataGridView.Size = New System.Drawing.Size(596, 220)
        Me.Workers_KSVDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Название отдела"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FIO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ФИО"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Birthday"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Дата рождения"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 115
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DepartmentID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DepartmentID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PostId"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.Posts_KSVBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Title"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Должность"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "ID"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Picture"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Изображение"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 267)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers_KSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Posts_KSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Departments_KSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Departments_KSVDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers_KSVBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers_KSVDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Workers_KSVDataSet As Workers_KSVDataSet
    Friend WithEvents Workers_KSVBindingSource As BindingSource
    Friend WithEvents Workers_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter
    Friend WithEvents TableAdapterManager As Workers_KSVDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Posts_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Posts_KSVTableAdapter
    Friend WithEvents Posts_KSVBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Departments_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Departments_KSVTableAdapter
    Friend WithEvents Departments_KSVBindingSource As BindingSource
    Friend WithEvents Workers_KSVDataGridView As DataGridView
    Friend WithEvents Workers_KSVBindingSource1 As BindingSource
    Friend WithEvents Departments_KSVDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
