Imports PCInterfaceLibrary
Imports System.ComponentModel.Composition
<Export(GetType(IPCCreator)), ExportMetadata("PCType", 1)>
Public Class PC1
    Implements IPCCreator




    Public Function ShowMessag() As String Implements PCInterfaceLibrary.IPCCreator.ShowMessag
        ShowMessag = "PC1"
    End Function
End Class
