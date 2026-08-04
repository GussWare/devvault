# DevVault

DevVault es un experimento de desarrollo de software **AI-Native** cuyo objetivo es evaluar y perfeccionar un workflow de desarrollo basado en **Specification-Driven Development (SDD)** y colaboración entre agentes de inteligencia artificial.

El proyecto utiliza un mini-producto deliberadamente sencillo como vehículo para experimentar con el proceso de desarrollo, las herramientas y la colaboración entre agentes. El objetivo principal no es construir un producto complejo, sino obtener evidencia sobre qué tan efectivo, reproducible y mantenible resulta este enfoque.

## Objetivo

Evaluar un workflow en el que la **Specification es la fuente de verdad del comportamiento del producto** y donde las decisiones, planificación, implementación y verificación mantienen una relación explícita.

El experimento busca comprobar cómo diferentes herramientas y agentes pueden colaborar dentro de este proceso sin perder control sobre la arquitectura, los requisitos ni la calidad del código.

## Workflow

El desarrollo seguirá, de forma general, el siguiente flujo:

```text
Specification
      ↓
Architecture
      ↓
Plan
      ↓
Tasks
      ↓
Implementation
      ↓
Tests
      ↓
Verification
      ↓
Documentation
```

Si durante el desarrollo aparece una nueva necesidad o cambia un requisito, primero deberá actualizarse la Specification y posteriormente ajustarse la arquitectura, el plan, las tareas y la implementación cuando corresponda.

La Specification, la arquitectura, el código y las pruebas deben permanecer alineados para evitar **Spec Drift**.

## Herramientas

El experimento evaluará herramientas y agentes de desarrollo asistido por IA dentro del workflow, incluyendo:

* GitHub Spec Kit
* Traycer
* Codex
* GitHub Copilot
* Otros agentes o herramientas que resulten relevantes durante el experimento

## Stack tecnológico

El proyecto utiliza un stack mínimo basado en tecnologías del ecosistema .NET:

* C#
* .NET
* ASP.NET Core
* Blazor
* Entity Framework Core
* SQLite
* xUnit

La arquitectura y las dependencias se mantendrán deliberadamente simples. No se introducirán tecnologías, patrones o componentes adicionales sin una necesidad real y justificada.

## Principios

DevVault seguirá principalmente estos principios:

* La Specification es la fuente de verdad.
* La arquitectura debe mantenerse alineada con la Specification.
* Clean Architecture y SOLID se aplicarán de forma pragmática.
* Los agentes no deben inventar requisitos.
* Las pruebas deben validar comportamiento real.
* Las decisiones arquitectónicas deben ser explícitas.
* Se debe evitar el overengineering.
* No se introducirán soluciones temporales, hacks ni deuda técnica deliberada.
* Los cambios deben ser pequeños, coherentes y verificables.

## Duración

DevVault está planteado como un experimento de **cinco días**.

Al finalizar se evaluará no solamente el resultado del software construido, sino también el propio proceso: qué funcionó, qué falló, qué herramientas aportaron valor y qué modificaciones deberían realizarse para mejorar el workflow AI-Native.

---

> DevVault no busca demostrar que una IA puede escribir código.
>
> Busca determinar **qué workflow permite utilizar agentes de IA para desarrollar software de forma controlada, verificable y arquitectónicamente coherente**.
