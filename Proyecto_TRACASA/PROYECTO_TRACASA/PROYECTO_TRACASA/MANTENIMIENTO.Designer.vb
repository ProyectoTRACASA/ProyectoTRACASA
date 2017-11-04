<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MANTENIMIENTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MANTENIMIENTO))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_M_choferes = New System.Windows.Forms.TabPage()
        Me.tab_M_usuario = New System.Windows.Forms.TabPage()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_M_choferes)
        Me.TabControl1.Controls.Add(Me.tab_M_usuario)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1355, 835)
        Me.TabControl1.TabIndex = 0
        '
        'tab_M_choferes
        '
        Me.tab_M_choferes.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tab_M_choferes.Location = New System.Drawing.Point(4, 25)
        Me.tab_M_choferes.Name = "tab_M_choferes"
        Me.tab_M_choferes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_M_choferes.Size = New System.Drawing.Size(1347, 806)
        Me.tab_M_choferes.TabIndex = 0
        Me.tab_M_choferes.Text = "CHOFERES"
        '
        'tab_M_usuario
        '
        Me.tab_M_usuario.Location = New System.Drawing.Point(4, 25)
        Me.tab_M_usuario.Name = "tab_M_usuario"
        Me.tab_M_usuario.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_M_usuario.Size = New System.Drawing.Size(1347, 806)
        Me.tab_M_usuario.TabIndex = 1
        Me.tab_M_usuario.Text = "USUARIOS"
        Me.tab_M_usuario.UseVisualStyleBackColor = True
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\ENVY\Documents\GitHub\ProyectoTRACASA\Componentes Graficos Vb2\SKIN NET " &
    "2010 WIN 7\SkinVS.NET\Diamond\DiamondBlue.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'MANTENIMIENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 844)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MANTENIMIENTO"
        Me.Text = "MANTENIMIENTO"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_M_choferes As TabPage
    Friend WithEvents tab_M_usuario As TabPage
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
