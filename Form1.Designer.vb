<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKSV
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WorkersListView_KSV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonNewKSV = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBoxView = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBFilterFIO = New System.Windows.Forms.TextBox()
        Me.ClearFilterButton = New System.Windows.Forms.Button()
        Me.ComboBoxFilterDepartments = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFilterPost = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Workers_KSVDataSet = New WindowsAppWorkers_KSV.Workers_KSVDataSet()
        Me.Departments_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Departments_KSVTableAdapter()
        Me.TableAdapterManager = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.TableAdapterManager()
        Me.Posts_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Posts_KSVTableAdapter()
        Me.Workers_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter()
        Me.WorkersKSVDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkersKSVDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBoxView.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersKSVDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersKSVDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WorkersListView_KSV
        '
        Me.WorkersListView_KSV.CheckBoxes = True
        Me.WorkersListView_KSV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.WorkersListView_KSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.WorkersListView_KSV.FullRowSelect = True
        Me.WorkersListView_KSV.GridLines = True
        Me.WorkersListView_KSV.HideSelection = False
        Me.WorkersListView_KSV.Location = New System.Drawing.Point(2, 19)
        Me.WorkersListView_KSV.Name = "WorkersListView_KSV"
        Me.WorkersListView_KSV.Size = New System.Drawing.Size(758, 233)
        Me.WorkersListView_KSV.TabIndex = 0
        Me.WorkersListView_KSV.UseCompatibleStateImageBehavior = False
        Me.WorkersListView_KSV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 63
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ФИО"
        Me.ColumnHeader2.Width = 249
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Дата рождения"
        Me.ColumnHeader3.Width = 108
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Отдел"
        Me.ColumnHeader4.Width = 171
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Должность"
        Me.ColumnHeader5.Width = 161
        '
        'ButtonNewKSV
        '
        Me.ButtonNewKSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonNewKSV.ForeColor = System.Drawing.Color.Green
        Me.ButtonNewKSV.Location = New System.Drawing.Point(14, 381)
        Me.ButtonNewKSV.Name = "ButtonNewKSV"
        Me.ButtonNewKSV.Size = New System.Drawing.Size(154, 37)
        Me.ButtonNewKSV.TabIndex = 1
        Me.ButtonNewKSV.Text = "Добавление сотрудника"
        Me.ButtonNewKSV.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.ForeColor = System.Drawing.Color.DarkRed
        Me.RemoveButton.Location = New System.Drawing.Point(174, 381)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(153, 37)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "Удалить выделенных сотрудников"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 26)
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem.Text = "Изменить..."
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(625, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Удалить должность"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBoxView
        '
        Me.GroupBoxView.Controls.Add(Me.WorkersListView_KSV)
        Me.GroupBoxView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBoxView.Location = New System.Drawing.Point(12, 123)
        Me.GroupBoxView.Name = "GroupBoxView"
        Me.GroupBoxView.Size = New System.Drawing.Size(766, 252)
        Me.GroupBoxView.TabIndex = 4
        Me.GroupBoxView.TabStop = False
        Me.GroupBoxView.Text = "Просмотр"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBFilterFIO)
        Me.GroupBox1.Controls.Add(Me.ClearFilterButton)
        Me.GroupBox1.Controls.Add(Me.ComboBoxFilterDepartments)
        Me.GroupBox1.Controls.Add(Me.ComboBoxFilterPost)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 87)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск информации о сотруднике"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Поиск по фамилии:"
        '
        'TBFilterFIO
        '
        Me.TBFilterFIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TBFilterFIO.Location = New System.Drawing.Point(160, 21)
        Me.TBFilterFIO.Name = "TBFilterFIO"
        Me.TBFilterFIO.Size = New System.Drawing.Size(149, 21)
        Me.TBFilterFIO.TabIndex = 5
        '
        'ClearFilterButton
        '
        Me.ClearFilterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ClearFilterButton.ForeColor = System.Drawing.Color.Blue
        Me.ClearFilterButton.Location = New System.Drawing.Point(611, 53)
        Me.ClearFilterButton.Name = "ClearFilterButton"
        Me.ClearFilterButton.Size = New System.Drawing.Size(149, 23)
        Me.ClearFilterButton.TabIndex = 4
        Me.ClearFilterButton.Text = "Очистить фильтр"
        Me.ClearFilterButton.UseVisualStyleBackColor = True
        '
        'ComboBoxFilterDepartments
        '
        Me.ComboBoxFilterDepartments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBoxFilterDepartments.FormattingEnabled = True
        Me.ComboBoxFilterDepartments.Location = New System.Drawing.Point(611, 20)
        Me.ComboBoxFilterDepartments.Name = "ComboBoxFilterDepartments"
        Me.ComboBoxFilterDepartments.Size = New System.Drawing.Size(149, 21)
        Me.ComboBoxFilterDepartments.TabIndex = 3
        '
        'ComboBoxFilterPost
        '
        Me.ComboBoxFilterPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBoxFilterPost.FormattingEnabled = True
        Me.ComboBoxFilterPost.Location = New System.Drawing.Point(403, 20)
        Me.ComboBoxFilterPost.Name = "ComboBoxFilterPost"
        Me.ComboBoxFilterPost.Size = New System.Drawing.Size(149, 21)
        Me.ComboBoxFilterPost.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(562, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Отдел:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Должность:"
        '
        'Workers_KSVDataSet
        '
        Me.Workers_KSVDataSet.DataSetName = "Workers_KSVDataSet"
        Me.Workers_KSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Departments_KSVTableAdapter
        '
        Me.Departments_KSVTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Departments_KSVTableAdapter = Me.Departments_KSVTableAdapter
        Me.TableAdapterManager.Posts_KSVTableAdapter = Me.Posts_KSVTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers_KSVTableAdapter = Me.Workers_KSVTableAdapter
        '
        'Posts_KSVTableAdapter
        '
        Me.Posts_KSVTableAdapter.ClearBeforeFill = True
        '
        'Workers_KSVTableAdapter
        '
        Me.Workers_KSVTableAdapter.ClearBeforeFill = True
        '
        'WorkersKSVDataSetBindingSource
        '
        Me.WorkersKSVDataSetBindingSource.DataSource = Me.Workers_KSVDataSet
        Me.WorkersKSVDataSetBindingSource.Position = 0
        '
        'WorkersKSVDataSetBindingSource1
        '
        Me.WorkersKSVDataSetBindingSource1.DataSource = Me.Workers_KSVDataSet
        Me.WorkersKSVDataSetBindingSource1.Position = 0
        '
        'FormKSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 434)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ButtonNewKSV)
        Me.Controls.Add(Me.GroupBoxView)
        Me.Name = "FormKSV"
        Me.Text = "Сотрудники. Койнов"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBoxView.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersKSVDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersKSVDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WorkersListView_KSV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Workers_KSVDataSet As Workers_KSVDataSet
    Friend WithEvents Departments_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Departments_KSVTableAdapter
    Friend WithEvents TableAdapterManager As Workers_KSVDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Posts_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Posts_KSVTableAdapter
    Friend WithEvents Workers_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter
    Friend WithEvents ButtonNewKSV As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBoxView As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxFilterDepartments As ComboBox
    Friend WithEvents ComboBoxFilterPost As ComboBox
    Friend WithEvents ClearFilterButton As Button
    Friend WithEvents WorkersKSVDataSetBindingSource As BindingSource
    Friend WithEvents WorkersKSVDataSetBindingSource1 As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents TBFilterFIO As TextBox
End Class
