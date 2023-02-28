<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog2
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListViewPosts = New System.Windows.Forms.ListView()
        Me.ColumnID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPosts = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewDepartments = New System.Windows.Forms.ListView()
        Me.ColumnIDDepartments = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDepartments = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonDropPosts = New System.Windows.Forms.Button()
        Me.ButtonDropDepartments = New System.Windows.Forms.Button()
        Me.TextBoxPosts = New System.Windows.Forms.TextBox()
        Me.TextBoxDepartments = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(441, 310)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Должность"
        '
        'ListViewPosts
        '
        Me.ListViewPosts.CheckBoxes = True
        Me.ListViewPosts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnID, Me.ColumnPosts})
        Me.ListViewPosts.FullRowSelect = True
        Me.ListViewPosts.GridLines = True
        Me.ListViewPosts.HideSelection = False
        Me.ListViewPosts.Location = New System.Drawing.Point(12, 12)
        Me.ListViewPosts.Name = "ListViewPosts"
        Me.ListViewPosts.Size = New System.Drawing.Size(276, 164)
        Me.ListViewPosts.TabIndex = 13
        Me.ListViewPosts.UseCompatibleStateImageBehavior = False
        Me.ListViewPosts.View = System.Windows.Forms.View.Details
        '
        'ColumnID
        '
        Me.ColumnID.Text = "ID"
        Me.ColumnID.Width = 58
        '
        'ColumnPosts
        '
        Me.ColumnPosts.Text = "Должность"
        Me.ColumnPosts.Width = 214
        '
        'ListViewDepartments
        '
        Me.ListViewDepartments.CheckBoxes = True
        Me.ListViewDepartments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnIDDepartments, Me.ColumnDepartments})
        Me.ListViewDepartments.FullRowSelect = True
        Me.ListViewDepartments.GridLines = True
        Me.ListViewDepartments.HideSelection = False
        Me.ListViewDepartments.Location = New System.Drawing.Point(307, 12)
        Me.ListViewDepartments.Name = "ListViewDepartments"
        Me.ListViewDepartments.Size = New System.Drawing.Size(276, 164)
        Me.ListViewDepartments.TabIndex = 14
        Me.ListViewDepartments.UseCompatibleStateImageBehavior = False
        Me.ListViewDepartments.View = System.Windows.Forms.View.Details
        '
        'ColumnIDDepartments
        '
        Me.ColumnIDDepartments.Text = "ID"
        '
        'ColumnDepartments
        '
        Me.ColumnDepartments.Text = "Отдел"
        Me.ColumnDepartments.Width = 211
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Отдел"
        '
        'ButtonDropPosts
        '
        Me.ButtonDropPosts.Location = New System.Drawing.Point(12, 243)
        Me.ButtonDropPosts.Name = "ButtonDropPosts"
        Me.ButtonDropPosts.Size = New System.Drawing.Size(138, 23)
        Me.ButtonDropPosts.TabIndex = 17
        Me.ButtonDropPosts.Text = "Удалить должность"
        Me.ButtonDropPosts.UseVisualStyleBackColor = True
        '
        'ButtonDropDepartments
        '
        Me.ButtonDropDepartments.Location = New System.Drawing.Point(307, 242)
        Me.ButtonDropDepartments.Name = "ButtonDropDepartments"
        Me.ButtonDropDepartments.Size = New System.Drawing.Size(142, 23)
        Me.ButtonDropDepartments.TabIndex = 18
        Me.ButtonDropDepartments.Text = "Удалить отдел"
        Me.ButtonDropDepartments.UseVisualStyleBackColor = True
        '
        'TextBoxPosts
        '
        Me.TextBoxPosts.Location = New System.Drawing.Point(13, 213)
        Me.TextBoxPosts.Name = "TextBoxPosts"
        Me.TextBoxPosts.Size = New System.Drawing.Size(275, 20)
        Me.TextBoxPosts.TabIndex = 19
        '
        'TextBoxDepartments
        '
        Me.TextBoxDepartments.Location = New System.Drawing.Point(307, 213)
        Me.TextBoxDepartments.Name = "TextBoxDepartments"
        Me.TextBoxDepartments.Size = New System.Drawing.Size(276, 20)
        Me.TextBoxDepartments.TabIndex = 20
        '
        'Dialog2
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(599, 351)
        Me.Controls.Add(Me.TextBoxDepartments)
        Me.Controls.Add(Me.TextBoxPosts)
        Me.Controls.Add(Me.ButtonDropDepartments)
        Me.Controls.Add(Me.ButtonDropPosts)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListViewDepartments)
        Me.Controls.Add(Me.ListViewPosts)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Должность и отдел"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListViewPosts As ListView
    Friend WithEvents ListViewDepartments As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonDropPosts As Button
    Friend WithEvents ButtonDropDepartments As Button
    Friend WithEvents ColumnID As ColumnHeader
    Friend WithEvents ColumnPosts As ColumnHeader
    Friend WithEvents ColumnIDDepartments As ColumnHeader
    Friend WithEvents ColumnDepartments As ColumnHeader
    Friend WithEvents TextBoxPosts As TextBox
    Friend WithEvents TextBoxDepartments As TextBox
End Class
