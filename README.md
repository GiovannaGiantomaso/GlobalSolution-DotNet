# Projeto de Monitoramento de Consumo de Energia

## Descrição do Projeto

Este projeto é um sistema de monitoramento de consumo de energia eletrica que permite aos usuarios:
- Registrar manualmente o consumo mensal de energia.
- Acompanhar a evolução do consumo ao longo do tempo.
- Receber feedbacks personalizados com base no consumo mensal.

A proposta central é promover a conscientizacao sobre o uso de energia, incentivando habitos sustentaveis por meio de uma interface simples e intuitiva.

---

### Funcionalidades Principais

### Registro Mensal de Consumo
- Os usuarios podem inserir manualmente o consumo de energia mensal.
- Os dados sao armazenados no banco de dados Oracle, garantindo integridade e persistencia.
- O sistema organiza os registros data, permitindo facil consulta ao historico.

### Historico de Consumo
- Mostra o consumo mensal e o total do usuario 

### Feedback sobre o Consumo
- O sistema compara os consumos.
- Feedbacks personalizados sao fornecidos, incentivando o usuário a ajustar seus habitos de uso de energia.

---

##  Objetivo do Projeto

O objetivo principal é promover a conscientização e incentivar o uso responsavel de energia. Com um sistema simples e visualmente informativo, os usuarios podem:
- Monitorar o consumo mensal.
- Entender melhor os seus padroes de uso de energia.
- Tomar decisoes mais sustentaveis para reduzir custos e ajudar o meio ambiente.

---
 ## Tecnologias Utilizadas

- .NET Core
- Oracle Database
- Swagger (para documentação de APIs)
- Git

## Configuração do Projeto

### Pre-requisitos

Certifique-se de que as seguintes ferramentas estao instaladas:
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Oracle Database](https://www.oracle.com/database/)
- [Git](https://git-scm.com/)

### Como Executar o Projeto

1. Clone este repositório:
git clone https://github.com/GiovannaGiantomaso/GlobalSolution-DotNet.git
cd GsDotNet

2. Configure o banco de dados Oracle:
Atualize as credenciais no arquivo appsettings.json.
{
    "ConnectionStrings": {
       "OracleConnection": "User Id= "seu user da fiap";Password= "sua senha";Data Source=oracle.fiap.com.br:1521/orcl"
    }
}

3. Compile e execute o projeto:
dotnet run
   Clone este repositorio:
   git clone https://github.com/GiovannaGiantomaso/GlobalSolution-DotNet.git
   cd GS-DOT-NET
   
## INTEGRANTES:
- RM 553369
- RM 553764
- RM 84059
  
## EXEMPLOS DE JSON PARA UTILIZAR:

### Usuário Energia
- Criar Usuário
{
  "nome": "Maria Oliveira",
  "email": "maria.oliveira@gmail.com",
  "senha": "senhaSegura123"
}

- Atualizar Usuário
{
  "idUsuario": substitua pelo id gerado,
  "nome": "Maria Oliveira Atualizada",
  "email": "maria.oliveira.updated@gmail.com",
  "senha": "novaSenha123"
}

### Consumo Energia
- Criar Consumo

{
  "idUsuario": substitua pelo id gerado,
  "consumoKwh": 120.75
}

### Histórico Consumo
- Criar Histórico de Consumo

{
  "idUsuario": substitua pelo id gerado
}

### Feedback Consumo
- Criar Feedback

{
  "idUsuario": substitua pelo id gerado,
  "mensagemFeedback": "Parabens! Continue colaborando com a redução de energia."
}
