Imports System.Reflection

Module Module1

    'Lista de classes normais e especiais 
    private Dim classes As List(Of Object) = New List(Of Object)
    private Dim classesEE As List(Of Object) = New List(Of Object)

    'Teste desejado.
    private Const teste_Number = 4
    private Const testeEE_Number = 2

    'Instância da Classe Context
    Public Dim context As Context = New Context()

    Sub Main()
       SetListOfTests(classes)
       SetListOfTests(classesEE)

       Dim testExecutor As TestExecutor = New TestExecutor(teste_Number, "Sou um teste Normal", classes)
       testExecutor.ExecuteTeste()

       Dim testExecutorEE As TestExecutor = New TestExecutor(testeEE_Number, "Sou um teste Especial", classesEE)
       testExecutorEE.ExecuteTeste()
        
       Console.ReadLine()
    End Sub

    ''' <summary>
   '''Adiciona na lista de classes todos os testes
   '''(quando for necessário criar um novo teste,
   '''basta criar a classe e adicionar nessa lista).
   ''' </summary>
   ''' <param name="classes">Lista de classes desejada</param>
    Sub SetListOfTests(ByRef classes As List(Of Object))
        classes.Add(New Teste_1())
        classes.Add(New Teste_2())
        classes.Add(New Teste_3())
        classes.Add(New Teste_4())
        classes.Add(New Teste_5())
    End Sub

        
End Module
