# TicketProcessor API

API para processamento de tickets com integração ao DeepSeek Chat.

## Requisitos

- .NET 9.0 SDK
- Visual Studio Code ou Visual Studio (opcional)

## Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/ticket-processor.git
   cd ticket-processor
   ```
2. Execute o app:
    ```bash
    dotnet run --project TicketProcessor
    ```
# Uso da API DeepSeek

## EndPoint

POST /api/deepseek/chamada

### Exemplo de chamada pelo powershell
   ```bash
   curl -X POST "http://localhost:5222/api/deepseek/chamada" \
  -H "Content-Type: application/json" \
  -d '{"question": "O que é a terra?"}'
   ```

### Resposta do Exemplo (JSON)
    ```JSON
        {
        "id": "gen-1745886575-rIG0Y6FP6OjxN23RHIQe",
        "provider": "Chutes",
        "model": "deepseek/deepseek-chat:free",
        "object": "chat.completion",
        "created": 1745886575,
        "choices": [
            {
            "logprobs": null,
            "finish_reason": "stop",
            "native_finish_reason": "stop",
            "index": 0,
            "message": {
                "role": "assistant",
                "content": "A Terra é o terceiro planeta a partir do Sol e o único objeto astronômico conhecido por abrigar vida. Aqui estão alguns aspectos fundamentais sobre a Terra:\n\n1. **Estrutura e Composição**:\n   - A Terra é composta por várias camadas: a crosta terrestre (superfície sólida), o manto (uma camada de rocha semi-sólida), o núcleo externo (líquido) e o núcleo interno (sólido).\n   - A superfície da Terra é coberta por aproximadamente 71% de água (oceanos, mares, lagos e rios) e 29% de terra (continentes e ilhas).\n\n2. **Atmosfera**:\n   - A Terra é envolta por uma camada de gases, chamada atmosfera, composta principalmente por nitrogênio (78%) e oxigênio (21%), com traços de outros gases como argônio, dióxido de carbono e vapor de água.\n   - A atmosfera protege a vida na Terra absorvendo radiação ultravioleta solar e reduzindo as variações extremas de temperatura entre o dia e a noite.\n\n3. **Vida**:\n   - A Terra é o único planeta conhecido com condições que permitem a existência de vida como a conhecemos. Essas condições incluem a presença de água líquida, uma atmosfera adequada e uma temperatura compatível com a vida.\n\n4. **Movimento e Tempo**:\n   - A Terra realiza dois movimentos principais: a rotação (girar em torno de seu próprio eixo), que leva aproximadamente 24 horas e causa o ciclo do dia e da noite, e a translação (movimento ao redor do Sol), que leva cerca de 365,25 dias para ser completado, definindo o ano.\n   - A inclinação do eixo da Terra (aproximadamente 23,5 graus) em relação à sua órbita ao redor do Sol é responsável pelas estações do ano.\n\n5. **Geologia e Recursos**:\n   - A Terra possui uma variedade de formações geológicas, como montanhas, vales, desertos, florestas e vulcões.\n   - Ela é rica em recursos naturais, incluindo minerais, combustíveis fósseis, água e solo fértil, que são essenciais para a vida e a civilização humana.\n\n6. **Sistema Solar**:\n   - A Terra faz parte do Sistema Solar, que inclui o Sol, oito planetas principais, suas luas, planetas anões, asteroides, cometas e outros objetos celestes.\n   - A Lua é o único satélite natural da Terra e tem influência significativa sobre as marés oceânicas e a estabilidade do eixo de rotação do planeta.\n\nA Terra é um sistema complexo e dinâmico, onde processos geológicos, atmosféricos, hidrológicos e biológicos interagem para sustentar a vida e moldar o ambiente.",
                "refusal": null,
                "reasoning": null
            }
            }
        ],
        "usage": {
            "prompt_tokens": 13,
            "completion_tokens": 590,
            "total_tokens": 603
        }
        }
    ```

## Estrutura do Projeto

TicketProcessor/
├── .vscode/
├── Configurations/
├── Controllers/
├── Properties/
├── Utils/
├── appsettings.json
├── Main.cs
└── TicketProcessor.csproj

