'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Info_Informe_Barras
    Public Property Info_ID As Integer
    Public Property Info_ID_Carreras As Nullable(Of Integer)
    Public Property Info_ID_Chofer As Nullable(Of Integer)
    Public Property Info_Fecha_Hora As Nullable(Of Date)
    Public Property Info_Ruta As Nullable(Of Integer)
    Public Property Info_Unidad As Nullable(Of Integer)
    Public Property Info_Cod_Usuario As Nullable(Of Integer)
    Public Property Info_Boleta As Nullable(Of Integer)
    Public Property Info_Sobrante As Nullable(Of Double)
    Public Property Info_Vales As Nullable(Of Double)
    Public Property Info_Adultos_Mayores As Nullable(Of Integer)

    Public Overridable Property Ca_Carreras As Ca_Carreras
    Public Overridable Property Cho_Choferes As Cho_Choferes
    Public Overridable Property Pla_Planilla As ICollection(Of Pla_Planilla) = New HashSet(Of Pla_Planilla)

End Class
