Public Class TestExecutor
    'Instância da classe Context
    Private Dim context As Context = New Context()
    
    'Variáveis que irão ser setadas pelo
    'construtor e utilizadas na classe
    Private Dim teste_number As Integer
    Private Dim content As String
    Private Dim classes As List(Of Object) = New List(Of Object)

    ''' <summary>
    ''' Construtor que define variáveis para utilização interna
    ''' </summary>
    ''' <param name="num">Teste Desejado</param>
    ''' <param name="list">Lista de Teste</param>
    Public Sub New(ByVal num As Integer, ByVal str As String, ByVal list As List(Of Object))
        teste_number = num
        content = str
        classes = list
    End Sub
    
    ''' <summary>
    ''' Seta qual estatégia será utilizada
    ''' </summary>
    ''' <param name="num">Inteiro referente ao Teste desejado</param>
    ''' <param name="exists">Boolean referente à existência (ou não)
    ''' do Teste desejado</param>
    Private Sub SetStrategy(ByVal classes As List(Of Object), ByVal num As Integer, ByRef exists As Boolean)
        'Varre a lista de classes Teste
        For Each obj in classes
            'Pega o tipo do objeto
            Dim type = obj.GetType

            'Remove a parte "Teste" da string referente ao nome
            'do objeto atual (selecionando somente o seu número)
            'e compara com o inteiro do teste desejado
            If type.Name.Replace(type.Name.Substring(0, type.Name.IndexOf("_") + 1), "") = num.ToString()
                context.SetStrategy(obj)
                exists = True            
            End If
        Next 
    End Sub

    ''' <summary>
    ''' Método Público que executará o teste desejado,
    ''' conforme a lista, o id do teste e o conteúdo pas-
    ''' sados com parâmetro.
    ''' </summary>
    Public Sub ExecuteTeste()
        'Variável para verificar se o teste Realmente existe 
        '(Se existir retorna "True", senão, "False").
        Dim verifyRevisionExists As Boolean = False

        SetStrategy(classes, teste_number, verifyRevisionExists)
        
        If verifyRevisionExists Then
            context.ExecuteStrategy(content)
        Else
            Console.WriteLine("ERRO: Teste não encontrado!!!")
        End If
    End Sub
End Class
