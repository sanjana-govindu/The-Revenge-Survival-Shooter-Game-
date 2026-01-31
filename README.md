# The Revenge - First-Person Shooter Game

A Unity-based first-person shooter game where players must survive waves of enemies by shooting them before they get too close.

## Game Overview

**The Revenge** is an immersive action-packed first-person shooter game built with Unity and C#. Set in a vast 3D terrain environment, players find themselves in a hostile territory where survival depends on quick reflexes and accurate shooting.

### Story & Setting
You are a lone survivor in enemy territory. Armed with a single weapon, you must eliminate hostile forces before they overwhelm you. The enemies are relentless and will hunt you down once they detect your presence. Your mission: eliminate enough enemies to prove your dominance and escape with your life.

### Core Experience
- **Intense Combat**: Face off against AI-controlled enemies that actively hunt you down
- **Strategic Gameplay**: Balance between aggressive hunting and defensive positioning
- **Progressive Challenge**: As you eliminate enemies, maintaining awareness becomes crucial
- **Immersive Environment**: Explore a detailed 3D terrain with realistic gun mechanics
- **Audio-Visual Feedback**: Experience satisfying gunfire sounds, animations, and particle effects
- **Score-Based Progression**: Track your performance with a real-time scoring system

### What Makes It Unique
- **Intelligent Enemy AI**: Enemies don't just stand still - they patrol the terrain and actively pursue you when detected
- **Proximity-Based Danger**: The closer enemies get, the higher the stakes
- **Instant Consequence**: One wrong move and it's game over - no health bars, just pure survival
- **Skill-Based Gameplay**: Success depends on accuracy, awareness, and tactical positioning
- **Quick Sessions**: Perfect for short gaming sessions with clear win/lose conditions

### Game Flow
The game creates tension through its simple but effective loop: explore → detect → shoot → survive. Each encounter tests your shooting accuracy and situational awareness. The wandering enemy AI ensures no two playthroughs feel exactly the same, as enemy positions and patrol patterns vary dynamically.

## Gameplay

### Objective
- Shoot enemies to score points
- Survive by keeping enemies at a distance
- Reach 120 points to win the game

### Game Mechanics
1. **Player Spawns** - Start the game with a gun in a 3D terrain environment
2. **Enemy Detection** - Enemies wander the terrain and chase the player when within detection radius
3. **Combat** - Shoot enemies using mouse controls to score points
4. **Scoring** - Each enemy killed awards 5 points
5. **Win Condition** - Reach 120 points to complete the game
6. **Lose Condition** - Game ends if an enemy gets too close to the player

### Controls
- **Mouse Movement** - Look around
- **Left Mouse Button** - Shoot
- **WASD/Arrow Keys** - Move around the terrain

## Technical Details

### Built With
- **Engine**: Unity
- **Language**: C#
- **Assets**: Custom terrain assets and 3D models
- **AI**: Unity NavMesh for enemy pathfinding

### Code Structure

#### 1. `guncontrol.cs`
Handles all gun-related functionality:
- Gun animation control
- Shooting mechanics using raycasting
- Audio playback for gunfire
- Particle effects for muzzle flash
- Score tracking and win condition (120 points)
- Enemy hit detection and destruction

#### 2. `npccontrol.cs`
Controls enemy wandering behavior:
- Random movement within defined radius using NavMesh
- Timer-based position updates
- Terrain-aware pathfinding
- Configurable wander radius and timer

#### 3. `enemycontrol.cs`
Manages enemy AI and player interaction:
- Player detection within configurable radius (default: 10 units)
- Chase behavior when player is detected
- Collision detection with player
- Game over trigger on player contact
- Visual debugging with Gizmos

## System Requirements

### Minimum Requirements
- **CPU**: Intel Core i3 (6th generation) or equivalent
- **RAM**: 6 GB
- **GPU**: Intel HD 520 or equivalent

### Recommended Requirements
- **CPU**: Intel Core i5 (6th generation) or better
- **RAM**: 12 GB
- **GPU**: Dedicated graphics card with 2GB VRAM

### Tested Configuration
- **CPU**: Intel Core i3 (6th generation)
- **RAM**: 12 GB
- **GPU**: Intel HD 520

## Installation & Running

### Prerequisites
- Windows operating system
- UnityCrashReport.exe (included in game files)

### How to Run
1. Download the game executable
2. Ensure UnityCrashReport.exe is in the same directory
3. Double-click the executable to launch the game
4. Use mouse and keyboard to play

## Development

### Project Structure
```
the_revenge-master/
├── Code/
│   ├── guncontrol.cs       # Gun mechanics and scoring
│   ├── npccontrol.cs        # Enemy wandering AI
│   └── enemycontrol.cs      # Enemy chase and attack AI
├── GamePlay.txt             # Gameplay documentation
├── README.md                # This file
└── .gitignore              # Git ignore rules
```

### Key Features
- **Raycast-based shooting** - Accurate hit detection
- **NavMesh AI** - Intelligent enemy pathfinding
- **Dynamic scoring** - Real-time score updates
- **Audio-visual feedback** - Gun sounds and particle effects
- **Configurable difficulty** - Adjustable enemy detection radius and wander behavior

## Game Design

### Enemy AI Behavior
- **Wander State**: Enemies randomly patrol the terrain
- **Chase State**: When player enters detection radius (10 units), enemies pursue
- **Attack State**: Game ends when enemy collides with player

### Scoring System
- **Points per kill**: 5 points
- **Win threshold**: 120 points (24 enemies)
- **Score display**: Real-time on-screen counter

## Target Audience
- Children and youth interested in action games
- Casual gamers looking for quick FPS gameplay
- Players who enjoy survival-style shooting games

## Known Limitations
- Single-player only
- Fixed terrain layout
- No difficulty settings in-game
- No save/load functionality

## In-Game Screenshots 

<img width="1366" height="768" alt="Screenshot (19)" src="https://github.com/user-attachments/assets/ef675955-272b-4586-877f-ce170e1fe843" />

<img width="1366" height="768" alt="Screenshot (14)" src="https://github.com/user-attachments/assets/35024e65-aea4-4584-a329-9941c9677308" />

<img width="1366" height="768" alt="Screenshot (16)" src="https://github.com/user-attachments/assets/60b0a375-6ead-413e-8168-0c9c5042c224" />

<img width="1366" height="768" alt="Screenshot (18)" src="https://github.com/user-attachments/assets/39bb290f-96ca-4bdd-bfd8-e3c734011a0b" />

## Technologies & Resources
- **Game Engine**: Unity 3D
- **Programming Language**: C#
- **Assets**: Unity Asset Store
- **Learning Resources**: 
  - [Unity Official Website](https://unity.com/)
  - [Unity 3D Documentation](https://unity3d.com/unity)
  - [Unity Learn Platform](https://unity3d.com/learn)
  - [Unity Asset Store](https://assetstore.unity.com/)
  - [Stack Overflow Community](https://stackoverflow.com/)
