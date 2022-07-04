#language: pt-br
Funcionalidade: Checkout
    
Esquema do Cenário: Realizar uma compra com sucesso
	Dado que acesso o site
	Quando informo as seguintes credenciais
		| Username      | Password     |
		| standard_user | secret_sauce |
	E me autentico no sistema
	E adiciono o produto <produto>
	E visualizo o carrinho
	E sigo para as informações do Checkout
	E insiro as seguintes informações pessoais
		| FirstName | LastName | ZipPostalCode |
		| teste     | CWI      | "91910400"    |
	E sigo para o Overview do Checkout
	E finalizo a compra
	Então a página de pedido completo é exibida contendo a mensagem THANK YOU FOR YOUR ORDER
 

Exemplos:
	| produto             |
	| Sauce Labs Backpack |
	| Sauce Labs Onesie   |


Esquema do Cenário: Verificar preços
	Dado que acesso o site
	Quando informo as seguintes credenciais
		| Username      | Password     |
		| standard_user | secret_sauce |
	E me autentico no sistema
	Então verifico se o valor <valor> corresponde ao item de número <contador>
		

Exemplos: 
| valor  | contador |
| $29.99 | 1        |
| $9.99  | 2        |
| $15.99 | 3        |
| $49.99 | 4        |
| $7.99  | 5        |
| $15.99 | 6        |


