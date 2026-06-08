# 🚀 Getting Started with VibeArena

## Prerequisites

- .NET 8.0 SDK
- Docker & Docker Compose
- Visual Studio 2022 / VS Code
- Git
- SQL Server (or use Docker)

## Quick Setup (Docker)

### 1. Clone Repository
```bash
git clone https://github.com/NguyenDucPhuc2003/VibeArena.git
cd VibeArena
```

### 2. Start Services
```bash
docker-compose up -d
```

Chờ tất cả services khởi động (SQL Server, Redis, RabbitMQ)

### 3. Verify Services
```bash
# Check SQL Server
docker exec vibearena_sqlserver sqlcmd -S localhost -U sa -P VibearenaPassword@123 -Q "SELECT 1"

# Check Redis
docker exec vibearena_redis redis-cli -a vibearena_redis_password ping

# Check RabbitMQ UI
# http://localhost:15672 (admin / admin)
```

### 4. Build Project
```bash
cd src/VibeArena.API
dotnet build
```

### 5. Apply Migrations
```bash
dotnet ef database update
```

### 6. Run API
```bash
dotnet run
```

API chạy tại: `https://localhost:7001`

### 7. Access Swagger UI
```
https://localhost:7001/swagger/index.html
```

---

## Setup Without Docker

### 1. SQL Server Setup
```bash
# Windows: Use LocalDB or installed SQL Server
# Connection string: Server=.;Database=VibeArena;Trusted_Connection=True;
```

### 2. Redis Setup
```bash
# Windows: Download Redis or use WSL2
redis-server
```

### 3. RabbitMQ Setup
```bash
# Windows: Download and install
# Management UI: http://localhost:15672
```

### 4. Update appsettings.json
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=VibeArena;Trusted_Connection=True;TrustServerCertificate=True;"
  },
  "Redis": {
    "ConnectionString": "localhost:6379"
  },
  "RabbitMQ": {
    "Host": "localhost",
    "Port": 5672,
    "Username": "guest",
    "Password": "guest"
  }
}
```

### 5. Run
```bash
dotnet run
```

---

## Project Structure

```
VibeArena/
├── src/
│   ├── VibeArena.API/                 # Entry point
│   ├── VibeArena.Core/                # Domain models
│   ├── VibeArena.Infrastructure/      # Data access, cache, messaging
│   ├── VibeArena.Modules.Events/      # Event management
│   ├── VibeArena.Modules.Tickets/     # Ticket management
│   ├── VibeArena.Modules.Orders/      # Order management
│   ├── VibeArena.Modules.Payments/    # Payment processing
│   ├── VibeArena.Modules.Users/       # User management
│   └── VibeArena.Shared/              # Shared utilities
├── tests/
│   ├── VibeArena.Tests.Unit/
│   └── VibeArena.Tests.Integration/
├── docs/
├── docker-compose.yml
└── README.md
```

---

## Development Workflow

### 1. Create Feature Branch
```bash
git checkout -b feature/my-feature
```

### 2. Make Changes
- Follow coding standards
- Add tests
- Update documentation

### 3. Commit Changes
```bash
git add .
git commit -m "feat: Add my feature"
git push origin feature/my-feature
```

### 4. Create Pull Request
- Go to GitHub
- Create PR from feature branch to main
- Wait for review & tests to pass

### 5. Merge to Main
```bash
git checkout main
git pull origin main
git merge feature/my-feature
```

---

## Common Commands

### Database
```bash
# Create migration
dotnet ef migrations add MigrationName -p src/VibeArena.Infrastructure -s src/VibeArena.API

# Apply migrations
dotnet ef database update -p src/VibeArena.Infrastructure -s src/VibeArena.API

# Remove last migration
dotnet ef migrations remove -p src/VibeArena.Infrastructure -s src/VibeArena.API
```

### Testing
```bash
# Run all tests
dotnet test

# Run specific test
dotnet test --filter "TestName"

# Run with coverage
dotnet test /p:CollectCoverage=true
```

### Docker
```bash
# View logs
docker-compose logs -f

# Stop services
docker-compose down

# Remove volumes
docker-compose down -v

# Rebuild
docker-compose build --no-cache
```

---

## Troubleshooting

### SQL Server Connection Error
```
Error: Cannot connect to SQL Server

Solution:
1. Check if Docker container is running: docker-compose ps
2. Check connection string in appsettings.json
3. Wait for SQL Server to initialize (first start takes time)
```

### Redis Connection Error
```
Error: Connection to Redis failed

Solution:
1. Check if Redis container is running
2. Verify password in connection string
3. Test: redis-cli -a vibearena_redis_password ping
```

### RabbitMQ Connection Error
```
Error: Failed to connect to RabbitMQ

Solution:
1. Check if RabbitMQ container is running
2. Access management UI: http://localhost:15672
3. Default credentials: guest/guest
```

### Migration Error
```
Solution:
1. Delete latest migration: dotnet ef migrations remove
2. Fix code
3. Create new migration
```

---

## Next Steps

1. ✅ Read [README.md](README.md) for project overview
2. ✅ Read [docs/DATABASE_SCHEMA.md](docs/DATABASE_SCHEMA.md) for database details
3. ✅ Read [docs/ARCHITECTURE.md](docs/ARCHITECTURE.md) for architecture
4. ✅ Start with Tuần 1 tasks in GitHub Issues
5. ✅ Create first API endpoint

---

## Support

- 📖 Check [documentation](docs/)
- 🐛 Report issues on GitHub
- 💬 Discussion in GitHub Discussions

---

**Happy coding! 🚀**
