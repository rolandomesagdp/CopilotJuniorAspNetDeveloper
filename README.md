# Copilot as junior developer
This repository is meant to be used in order to test Copilot's Pro capabilities as Junior Developer.

This repository contains an Asp.Net Core application. The project structure is based on a Clean Architecture.

The idea here is to assign Copilot with a task in order to understand the workflow and in order to check Copilot skills as junior developer

## 🧩 Using GitHub Copilot to Fix Issues Across Repositories

This project demonstrates how to use GitHub Copilot as a “junior developer” to analyze issues created in a separate repository and generate code fixes, patches, and unit tests in this codebase.

Follow the steps below to reproduce the workflow.

---

### 1. Create an Issue in a Separate Repository
Open the repository where you want to track issues (for example:  
`https://github.com/rolandomesagdp-diverse/copilot-junior-repor-for-project`) and create a new issue describing the bug or feature request.

---

### 2. Navigate to the Issue
Open the URL of the issue you just created.

---

### 3. Click “Chat with Copilot” in the Top Bar
This opens the Copilot chat window associated with the issue.

---

### 4. Configure the Copilot Chat Dropdowns

#### **Model**
Select **Claude Opus 4.6** (recommended for deep code reasoning and accurate patch generation).

#### **Ask / Agent**
Select **Agent** (this instructs Copilot to perform the task rather than simply answer questions).

#### **Repository**
Select the **code repository** where the actual source code lives.

---

### 5. Paste the Copilot Prompt

Use the following prompt to instruct Copilot to analyze the issue and propose a fix:

```
Please analyze this issue, inspect the code in this repository, and propose a fix.
Generate the patch, explain the changes, and prepare a Pull Request description.
Also generate a unit test that covers the scenario where the person does not exist.
```
