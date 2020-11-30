<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewtonRaphson
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nav_Home = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTxtUno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tfd = New System.Windows.Forms.TextBox()
        Me.txi = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.lbTxtDos = New System.Windows.Forms.Label()
        Me.panel_Biseccion = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.Label()
        Me.lbraiz = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular_NR = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Biseccion.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel1.Controls.Add(Me.nav_Home)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 58)
        Me.Panel1.TabIndex = 89
        '
        'nav_Home
        '
        Me.nav_Home.Image = Global.MetodosNumericos.My.Resources.Resources.Imagen1__2_
        Me.nav_Home.Location = New System.Drawing.Point(12, -21)
        Me.nav_Home.Name = "nav_Home"
        Me.nav_Home.Size = New System.Drawing.Size(130, 100)
        Me.nav_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nav_Home.TabIndex = 5
        Me.nav_Home.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Antic Slab", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(172, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(305, 44)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Newton Raphson"
        '
        'lbTxtUno
        '
        Me.lbTxtUno.AutoSize = True
        Me.lbTxtUno.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTxtUno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTxtUno.Location = New System.Drawing.Point(65, 134)
        Me.lbTxtUno.Name = "lbTxtUno"
        Me.lbTxtUno.Size = New System.Drawing.Size(108, 17)
        Me.lbTxtUno.TabIndex = 87
        Me.lbTxtUno.Text = "Dame la derivada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(65, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Dame la función"
        '
        'tfd
        '
        Me.tfd.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tfd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tfd.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tfd.Location = New System.Drawing.Point(180, 131)
        Me.tfd.Name = "tfd"
        Me.tfd.Size = New System.Drawing.Size(165, 25)
        Me.tfd.TabIndex = 82
        '
        'txi
        '
        Me.txi.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txi.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txi.Location = New System.Drawing.Point(180, 162)
        Me.txi.Name = "txi"
        Me.txi.Size = New System.Drawing.Size(165, 25)
        Me.txi.TabIndex = 81
        '
        'tf
        '
        Me.tf.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tf.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tf.Location = New System.Drawing.Point(180, 100)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(165, 25)
        Me.tf.TabIndex = 80
        '
        'lbTxtDos
        '
        Me.lbTxtDos.AutoSize = True
        Me.lbTxtDos.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTxtDos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTxtDos.Location = New System.Drawing.Point(65, 165)
        Me.lbTxtDos.Name = "lbTxtDos"
        Me.lbTxtDos.Size = New System.Drawing.Size(53, 17)
        Me.lbTxtDos.TabIndex = 79
        Me.lbTxtDos.Text = "Dame x"
        '
        'panel_Biseccion
        '
        Me.panel_Biseccion.BackColor = System.Drawing.Color.White
        Me.panel_Biseccion.Controls.Add(Me.Panel2)
        Me.panel_Biseccion.Controls.Add(Me.lbTxtUno)
        Me.panel_Biseccion.Controls.Add(Me.Label3)
        Me.panel_Biseccion.Controls.Add(Me.tfd)
        Me.panel_Biseccion.Controls.Add(Me.txi)
        Me.panel_Biseccion.Controls.Add(Me.tf)
        Me.panel_Biseccion.Controls.Add(Me.lbTxtDos)
        Me.panel_Biseccion.Controls.Add(Me.tc)
        Me.panel_Biseccion.Controls.Add(Me.lc)
        Me.panel_Biseccion.Controls.Add(Me.lbraiz)
        Me.panel_Biseccion.Controls.Add(Me.Label2)
        Me.panel_Biseccion.Controls.Add(Me.BtnLimpiar)
        Me.panel_Biseccion.Controls.Add(Me.BtnSalir)
        Me.panel_Biseccion.Controls.Add(Me.BtnCalcular_NR)
        Me.panel_Biseccion.Controls.Add(Me.Salida)
        Me.panel_Biseccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Biseccion.Location = New System.Drawing.Point(0, 0)
        Me.panel_Biseccion.Name = "panel_Biseccion"
        Me.panel_Biseccion.Size = New System.Drawing.Size(984, 541)
        Me.panel_Biseccion.TabIndex = 92
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 58)
        Me.Panel2.TabIndex = 88
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MetodosNumericos.My.Resources.Resources.Imagen1__2_
        Me.PictureBox1.Location = New System.Drawing.Point(12, -21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Antic Slab", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(172, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Newton Raphson"
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tc.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tc.Location = New System.Drawing.Point(180, 194)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(165, 25)
        Me.tc.TabIndex = 85
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lc.Location = New System.Drawing.Point(65, 197)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(75, 17)
        Me.lc.TabIndex = 83
        Me.lc.Text = "Dame cifras"
        '
        'lbraiz
        '
        Me.lbraiz.AutoSize = True
        Me.lbraiz.Font = New System.Drawing.Font("Advent Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbraiz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbraiz.Location = New System.Drawing.Point(566, 98)
        Me.lbraiz.Name = "lbraiz"
        Me.lbraiz.Size = New System.Drawing.Size(188, 22)
        Me.lbraiz.TabIndex = 78
        Me.lbraiz.Text = "Aún no se ha encontrado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Advent Pro Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(457, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "LA RAÍZ ES: "
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Location = New System.Drawing.Point(68, 279)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(293, 34)
        Me.BtnLimpiar.TabIndex = 76
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalir.Location = New System.Drawing.Point(68, 319)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(293, 34)
        Me.BtnSalir.TabIndex = 75
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCalcular_NR
        '
        Me.BtnCalcular_NR.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCalcular_NR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalcular_NR.FlatAppearance.BorderSize = 0
        Me.BtnCalcular_NR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular_NR.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular_NR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCalcular_NR.Location = New System.Drawing.Point(68, 239)
        Me.BtnCalcular_NR.Name = "BtnCalcular_NR"
        Me.BtnCalcular_NR.Size = New System.Drawing.Size(293, 34)
        Me.BtnCalcular_NR.TabIndex = 74
        Me.BtnCalcular_NR.Text = "Calcular"
        Me.BtnCalcular_NR.UseVisualStyleBackColor = False
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(33, 388)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(869, 135)
        Me.Salida.TabIndex = 86
        '
        'Column1
        '
        Me.Column1.HeaderText = "Indice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Xi"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "error"
        Me.Column3.Name = "Column3"
        '
        'NewtonRaphson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 541)
        Me.Controls.Add(Me.panel_Biseccion)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewtonRaphson"
        Me.Text = "NewtonRaphson"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Biseccion.ResumeLayout(False)
        Me.panel_Biseccion.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents nav_Home As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTxtUno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tfd As TextBox
    Friend WithEvents txi As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents lbTxtDos As Label
    Friend WithEvents panel_Biseccion As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents lc As Label
    Friend WithEvents lbraiz As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCalcular_NR As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
