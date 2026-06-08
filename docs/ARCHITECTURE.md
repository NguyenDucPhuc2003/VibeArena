# 🏗️ Architecture Overview

## Modular Monolith Pattern

VibeArena uses a modular monolith architecture:

```
API Layer (Controllers)
    ↓
Module Layer (Events, Orders, Payments, etc.)
    ↓
Service Layer (Business Logic)
    ↓
Repository Layer (Data Access)
    ↓
Infrastructure (DbContext, Cache, Queue)
    ↓
Core (Entities, Interfaces)
```

## Project Structure

- **VibeArena.Core** - Domain models & interfaces
- **VibeArena.Infrastructure** - Database, cache, messaging
- **VibeArena.API** - Web API entry point
- **VibeArena.Modules.*** - Feature modules
- **VibeArena.Shared** - Shared utilities & exceptions

## Design Patterns

- Repository Pattern
- Service Pattern
- Dependency Injection
- Async/Await
- Event-Driven (RabbitMQ)

## Database

- SQL Server 2022
- Entity Framework Core 8.0
- Optimistic Locking with RowVersion
- Fluent API Configuration

## Caching

- Redis for seat availability
- TTL-based expiration for holds

## Messaging

- RabbitMQ for async order processing
- MassTransit for pub/sub

## Security

- JWT Authentication
- Row-level authorization
- Input validation & sanitization
