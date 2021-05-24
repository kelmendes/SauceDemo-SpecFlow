Feature: Realizar operações para validar o carrinho

Background: Login Aplicação
    Given Dado que consigo   carregar a aplicação

@CartAddItems
Scenario: Adicionando Itens ao carrinho de compras
    And Informo o nome de "performance_glitch_user" e "secret_sauce" válidos
    And Clico no botão login
    And Devo ser redirecionado para tela inicial do Digital
    And Adiciono os itens "Sauce Labs Backpack, Sauce Labs Bike Light, Sauce Labs Onesie, Test.allTheThings() T-Shirt (Red), Sauce Labs Fleece Jacket, Sauce Labs Bolt T-Shirt" clicando no botão Add to Cart
    When O contado de itens no carrinho deve mudar
    Then Então deve fazer logout
