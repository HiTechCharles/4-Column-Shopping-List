# GitHub Release Configuration

This repository is configured to automatically build and publish releases using GitHub Actions.

## How to Create a Release

### Method 1: Using Git Tags (Recommended)

1. **Create and push a version tag:**
   ```bash
   git tag v1.0.0
   git push origin v1.0.0
   ```

2. The GitHub Action will automatically:
   - Build the application for both x86 and x64
   - Package the binaries with dependencies
   - Create a GitHub release with ZIP files
   - Generate release notes

### Method 2: Manual Workflow Trigger

1. Go to the **Actions** tab in your GitHub repository
2. Select **Build and Release** workflow
3. Click **Run workflow**
4. Enter the version number (e.g., `1.0.0`)
5. Click **Run workflow**

## Release Artifacts

Each release creates two ZIP files:

- **4-Column-Shopping-List-x86.zip** - 32-bit version
- **4-Column-Shopping-List-x64.zip** - 64-bit version

Both packages are self-contained and include:
- Main executable (`4-Column Shopping List.exe`)
- All required DLL dependencies
- Configuration files
- README documentation

## Version Numbering

Use semantic versioning: `vMAJOR.MINOR.PATCH`

- **MAJOR**: Breaking changes
- **MINOR**: New features (backward compatible)
- **PATCH**: Bug fixes

Examples: `v1.0.0`, `v1.2.3`, `v2.0.0`

## Requirements for Users

Users need **.NET Framework 4.8.1** installed on their Windows system to run the application.

## Customizing Release Notes

Edit the release notes in `.github/workflows/release.yml` under the "Create Release" step, or manually edit the release after it's created on GitHub.

## Troubleshooting

- **Build fails**: Check that all project files are committed to the repository
- **Missing dependencies**: Ensure all DLLs are copied to the output directory
- **Permission errors**: Verify that GitHub Actions has write permissions in repository settings

## GitHub Repository Settings

Ensure the following settings are enabled:

1. Go to **Settings** → **Actions** → **General**
2. Under "Workflow permissions", select:
   - ✅ **Read and write permissions**
3. Save changes
