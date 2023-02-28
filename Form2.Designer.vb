<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.OutGridView = New System.Windows.Forms.DataGridView()
        Me.WorkersKSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers_KSVDataSet = New WindowsAppWorkers_KSV.Workers_KSVDataSet()
        Me.Workers_KSVTableAdapter = New WindowsAppWorkers_KSV.Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter()
        CType(Me.OutGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersKSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutGridView
        '
        Me.OutGridView.AllowUserToAddRows = False
        Me.OutGridView.AllowUserToDeleteRows = False
        Me.OutGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.OutGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OutGridView.Location = New System.Drawing.Point(12, 12)
        Me.OutGridView.Name = "OutGridView"
        Me.OutGridView.ReadOnly = True
        Me.OutGridView.Size = New System.Drawing.Size(526, 214)
        Me.OutGridView.TabIndex = 0
        '
        'WorkersKSVBindingSource
        '
        Me.WorkersKSVBindingSource.DataMember = "Workers_KSV"
        Me.WorkersKSVBindingSource.DataSource = Me.Workers_KSVDataSet
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
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 235)
        Me.Controls.Add(Me.OutGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.OutGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersKSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers_KSVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OutGridView As DataGridView
    Friend WithEvents Workers_KSVDataSet As Workers_KSVDataSet
    Friend WithEvents WorkersKSVBindingSource As BindingSource
    Friend WithEvents Workers_KSVTableAdapter As Workers_KSVDataSetTableAdapters.Workers_KSVTableAdapter
End Class
