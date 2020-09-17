Imports System.ComponentModel.Composition
Imports System.ComponentModel.Composition.Hosting
Imports PCInterfaceLibrary

Public Class Form1
    <ImportMany()>
    Public Property PCs() As Lazy(Of IPCCreator, IPCMetadata)()
    Dim listofPC As New Dictionary(Of Integer, IPCCreator)


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim catalog As AggregateCatalog = Nothing
        Dim container As CompositionContainer = Nothing

        catalog = New AggregateCatalog()
        catalog.Catalogs.Add(New DirectoryCatalog("."))
        container = New CompositionContainer(catalog)
        container.SatisfyImportsOnce(Me)

        TestArray()

    End Sub

    Private Sub TestArray()
        For Each pc In PCs
            listofPC.Add(pc.Metadata.PCType, pc.Value)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim PC As IPCCreator = listofPC(1)
        MessageBox.Show(PC.ShowMessag())
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim PC As IPCCreator = listofPC(2)
        MessageBox.Show(PC.ShowMessag())

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim PC As IPCCreator = listofPC(3)
        MessageBox.Show(PC.ShowMessag())


    End Sub
End Class
