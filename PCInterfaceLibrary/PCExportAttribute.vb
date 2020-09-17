Imports System.ComponentModel.Composition
<MetadataAttribute()>
<AttributeUsage(AttributeTargets.Class, AllowMultiple:=True)>
Public Class PCExportAttribute
    Inherits ExportAttribute

    Public Property MyMetadata As Integer

    Public Sub New(ByVal myMetadata As Integer)
        MyBase.New(GetType(IPCCreator))

        myMetadata = myMetadata
    End Sub

End Class

