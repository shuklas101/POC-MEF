Imports PCInterfaceLibrary
Imports System.ComponentModel.Composition
<Export(GetType(IPCCreator)), ExportMetadata("PCType", 2)>
Public Class PC2
    Implements IPCCreator
    Public Function ShowMessage() As String Implements PCInterfaceLibrary.IPCCreator.ShowMessag
        ShowMessage = "PC2"
    End Function
End Class
