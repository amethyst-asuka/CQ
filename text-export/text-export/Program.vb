Imports Microsoft.VisualBasic.Language.UnixBash
Imports Microsoft.VisualBasic.MIME.application.json
Imports Microsoft.VisualBasic.MIME.application.json.Parser
Imports Microsoft.VisualBasic.Serialization.JSON

Module Program

    Sub Main()
        For Each file As String In ls - l - r - "*.json" <= "../../json/text/"
            Dim json = file.ReadAllText.ParseJson.As(Of JsonObject)
            Dim text = json!text.As(Of JsonArray)
            Dim table As Dictionary(Of String, String) = text _
                .Select(Function(item)
                            Return item.As(Of JsonObject).First
                        End Function) _
                .ToDictionary(Function(item) item.Name,
                              Function(item)
                                  Dim str = item.Value _
                                             .As(Of JsonValue) _
                                             .Value _
                                            ?.ToString

                                  If str.StringEmpty Then
                                      Return ""
                                  Else
                                      Return Strings.Trim(str).LoadJSON(Of String)
                                  End If
                              End Function)

            Call table.Tsv($"../../text/{file.BaseName}.xls")
        Next
    End Sub
End Module