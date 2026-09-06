# Plan: Migrate "4-Column Shopping List" solution to .NET 10 (Windows)

## Overview

**Target**: Upgrade all applicable projects in the solution to net10.0 (Windows).
**Scope**: Single-solution WinForms application targeting .NET Framework 4.8.1; convert project file to SDK-style, update packages, and validate runtime UI behavior.

## Tasks

### 01-convert-project
Convert the main project (4-Column Shopping List.csproj) to the SDK-style project format and set TargetFramework to net10.0. Ensure UseWindowsForms is enabled and designer-generated files remain compatible.

Affected items: 4-Column Shopping List.csproj, Form1.cs, Form1.Designer.cs

Done when: Project uses SDK-style csproj with <TargetFramework>net10.0</TargetFramework>, builds without errors, and designer files load in Visual Studio without data loss.

---

### 02-update-packages
Update NuGet package references to versions compatible with net10.0. Replace or remove unsupported packages. Address security vulnerabilities found in the assessment.

Affected items: packages.config or <PackageReference> entries in csproj

Done when: All packages reference net10-compatible versions or alternatives are documented; solution builds without package-related errors.

---

### 03-code-fixes-and-compat
Resolve API and binary compatibility issues identified in the assessment (e.g., System.Drawing adjustments, Win32 interop changes). Apply minimal code changes and document any replacements.

Affected items: source files with incompatible APIs (see assessment.md for locations)

Done when: Code compiles, runtime smoke tests pass, and no API incompatibilities remain.

---

### 04-designer-and-UI-validation
Open the migrated WinForms application in Visual Studio, verify designers load, and perform manual UI smoke tests (creating/editing list items, saving state). Fix any designer or resource issues.

Done when: Designer opens without errors for main forms and basic user scenarios work during manual runs.

---

### 05-integration-build-and-tests
Build the entire solution, run unit tests (if any), and perform a final smoke run of the application.

Done when: Solution builds cleanly and tests (if present) pass.

---

### 06-documentation-and-ci
Update README/CI instructions to require .NET 10 SDK and Windows runner. Record any remaining technical debt in final-report.md.

Done when: README and CI files updated and final-report.md created.



