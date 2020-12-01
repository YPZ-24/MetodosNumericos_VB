<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetodosNumericos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetodosNumericos))
        Me.panel_Principal = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nav_Home = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.nav_Im = New FontAwesome.Sharp.IconButton()
        Me.nav_R2 = New FontAwesome.Sharp.IconButton()
        Me.nav_Bi = New FontAwesome.Sharp.IconButton()
        Me.nav_RF = New FontAwesome.Sharp.IconButton()
        Me.nav_NR = New FontAwesome.Sharp.IconButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.nav_Ja = New FontAwesome.Sharp.IconButton()
        Me.nav_GS = New FontAwesome.Sharp.IconButton()
        Me.nav_IN = New FontAwesome.Sharp.IconButton()
        Me.nav_IL = New FontAwesome.Sharp.IconButton()
        Me.nav_MC = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_Principal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_Principal
        '
        Me.panel_Principal.BackColor = System.Drawing.Color.White
        Me.panel_Principal.Controls.Add(Me.Panel1)
        Me.panel_Principal.Controls.Add(Me.FlowLayoutPanel1)
        Me.panel_Principal.Controls.Add(Me.FlowLayoutPanel2)
        Me.panel_Principal.Controls.Add(Me.Label4)
        Me.panel_Principal.Controls.Add(Me.Label1)
        Me.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Principal.Location = New System.Drawing.Point(0, 0)
        Me.panel_Principal.Name = "panel_Principal"
        Me.panel_Principal.Size = New System.Drawing.Size(984, 541)
        Me.panel_Principal.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel1.Controls.Add(Me.nav_Home)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 58)
        Me.Panel1.TabIndex = 6
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
        Me.Label5.Size = New System.Drawing.Size(344, 44)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Métodos Numéricos"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.nav_Im)
        Me.FlowLayoutPanel1.Controls.Add(Me.nav_R2)
        Me.FlowLayoutPanel1.Controls.Add(Me.nav_Bi)
        Me.FlowLayoutPanel1.Controls.Add(Me.nav_RF)
        Me.FlowLayoutPanel1.Controls.Add(Me.nav_NR)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(93, 138)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(204, 306)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'nav_Im
        '
        Me.nav_Im.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.nav_Im.FlatAppearance.BorderSize = 0
        Me.nav_Im.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_Im.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_Im.ForeColor = System.Drawing.Color.White
        Me.nav_Im.IconChar = FontAwesome.Sharp.IconChar.Sketch
        Me.nav_Im.IconColor = System.Drawing.Color.White
        Me.nav_Im.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_Im.IconSize = 35
        Me.nav_Im.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_Im.Location = New System.Drawing.Point(3, 3)
        Me.nav_Im.Name = "nav_Im"
        Me.nav_Im.Size = New System.Drawing.Size(197, 54)
        Me.nav_Im.TabIndex = 1
        Me.nav_Im.Text = "Impares"
        Me.nav_Im.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nav_Im.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_Im.UseVisualStyleBackColor = False
        '
        'nav_R2
        '
        Me.nav_R2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.nav_R2.FlatAppearance.BorderSize = 0
        Me.nav_R2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_R2.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_R2.ForeColor = System.Drawing.Color.White
        Me.nav_R2.IconChar = FontAwesome.Sharp.IconChar.SquareRootAlt
        Me.nav_R2.IconColor = System.Drawing.Color.White
        Me.nav_R2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_R2.IconSize = 35
        Me.nav_R2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_R2.Location = New System.Drawing.Point(3, 63)
        Me.nav_R2.Name = "nav_R2"
        Me.nav_R2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_R2.Size = New System.Drawing.Size(197, 54)
        Me.nav_R2.TabIndex = 2
        Me.nav_R2.Text = "Raiz Cuadrada de 2"
        Me.nav_R2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_R2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_R2.UseVisualStyleBackColor = False
        '
        'nav_Bi
        '
        Me.nav_Bi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.nav_Bi.FlatAppearance.BorderSize = 0
        Me.nav_Bi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_Bi.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_Bi.ForeColor = System.Drawing.Color.White
        Me.nav_Bi.IconChar = FontAwesome.Sharp.IconChar.Modx
        Me.nav_Bi.IconColor = System.Drawing.Color.White
        Me.nav_Bi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_Bi.IconSize = 35
        Me.nav_Bi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_Bi.Location = New System.Drawing.Point(3, 123)
        Me.nav_Bi.Name = "nav_Bi"
        Me.nav_Bi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_Bi.Size = New System.Drawing.Size(197, 54)
        Me.nav_Bi.TabIndex = 3
        Me.nav_Bi.Text = "Bisección"
        Me.nav_Bi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_Bi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_Bi.UseVisualStyleBackColor = False
        '
        'nav_RF
        '
        Me.nav_RF.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.nav_RF.FlatAppearance.BorderSize = 0
        Me.nav_RF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_RF.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_RF.ForeColor = System.Drawing.Color.White
        Me.nav_RF.IconChar = FontAwesome.Sharp.IconChar.RulerHorizontal
        Me.nav_RF.IconColor = System.Drawing.Color.White
        Me.nav_RF.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_RF.IconSize = 35
        Me.nav_RF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_RF.Location = New System.Drawing.Point(3, 183)
        Me.nav_RF.Name = "nav_RF"
        Me.nav_RF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_RF.Size = New System.Drawing.Size(197, 54)
        Me.nav_RF.TabIndex = 4
        Me.nav_RF.Text = "Regla Falsa"
        Me.nav_RF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_RF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_RF.UseVisualStyleBackColor = False
        '
        'nav_NR
        '
        Me.nav_NR.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.nav_NR.FlatAppearance.BorderSize = 0
        Me.nav_NR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_NR.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_NR.ForeColor = System.Drawing.Color.White
        Me.nav_NR.IconChar = FontAwesome.Sharp.IconChar.AppleAlt
        Me.nav_NR.IconColor = System.Drawing.Color.White
        Me.nav_NR.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_NR.IconSize = 35
        Me.nav_NR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_NR.Location = New System.Drawing.Point(3, 243)
        Me.nav_NR.Name = "nav_NR"
        Me.nav_NR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_NR.Size = New System.Drawing.Size(197, 54)
        Me.nav_NR.TabIndex = 5
        Me.nav_NR.Text = "Newton Raphson"
        Me.nav_NR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_NR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_NR.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.nav_Ja)
        Me.FlowLayoutPanel2.Controls.Add(Me.nav_GS)
        Me.FlowLayoutPanel2.Controls.Add(Me.nav_IN)
        Me.FlowLayoutPanel2.Controls.Add(Me.nav_IL)
        Me.FlowLayoutPanel2.Controls.Add(Me.nav_MC)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(398, 138)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(204, 306)
        Me.FlowLayoutPanel2.TabIndex = 5
        '
        'nav_Ja
        '
        Me.nav_Ja.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nav_Ja.FlatAppearance.BorderSize = 0
        Me.nav_Ja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_Ja.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_Ja.ForeColor = System.Drawing.Color.White
        Me.nav_Ja.IconChar = FontAwesome.Sharp.IconChar.Mountain
        Me.nav_Ja.IconColor = System.Drawing.Color.White
        Me.nav_Ja.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_Ja.IconSize = 35
        Me.nav_Ja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_Ja.Location = New System.Drawing.Point(3, 3)
        Me.nav_Ja.Name = "nav_Ja"
        Me.nav_Ja.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_Ja.Size = New System.Drawing.Size(197, 54)
        Me.nav_Ja.TabIndex = 1
        Me.nav_Ja.Text = "Jacobi"
        Me.nav_Ja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_Ja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_Ja.UseVisualStyleBackColor = False
        '
        'nav_GS
        '
        Me.nav_GS.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nav_GS.FlatAppearance.BorderSize = 0
        Me.nav_GS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_GS.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_GS.ForeColor = System.Drawing.Color.White
        Me.nav_GS.IconChar = FontAwesome.Sharp.IconChar.Gofore
        Me.nav_GS.IconColor = System.Drawing.Color.White
        Me.nav_GS.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_GS.IconSize = 35
        Me.nav_GS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_GS.Location = New System.Drawing.Point(3, 63)
        Me.nav_GS.Name = "nav_GS"
        Me.nav_GS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_GS.Size = New System.Drawing.Size(197, 54)
        Me.nav_GS.TabIndex = 2
        Me.nav_GS.Text = "Gauss Seidel"
        Me.nav_GS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_GS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_GS.UseVisualStyleBackColor = False
        '
        'nav_IN
        '
        Me.nav_IN.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nav_IN.FlatAppearance.BorderSize = 0
        Me.nav_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_IN.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_IN.ForeColor = System.Drawing.Color.White
        Me.nav_IN.IconChar = FontAwesome.Sharp.IconChar.Apple
        Me.nav_IN.IconColor = System.Drawing.Color.White
        Me.nav_IN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_IN.IconSize = 35
        Me.nav_IN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_IN.Location = New System.Drawing.Point(3, 123)
        Me.nav_IN.Name = "nav_IN"
        Me.nav_IN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_IN.Size = New System.Drawing.Size(197, 54)
        Me.nav_IN.TabIndex = 3
        Me.nav_IN.Text = "Interpolación de Newton"
        Me.nav_IN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_IN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_IN.UseVisualStyleBackColor = False
        '
        'nav_IL
        '
        Me.nav_IL.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nav_IL.FlatAppearance.BorderSize = 0
        Me.nav_IL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_IL.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_IL.ForeColor = System.Drawing.Color.White
        Me.nav_IL.IconChar = FontAwesome.Sharp.IconChar.Pushed
        Me.nav_IL.IconColor = System.Drawing.Color.White
        Me.nav_IL.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_IL.IconSize = 35
        Me.nav_IL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_IL.Location = New System.Drawing.Point(3, 183)
        Me.nav_IL.Name = "nav_IL"
        Me.nav_IL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_IL.Size = New System.Drawing.Size(197, 54)
        Me.nav_IL.TabIndex = 4
        Me.nav_IL.Text = "Interpolación  de Lagrange"
        Me.nav_IL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_IL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_IL.UseVisualStyleBackColor = False
        '
        'nav_MC
        '
        Me.nav_MC.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.nav_MC.FlatAppearance.BorderSize = 0
        Me.nav_MC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_MC.Font = New System.Drawing.Font("Advent Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_MC.ForeColor = System.Drawing.Color.White
        Me.nav_MC.IconChar = FontAwesome.Sharp.IconChar.Th
        Me.nav_MC.IconColor = System.Drawing.Color.White
        Me.nav_MC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nav_MC.IconSize = 35
        Me.nav_MC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_MC.Location = New System.Drawing.Point(3, 243)
        Me.nav_MC.Name = "nav_MC"
        Me.nav_MC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nav_MC.Size = New System.Drawing.Size(197, 54)
        Me.nav_MC.TabIndex = 6
        Me.nav_MC.Text = "Mínimos Cuadrados"
        Me.nav_MC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_MC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nav_MC.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Antic Slab", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(368, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 32)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "SEGUNDO PARCIAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Antic Slab", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRIMER PARCIAL"
        '
        'MetodosNumericos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 541)
        Me.Controls.Add(Me.panel_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MetodosNumericos"
        Me.Text = "Métodos Numéricos"
        Me.panel_Principal.ResumeLayout(False)
        Me.panel_Principal.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_Principal As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents nav_Im As FontAwesome.Sharp.IconButton
    Friend WithEvents nav_R2 As FontAwesome.Sharp.IconButton
    Friend WithEvents nav_Bi As FontAwesome.Sharp.IconButton
    Friend WithEvents nav_RF As FontAwesome.Sharp.IconButton
    Friend WithEvents nav_NR As FontAwesome.Sharp.IconButton
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents nav_Ja As FontAwesome.Sharp.IconButton
    Friend WithEvents nav_GS As FontAwesome.Sharp.IconButton
    Friend WithEvents nav_IN As FontAwesome.Sharp.IconButton
    Friend WithEvents nav_IL As FontAwesome.Sharp.IconButton
    Friend WithEvents nav_MC As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents nav_Home As PictureBox
End Class
