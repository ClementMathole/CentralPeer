# CentralPeer: Peer-to-Peer Tutoring System

>**ACTIVE DEVELOPMENT** > **This project is currently incomplete and in the early stages of development. The code and architecture described in this repo are strictly drafts. DO NOT use this code in a production environment or for any real world application at this time.**

## 1. Project Overview
CentralPeer ia a planned localized, web based peer-to-peer marketplace designed specifically for Higher Education students. The goal is to bridge the gap between students struggling with specific modules and verified peers who have successfully completed them.

To ensure a highly targeted, safe, and manageable ecosystem, the initial rollout is strictly for the **Welkom** and **Bloemfontein** CUT campuses. Trust will be enforced programmatically via strict domain-based email verification.

## 2. Tech Stack
This repository is structured as a Monorepo, housing both the client side and the backend API.

### Frontend (`/client`)
* **Framework:** React.js
* **Language:** TypeScript
* **Styling:** Tailwind CSS
* **Real-Time Client:** `@microsoft/signalr`

### Backend (`/CentralPeer.API`)
* **Framework:** C# ASP.NET Core Web API
* **Architecture:** Clean Architecture (Domain, Application, Infrastructure, API)
* **Database:** PostgreSQL
* **ORM:** Entity Framework Core (`Npgsql.EntityFrameworkCore.PostgreSQL`)
* **Real-Time Server:** ASP.NET Core SignalR

README will be updated in time... peace.