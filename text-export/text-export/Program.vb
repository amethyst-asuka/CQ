Imports Microsoft.VisualBasic.Language.UnixBash
Imports Microsoft.VisualBasic.Serialization.JSON

Module Program

    Sub Main()
        For Each file As String In ls - l - r - "*.json" <= "../../json/text/"
            file.LoadJSON(Of text) _
                .text _
                .Tsv($"../../text/{file.BaseName}.xls")
        Next
    End Sub
End Module

Public Class text
    Public Property status As String
    Public Property text As Dictionary(Of String, String)
End Class