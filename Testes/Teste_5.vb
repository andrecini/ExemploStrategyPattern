''' <summary>
''' Classe com o código do Teste 5 encapsulado, que implementa o método
''' "ExecuteAction" da interface IStrategy.
''' </summary>
Public Class Teste_5
    Implements IStrategy
        
    Public Sub ExecuteAction(text As String) Implements IStrategy.ExecuteAction
        Console.WriteLine("O metodo 'Execute()' do Teste 5 escreve isso: {0}", text)
    End Sub
End Class
