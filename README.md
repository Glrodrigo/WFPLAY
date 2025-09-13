# WFPLAY

## 🎯 Objetivo

O projeto **WFPLAY** foi desenvolvido para facilitar a vida de usuários que precisam **converter arquivos de vídeo para áudio** de forma rápida e prática. Ele permite extrair o áudio de diversos formatos de vídeo, como `.webm`, `.mp4`, `.mkv` e `.avi`, e salvar o resultado em `.mp3` diretamente na **Área de Trabalho**.

---

## 🖥️ Como rodar a aplicação

### Pré-requisitos

* Visual Studio 2022 ou superior
* .NET 8 SDK instalado

### Passos

1. **Clone o repositório:**

```bash
git clone https://github.com/Glrodrigo/WFPLAY.git
```

2. **Abra a solução** (`.sln`) no Visual Studio.
3. **Restaure os pacotes NuGet**, se necessário.
4. **Construa o projeto:**

   * Menu: `Build → Build Solution`
   * Ou atalho: `Ctrl + Shift + B`
5. **Execute a aplicação:**

   * Menu: `Debug → Start Without Debugging`
   * Ou atalho: `Ctrl + F5`

### Nota

O arquivo `.exe` será gerado na pasta:

```
bin\Debug\net8.0-windows\
```

dentro da pasta do projeto. Exemplo de caminho completo:

```
C:\Users\SeuUsuario\Documents\Projetos\WFplay\WFPLAY\WFPLAY\bin\Debug\net8.0-windows\
```

Basta dar um duplo clique no `.exe` para executar a aplicação sem abrir o Visual Studio.

---

## ⚙️ Funcionalidades

* Seleção de arquivos de vídeo (`.webm`, `.mp4`, `.mkv`, `.avi`).
* Conversão do áudio para `.mp3`.
* Arquivos convertidos são salvos na **Área de Trabalho**.
* Interface simples com **botão de importação** e **barra de progresso**.

---

## 📝 Observações

* Para arquivos grandes, recomenda-se aguardar a **barra de progresso** terminar antes de tentar importar outro arquivo.
* A aplicação foi projetada para rodar no **Windows Forms com .NET 8**.
* Este projeto é **open-source** e pode ser adaptado para incluir outros formatos de áudio ou vídeo conforme necessário.
