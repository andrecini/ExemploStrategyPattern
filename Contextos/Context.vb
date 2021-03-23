''' <summary>
''' Classe responsável por Setar a estratégia e por executar 
''' o Teste Desejado (Conforme  estratégia)
''' </summary>
Public Class Context
    'Criação da váriavel  estratégia referente
    'à interface
    Private strategy As IStrategy

    'Seta a estratégia conforme o objeto referente à 
    'instância da classe Teste passada por parâmetro
    
    Public Sub SetStrategy(ByVal strategy As Object)
        Me.strategy = strategy
    End Sub

    'Executa o método do Teste desejado
    Public Sub ExecuteStrategy(text As String)
        strategy.ExecuteAction(text)
    End Sub
End Class
