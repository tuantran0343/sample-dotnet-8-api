# sample-dotnet-8-api
Content

Workflow (Định nghĩa YAML)
    ├── Job 1: runs-on: ubuntu-latest (Runner A)
    │   ├── Step 1: Checkout code
    │   ├── Step 2: Build .NET
    │   └── Step 3: Run tests
    │
    ├── Job 2: runs-on: windows-latest (Runner B)
    │   ├── Step 1: Setup Windows env
    │   └── Step 2: Build for Windows
    │
    └── Job 3: runs-on: [self-hosted, gpu] (Runner C)
        └── Step 1: Run ML training