:root { --branco-principal:
    #FFFFFF;
    --cinza-secundario:
    #C0C0C0;
    --botao-azul: #167BF7;
    --cor-de-fundo: #00030C;
    --fonte-principal: 'Inter';
}


body {
    background-color: var(--cor-de-fundo);
    color: var(--branco-principal);
    font-family: var(--fonte-principal);
    font-size: 16px;
    font-weight: 400;
}

*{
    margin: 0;
    padding: 0;
    }
    .principal {
        background-image: url("img/Background.png");
        background-repeat: no-repeat;
        width: 100%;
    }
    
    
    
    .container__botao {
        background-color: var(--botao-azul);
        border-radius: 5px;
        padding: 1em;
        color: var(--branco-principal);
        display: block;
        text-decoration: none;
        margin-bottom: 1em;
    
    }
    
    .botao_secundario {
        background-color: transparent;
        border: 2px solid var(--branco-principal);
    padding: 1em;
    }

    .container {
        height: 100vh;
        display: grid;
        grid-template-columns: 50% 50%;
    }
    

    .container__aviso {
        font-size: 12px;
        color: var(--cinza-secundario);
    }
    .container__imagem {
        margin: 1em 0 2em 0;
    }
    
    .container__caixa {
        margin: 0 6em;
    }

    .secundario__imagem {
        width: 80%;
    }
  
    .secundario {
        align-items: center;
        margin: 0 10em;
    }
  
    .descricao__titulo {
        font-weight: 700;
        font-size: 48px;
        color: var(--branco-principal);
        margin-bottom: 0.1em;
    }

    .descricao__texto {
        color: var(--cinza-secundario);
    }
  
    .secundario__botao {
        display: inline-block;
        margin-top: 1em;
    }

    .container__descricao {
        padding: 2em;
    }