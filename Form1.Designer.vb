
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
        Me.txtCnfgName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.LbFrq = New System.Windows.Forms.Label()
        Me.LbIY = New System.Windows.Forms.Label()
        Me.LbIB = New System.Windows.Forms.Label()
        Me.LbIR = New System.Windows.Forms.Label()
        Me.LbVY = New System.Windows.Forms.Label()
        Me.LbVB = New System.Windows.Forms.Label()
        Me.LbVR = New System.Windows.Forms.Label()
        Me.LbPh = New System.Windows.Forms.Label()
        Me.LbCrt = New System.Windows.Forms.Label()
        Me.LbVlt = New System.Windows.Forms.Label()
        Me.LbCnfg = New System.Windows.Forms.Label()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.F = New System.Windows.Forms.RichTextBox()
        Me.UI = New System.Windows.Forms.RichTextBox()
        Me.Ib = New System.Windows.Forms.RichTextBox()
        Me.Iy = New System.Windows.Forms.RichTextBox()
        Me.Ir = New System.Windows.Forms.RichTextBox()
        Me.Ub = New System.Windows.Forms.RichTextBox()
        Me.Uy = New System.Windows.Forms.RichTextBox()
        Me.Ur = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.button_Update = New System.Windows.Forms.Button()
        Me.button_Delete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCnfgName
        '
        Me.txtCnfgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCnfgName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnfgName.Location = New System.Drawing.Point(499, 74)
        Me.txtCnfgName.Name = "txtCnfgName"
        Me.txtCnfgName.Size = New System.Drawing.Size(460, 49)
        Me.txtCnfgName.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkGray
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(547, 343)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 56)
        Me.btnAdd.TabIndex = 62
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'LbFrq
        '
        Me.LbFrq.AutoSize = True
        Me.LbFrq.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFrq.Location = New System.Drawing.Point(638, 276)
        Me.LbFrq.Name = "LbFrq"
        Me.LbFrq.Size = New System.Drawing.Size(196, 42)
        Me.LbFrq.TabIndex = 60
        Me.LbFrq.Text = "Frequency"
        '
        'LbIY
        '
        Me.LbIY.AutoSize = True
        Me.LbIY.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIY.Location = New System.Drawing.Point(611, 214)
        Me.LbIY.Name = "LbIY"
        Me.LbIY.Size = New System.Drawing.Size(43, 42)
        Me.LbIY.TabIndex = 57
        Me.LbIY.Text = "Y"
        '
        'LbIB
        '
        Me.LbIB.AutoSize = True
        Me.LbIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIB.Location = New System.Drawing.Point(779, 214)
        Me.LbIB.Name = "LbIB"
        Me.LbIB.Size = New System.Drawing.Size(43, 42)
        Me.LbIB.TabIndex = 55
        Me.LbIB.Text = "B"
        '
        'LbIR
        '
        Me.LbIR.AutoSize = True
        Me.LbIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIR.Location = New System.Drawing.Point(448, 214)
        Me.LbIR.Name = "LbIR"
        Me.LbIR.Size = New System.Drawing.Size(45, 42)
        Me.LbIR.TabIndex = 53
        Me.LbIR.Text = "R"
        '
        'LbVY
        '
        Me.LbVY.AutoSize = True
        Me.LbVY.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVY.Location = New System.Drawing.Point(611, 145)
        Me.LbVY.Name = "LbVY"
        Me.LbVY.Size = New System.Drawing.Size(43, 42)
        Me.LbVY.TabIndex = 51
        Me.LbVY.Text = "Y"
        '
        'LbVB
        '
        Me.LbVB.AutoSize = True
        Me.LbVB.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVB.Location = New System.Drawing.Point(779, 146)
        Me.LbVB.Name = "LbVB"
        Me.LbVB.Size = New System.Drawing.Size(43, 42)
        Me.LbVB.TabIndex = 49
        Me.LbVB.Text = "B"
        '
        'LbVR
        '
        Me.LbVR.AutoSize = True
        Me.LbVR.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVR.Location = New System.Drawing.Point(448, 146)
        Me.LbVR.Name = "LbVR"
        Me.LbVR.Size = New System.Drawing.Size(45, 42)
        Me.LbVR.TabIndex = 47
        Me.LbVR.Text = "R"
        '
        'LbPh
        '
        Me.LbPh.AutoSize = True
        Me.LbPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPh.Location = New System.Drawing.Point(244, 276)
        Me.LbPh.Name = "LbPh"
        Me.LbPh.Size = New System.Drawing.Size(231, 42)
        Me.LbPh.TabIndex = 46
        Me.LbPh.Text = "Phase Angle"
        '
        'LbCrt
        '
        Me.LbCrt.AutoSize = True
        Me.LbCrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCrt.Location = New System.Drawing.Point(282, 220)
        Me.LbCrt.Name = "LbCrt"
        Me.LbCrt.Size = New System.Drawing.Size(142, 42)
        Me.LbCrt.TabIndex = 45
        Me.LbCrt.Text = "Current"
        '
        'LbVlt
        '
        Me.LbVlt.AutoSize = True
        Me.LbVlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVlt.Location = New System.Drawing.Point(279, 145)
        Me.LbVlt.Name = "LbVlt"
        Me.LbVlt.Size = New System.Drawing.Size(145, 42)
        Me.LbVlt.TabIndex = 44
        Me.LbVlt.Text = "Voltage"
        '
        'LbCnfg
        '
        Me.LbCnfg.AutoSize = True
        Me.LbCnfg.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCnfg.Location = New System.Drawing.Point(216, 74)
        Me.LbCnfg.Name = "LbCnfg"
        Me.LbCnfg.Size = New System.Drawing.Size(277, 52)
        Me.LbCnfg.TabIndex = 42
        Me.LbCnfg.Text = "Config Name"
        '
        'F
        '
        Me.F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F.Location = New System.Drawing.Point(828, 282)
        Me.F.Multiline = False
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(109, 29)
        Me.F.TabIndex = 61
        Me.F.Text = ""
        '
        'UI
        '
        Me.UI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI.Location = New System.Drawing.Point(499, 282)
        Me.UI.Multiline = False
        Me.UI.Name = "UI"
        Me.UI.Size = New System.Drawing.Size(109, 29)
        Me.UI.TabIndex = 59
        Me.UI.Text = ""
        '
        'Ib
        '
        Me.Ib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ib.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ib.Location = New System.Drawing.Point(828, 220)
        Me.Ib.Multiline = False
        Me.Ib.Name = "Ib"
        Me.Ib.Size = New System.Drawing.Size(79, 29)
        Me.Ib.TabIndex = 56
        Me.Ib.Text = ""
        '
        'Iy
        '
        Me.Iy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Iy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iy.Location = New System.Drawing.Point(666, 220)
        Me.Iy.Multiline = False
        Me.Iy.Name = "Iy"
        Me.Iy.Size = New System.Drawing.Size(79, 29)
        Me.Iy.TabIndex = 58
        Me.Iy.Text = ""
        '
        'Ir
        '
        Me.Ir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ir.Location = New System.Drawing.Point(499, 220)
        Me.Ir.Multiline = False
        Me.Ir.Name = "Ir"
        Me.Ir.Size = New System.Drawing.Size(79, 29)
        Me.Ir.TabIndex = 54
        Me.Ir.Text = ""
        '
        'Ub
        '
        Me.Ub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ub.Location = New System.Drawing.Point(828, 152)
        Me.Ub.Multiline = False
        Me.Ub.Name = "Ub"
        Me.Ub.Size = New System.Drawing.Size(79, 29)
        Me.Ub.TabIndex = 50
        Me.Ub.Text = ""
        '
        'Uy
        '
        Me.Uy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Uy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uy.Location = New System.Drawing.Point(666, 151)
        Me.Uy.Multiline = False
        Me.Uy.Name = "Uy"
        Me.Uy.Size = New System.Drawing.Size(79, 29)
        Me.Uy.TabIndex = 52
        Me.Uy.Text = ""
        '
        'Ur
        '
        Me.Ur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ur.Location = New System.Drawing.Point(499, 152)
        Me.Ur.Multiline = False
        Me.Ur.Name = "Ur"
        Me.Ur.Size = New System.Drawing.Size(79, 29)
        Me.Ur.TabIndex = 48
        Me.Ur.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 429)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1091, 444)
        Me.DataGridView1.TabIndex = 63
        '
        'button_Update
        '
        Me.button_Update.BackColor = System.Drawing.Color.DarkGray
        Me.button_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Update.Enabled = False
        Me.button_Update.Location = New System.Drawing.Point(416, 343)
        Me.button_Update.Name = "button_Update"
        Me.button_Update.Size = New System.Drawing.Size(162, 56)
        Me.button_Update.TabIndex = 64
        Me.button_Update.Text = "Update"
        Me.button_Update.UseVisualStyleBackColor = False
        Me.button_Update.Visible = False
        '
        'button_Delete
        '
        Me.button_Delete.BackColor = System.Drawing.Color.DarkGray
        Me.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Delete.Enabled = False
        Me.button_Delete.Location = New System.Drawing.Point(645, 343)
        Me.button_Delete.Name = "button_Delete"
        Me.button_Delete.Size = New System.Drawing.Size(189, 56)
        Me.button_Delete.TabIndex = 65
        Me.button_Delete.Text = "Delete"
        Me.button_Delete.UseVisualStyleBackColor = False
        Me.button_Delete.Visible = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1203, 885)
        Me.Controls.Add(Me.button_Delete)
        Me.Controls.Add(Me.button_Update)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCnfgName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.F)
        Me.Controls.Add(Me.LbFrq)
        Me.Controls.Add(Me.UI)
        Me.Controls.Add(Me.Iy)
        Me.Controls.Add(Me.LbIY)
        Me.Controls.Add(Me.Ib)
        Me.Controls.Add(Me.LbIB)
        Me.Controls.Add(Me.Ir)
        Me.Controls.Add(Me.LbIR)
        Me.Controls.Add(Me.Uy)
        Me.Controls.Add(Me.LbVY)
        Me.Controls.Add(Me.Ub)
        Me.Controls.Add(Me.LbVB)
        Me.Controls.Add(Me.Ur)
        Me.Controls.Add(Me.LbVR)
        Me.Controls.Add(Me.LbPh)
        Me.Controls.Add(Me.LbCrt)
        Me.Controls.Add(Me.LbVlt)
        Me.Controls.Add(Me.LbCnfg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Config"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCnfgName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents LbFrq As Label
    Friend WithEvents LbIY As Label
    Friend WithEvents LbIB As Label
    Friend WithEvents LbIR As Label
    Friend WithEvents LbVY As Label
    Friend WithEvents LbVB As Label
    Friend WithEvents LbVR As Label
    Friend WithEvents LbPh As Label
    Friend WithEvents LbCrt As Label
    Friend WithEvents LbVlt As Label
    Friend WithEvents LbCnfg As Label
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents F As RichTextBox
    Friend WithEvents UI As RichTextBox
    Friend WithEvents Ib As RichTextBox
    Friend WithEvents Iy As RichTextBox
    Friend WithEvents Ir As RichTextBox
    Friend WithEvents Ub As RichTextBox
    Friend WithEvents Uy As RichTextBox
    Friend WithEvents Ur As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents button_Update As Button
    Friend WithEvents button_Delete As Button
End Class
