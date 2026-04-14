namespace Pessoa

    type Pessoa = {
        nome: string
        Estado: string
        cidade: string
        pais: string
    }

    type Response = {
        pessoa: Pessoa
    }