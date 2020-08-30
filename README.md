# netcoreapi-djangoex
Expose some WebAPI from my django-minisite application

## Deploy django.minisite.existingDB project

1. Set 2 env variables in heroku dashboard

```
PROJECT_FILE=django.minisite.existingDB/djangoMinisiteExistingDB.csproj
DATABASE_URL=Host=x;Database=x;Username=x;Password=x;Sslmode=Require;Trust Server Certificate=true
```

2. To import schema from PostgreSQL DB on heroku, use:

```
dotnet ef dbcontext scaffold "Host=ex;Database=x;Username=x;Password=x;Sslmode=Require;Trust Server Certificate=true" Npgsql.EntityFrameworkCore.PostgreSQL
```

## Deploy SelfMadeDB project

Do migrations locally, always adding and removing manually:

```shell
, 
  "ConnectionStrings": {
    "SelfMadeDBContext": "Host=xxxx;"
  }
```