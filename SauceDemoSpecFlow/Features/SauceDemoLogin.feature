Feature: Validação do Login

Background: Abrir o webdriver e Aplicação
    Given Dado que consigo   carregar a aplicação

@LoginValidUser
Scenario Outline: Validação do Login com usuário ativo
    And Informo o nome de "<nome_user>" e "<passwd_user>" válidos
    When Clico no botão login
    Then Devo ser redirecionado para tela inicial do Digital
    And Então deve fazer logout
    Examples:
        | nome_user       | passwd_user   |
        | standard_user   | secret_sauce  |
        | performance_glitch_user | secret_sauce  |
