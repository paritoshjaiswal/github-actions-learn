# github-actions-learn

This repository contains a simple .NET sample application along with a GitHub Actions workflow for CI/CD.

## Getting Started

1. **Build locally**
   ```bash
   dotnet build src/SampleApp/SampleApp.csproj
   ```

2. **Run tests**
   ```bash
   dotnet test tests/SampleApp.Tests/SampleApp.Tests.csproj
   ```

3. **See workflow**
   The workflow file is located at `.github/workflows/ci.yml` and runs on `push`/`pull_request` to `main`.

Feel free to modify the sample app and workflow to learn more about GitHub Actions.
