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
- O sistema compara o consumo atual com o mes anterior.
- Feedbacks personalizados sao fornecidos, incentivando o usuário a ajustar seus habitos de uso de energia.

---

##  Objetivo do Projeto

O objetivo principal é promover a conscientização e incentivar o uso responsavel de energia. Com um sistema simples e visualmente informativo, os usuarios podem:
- Monitorar o consumo mensal.
- Entender melhor os seus padroes de uso de energia.
- Tomar decisoes mais sustentaveis para reduzir custos e ajudar o meio ambiente.

---
## Tecnologias Utilizadas

.NET Core
Oracle Database
Swagger (para documentação de APIs)
Git

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

3. Compile e execute o projeto:
dotnet run
   Clone este repositorio:
   git clone https://github.com/GiovannaGiantomaso/GlobalSolution-DotNet.git
   cd GS-DOT-NET
