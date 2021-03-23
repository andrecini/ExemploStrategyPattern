''' <summary>
''' Classe com o código do Teste 4 encapsulado, que implementa o método
''' "ExecuteAction" da interface IStrategy.
''' </summary>
Public Class Teste_4
    Implements IStrategy

    Public Sub ExecuteAction(text As String) Implements IStrategy.ExecuteAction
        Console.WriteLine("O metodo 'Execute() do Teste 4 escreve isso: {0}", text)
    End Sub
End Class
