# 02-update-packages: Update Packages

Update NuGet package references to versions compatible with net10.0. Replace or remove unsupported packages. Address security vulnerabilities found in the assessment.

Affected items: packages.config or <PackageReference> entries in csproj

Done when: All packages reference net10-compatible versions or alternatives are documented; solution builds without package-related errors.
