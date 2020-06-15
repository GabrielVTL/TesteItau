#language: pt

Funcionalidade: Validar pesquisa do iCarros

Cenário: 1 Armazenar dados da pesquisa
	Dado que o usuario acessa a plataforma "https://www.icarros.com.br/principal/index.jsp"
	Quando realizar a pesquisa de veiculos usados
	| Keys   | Values     |
	| Marca  | Volkswagen |
	| Modelo | Fox        |
	Então armazenar dados da pesquisa

Cenário: 2 Validar os dados armazenados da pesquisa
	Dado que o usuario acessa a plataforma "https://www.icarros.com.br/principal/index.jsp"
	Quando realizar a pesquisa de veiculos usados
	| Keys   | Values     |
	| Marca  | Volkswagen |
	| Modelo | Fox        |
	Então validar os dados armazenados da pesquisa