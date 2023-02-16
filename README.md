# InjecaoDependencia.WebApi

#API desenvolvida em .net 6 que retorna valores Guid para comparação dos tipos de injeção de dependência/requisições abaixo:

<h5>Singleton: Significa que apenas uma única instância será criada. Essa instância é compartilhada entre todos os componentes que exigem isso. A mesma instância é, portanto, usada sempre até o tempo de vida do domínio do aplicativo.

<h5>Scoped: Uma instância única para a duração da solicitação com escopo, o que significa por solicitação HTTP no ASP.NET.

<h5>Transient: Uma única instância por solicitação de código, os componentes são criados toda vez que são solicitados e nunca são compartilhados.

