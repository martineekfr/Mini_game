# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Common Commands

- **Build the project**: `dotnet build Mini game/Mini game.csproj`
- **Run the game**: `dotnet run --project Mini game/Mini game.csproj`
- **Run from the project directory**: 
  ```bash
  cd "Mini game"
  dotnet run
  ```
- **Clean the project**: `dotnet clean Mini game/Mini game.csproj`

## Project Structure

The solution consists of a single .NET 8 console application located in the `Mini game` directory:

- `Mini game.csproj`: Project file targeting .NET 8.0
- `Program.cs`: Entry point that starts the menu system
- `Menu.cs`: Handles user input for the main menu (start game or exit). Note: This class inherits from `Gameplay` to access the `Game()` method, though it could be refactored to use composition.
- `Gameplay.cs`: Displays the game introduction with a typing effect, then generates a random monster (name and HP from predefined lists) and starts combat.
- `Monster Attack.cs`: Defines the `Monsters_Class` with monster properties, attack methods (punch, stone, axe), and the combat loop. Manages player actions and monster counter-attacks.
- `Player.cs`: Defines the `Player` class with health, damage-taking, and healing logic.

## Code Architecture

The game follows a simple linear flow:

1. **Program.Main** calls `Menu.Start()`
2. **Menu.Start** presents a loop for user to start the game or exit
3. When starting the game, it calls `Gameplay.Game()`
4. **Gameplay.Game** displays a narrative introduction with character-by-character delay, then generates a random monster (name from ["Karel", "Kresomira", "Damian", "MJ"] and HP from [150, 200, 250, 300, 500])
5. The monster's `Fight()` method is called, which:
   - Creates a new `Player` instance with 200 HP
   - Enters a combat loop where the player chooses actions:
     - **Punch**: Deals 10 damage to monster (limited to 10 uses)
     - **Stone**: Deals 20 damage to monster (limited to 5 uses)
     - **Axe**: Deals 100 damage to monster (limited to 1 use)
     - **Heal**: Restores HP (limited to 3 uses): if current HP > 130, sets to 200; otherwise increases by 70 (but cannot exceed 200 implicitly)
     - **Flee**: Currently does not end combat (loop continues)
   - After each player action (except flee), the monster counter-attacks with random damage (30-100 HP in steps of 10)
   - Loop ends when either the monster's HP or player's HP reaches zero
   - Outcome is displayed (victory or defeat)

Key characteristics:
- Uses random number generation for monster selection and monster attacks
- Console-based UI with text delays for narrative effect in the introduction
- No external dependencies beyond the .NET SDK
- State is managed within method calls and object instances (no persistence)
- Combat mechanics include usage limits for special attacks and healing

## Development Workflow

Since this is a small application without automated tests, development involves:

1. Making changes to the C# files in the `Mini game` directory
2. Building the project to catch compile errors
3. Running the game manually to test changes
4. Playing through various combat scenarios to verify balance and correctness

Notes:
- The game uses `Console.ReadLine()` for input, so testing requires manual interaction
- Random elements mean multiple playthroughs may be needed to test all monster types and HP values
- Consider adding automated unit tests for core logic (e.g., damage calculations, healing limits, usage limits) in future iterations

## Customizing the Game

To adjust game balance or content, edit the following files:

- **Monster names and HP ranges**: In `Gameplay.cs`, modify the `names` and `Hp` lists (lines 17-23).
- **Player starting HP**: In `Monster Attack.cs`, line 17: `new Player(200)`.
- **Player attack damage**: In `Monster Attack.cs`, methods `pest()` (line 123), `kamen()` (line 128), `sekyra()` (line 133).
- **Player attack usage limits**: In `Monster Attack.cs`, variables `pouziti1` (punch), `pouziti2` (stone), `pouziti3` (axe), `pouziti4` (heal) initialized in `Fight()` method (lines 19-22).
- **Monster attack damage**: In `Player.cs`, line 17: `attack_damage` list (values 30-100 in steps of 10).
- **Healing logic**: In `Player.cs`, `Heal()` method (lines 24-34).
- **Introduction text**: In `Gameplay.cs`, string `Uvodni_text` (lines 8-10).

## Additional Information

- The project requires .NET 8.0 SDK to build and run
- Output is directed to the standard console
- No configuration files or external resources are used