# 📱 DesafioPOO - Simulação de Smartphones em C#

Este projeto tem como objetivo aplicar conceitos de Programação Orientada a Objetos (POO) em C#, simulando o comportamento de diferentes modelos de smartphones. A estrutura foi desenvolvida com base em herança, abstração e polimorfismo.

[![Imagem de capa](https://github.com/robsonosbor/net-desafio-poo/blob/main/screenshot.png)](/)

## 🧠 Conceitos Aplicados

- **Abstração**: A classe `Smartphone` define uma estrutura comum para todos os smartphones.
- **Herança**: As classes `Nokia` e `Iphone` herdam de `Smartphone`.
- **Polimorfismo**: Cada modelo implementa seu próprio comportamento para o método `InstalarAplicativo`.

## 📁 Estrutura do Projeto
```plaintext
DesafioPOO/
├── Program.cs
└── Models/
    ├── Smartphone.cs
    ├── Nokia.cs
    └── Iphone.cs

```

## 📄 Classes

### Smartphone (abstrata)

Define a estrutura base de um smartphone:

- Propriedades:
  - `Numero` (pública)
  - `Modelo`, `Imei`, `Memoria` (privadas)
- Métodos:
  - `Ligar()`
  - `ReceberLigacao()`
  - `InstalarAplicativo(string nomeApp)` (abstrato)

### Nokia

- Herda de `Smartphone`
- Implementa `InstalarAplicativo` com mensagem personalizada

### Iphone

- Herda de `Smartphone`
- Implementa `InstalarAplicativo` com mensagem personalizada

## 🚀 Execução

O arquivo `Program.cs` demonstra o uso das classes:

```csharp
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456789", "Modelo Nokia", "12121212", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iPhone = new Iphone("987654321", "Modelo iPhone", "45454545", 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("ChatGPT");

```

## ✅ Requisitos
- .NET SDK instalado
- Editor de código (Visual Studio, VS Code, etc.)

## ▶️ Como Executar
1. Clone o repositório
2. Compile com dotnet build
3. Execute com dotnet run

## 📌 Observações
- As propriedades privadas da classe Smartphone podem ser expandidas com métodos de acesso (get/set) conforme necessidade.
- O projeto pode ser estendido com novos modelos e funcionalidades.
