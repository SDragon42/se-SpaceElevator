# Copilot Instructions for se-SpaceElevator

## Project Overview
- This is a modular C# codebase for Space Engineers scripts, organized by subsystem: Carriage, Station, OPS Center, COMMs Receiver, and Shared logic.
- Each subsystem is in its own folder with a dedicated `.csproj` and related scripts. Shared logic is in `SpaceElevator - Shared/` and is referenced by other modules.
- The main architectural pattern is partial classes and static utility classes for code reuse and separation of concerns.

## Key Components
- `SpaceElevator - Carriage/`, `SpaceElevator - Station/`, `SpaceElevator - OPS Center/`, `SpaceElevator - COMMs Reciever/`: Main script entry points for each elevator subsystem.
- `SpaceElevator - Shared/`: Contains common logic, constants, helpers, and modules used by all subsystems. Example: `Displays.cs` for LCD output, `_CommonMethods.cs` for utilities.
- Communication between subsystems is handled via custom message objects and shared constants.

## Developer Workflows
- **Build**: Use Visual Studio or `mdk` (Malware's Development Kit) to build and deploy scripts to Space Engineers. Each subsystem has its own `.csproj` and `.mdk.ini` for configuration.
- **Debug**: Debugging is typically done in-game via LCD output (see `Displays.cs`). Use `Write2MonospaceDisplay` for consistent output.
- **Testing**: There are no automated tests; test scripts in-game. Use the `Instructions.readme` in each subsystem folder for manual test steps.

## Project-Specific Conventions
- Use static classes for display, communication, and calculation logic.
- All cross-subsystem data structures (e.g., `CarriageStatusMessage`) are defined in Shared.
- LCD output uses custom monospace fonts and formatting for clarity.
- Constants and configuration are centralized in `Constants.cs`, `DisplayConfig.cs`, and `ScriptSettings.cs`.
- File naming: Prefixes like `01-`, `10-` indicate load order or logical grouping.

## Integration & Communication
- Subsystems communicate via shared message objects and constants, not direct references.
- Use the `COMMs/` and `Helpers/` folders in Shared for reusable communication and utility logic.
- External dependencies are limited to Space Engineers and MDK APIs; no NuGet or third-party packages.

## Examples
- To add a new display output, extend `Displays.cs` in Shared and call from the relevant subsystem's main control script.
- To add a new subsystem, create a new folder, copy a `.csproj` and `.mdk.ini`, and reference Shared logic as needed.

## References
- See `README.md` for a high-level project description.
- See `Instructions.readme` in each subsystem for usage and manual test steps.
- Key files: `Displays.cs`, `_CommonMethods.cs`, `Constants.cs`, `ScriptSettings.cs`, `CarriageStatusMessage` (in Shared).
