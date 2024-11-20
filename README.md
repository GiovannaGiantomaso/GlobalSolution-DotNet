Projeto de Monitoramento de Consumo de Energia

📖 Descrição do Projeto
Este projeto é um sistema de monitoramento de consumo de energia elétrica que permite aos usuários:

- Registrar manualmente o consumo mensal de energia.
- Acompanhar a evolução do consumo ao longo do tempo.
- Receber feedbacks personalizados com base no consumo mensal.
  
A proposta central é promover a conscientização sobre o uso de energia, incentivando hábitos sustentáveis por meio de uma interface simples e intuitiva.

📋 ## Funcionalidades Principais
🔹 Registro Mensal de Consumo
- Os usuários podem inserir manualmente o consumo de energia mensal.
- Os dados são armazenados no banco de dados Oracle, garantindo integridade e persistência.
O sistema organiza os registros por data, permitindo fácil consulta ao histórico.
🔹 Histórico de Consumo
Exibe o consumo mensal e o total acumulado pelo usuário.
🔹 Feedback sobre o Consumo
- Feedbacks personalizados são fornecidos, incentivando o usuário a ajustar seus hábitos de uso de energia.
  
🎯 ## Objetivo do Projeto
O objetivo principal é promover a conscientização e incentivar o uso responsável de energia. Com um sistema simples e visualmente informativo, os usuários podem:

- Monitorar o consumo mensal.
- Entender melhor os seus padrões de uso de energia.
Tomar decisões mais sustentáveis para reduzir custos e ajudar o meio ambiente.

🚀 ## Tecnologias Utilizadas
- .NET Core
- Oracle Database
- Swagger (para documentação de APIs)
- Git
🛠️ ## Configuração do Projeto
Pré-requisitos
Certifique-se de que as seguintes ferramentas estão instaladas:
- .NET SDK
- Oracle Database
- Git
  
## Como Executar o Projeto
Clone este repositório:
git clone https://github.com/GiovannaGiantomaso/GlobalSolution-DotNet.git
cd GsDotNet

## Configure o banco de dados Oracle:

Atualize as credenciais no arquivo appsettings.json:
{
    "ConnectionStrings": {
        "OracleConnection": "Data Source=YOUR_ORACLE_SERVER;User ID=YOUR_USER;Password=YOUR_PASSWORD;"
    }
}
Execute o projeto:

dotnet run
