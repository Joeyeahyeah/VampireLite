# VampireLite  
**Original Concept by bilibili UP@NeoWeng1214**  

**Unity 2D VampireLite Character Control Prototype**  
Current version represents early development stage, containing core game mechanics and partial feature implementation.

## 🛠️ Implemented Features
- **Character Control**: 2D player movement (WASD controls)
- **Enemy System**: Randomized enemy spawns with player tracking AI
- **Combat System**: Basic attack mechanics with target acquisition
- **Animation System**: State machine handling idle/walk/attack animations
- **Placeholder Assets**: Temporary visual and audio resources

## 📅 Development Roadmap
| Feature                | Status         |
|-----------------------|----------------|
| Scoring System        | ⌛ Planned     |
| Blood Drain Mechanism | ⌛ Planned     |
| XP/Leveling System    | ⌛ Planned     |
| Character Progression | ⌛ Planned     |
| Additional Content    | ⌛ Planned     |

## 📁 Project Structure
```bash
Assets
├── Art
│   ├── Character
│   │   ├── 2D Zombie
│   │   └── Dragon Warrior Files
│   ├── Scenes
│   │   └── 2D_Background_SunshineForest
│   └── UI
│       └── Fantasy Wooden GUI Free
├── Audio
│   ├── BGM
│   │   └── BBit Music - 062022
│   └── SFX
│       └── Casual Game Sounds U6
├── Plugins
├── Prefabs
├── Resources
│   ├── SmartTimersManager
│   └── SpawnMega
├── Scenes
├── Scripts
│   ├── Animation
│   ├── Audio
│   ├── Character
│   │   └── Movement
│   ├── CombatSystem
│   ├── Core
│   └── UI
├── Settings
│   └── Scenes
└── TextMesh Pro
```

## Testing Instructions
1. Open project in Unity 2022.3 or later
2. Launch `Scenes/SampleScene.unity`
3. Control Scheme:
   - Movement: WASD keys

## Known Issues
1. Missing boundary collision detection for player and enemy movement
2. All visual/audio assets are temporary placeholders

## Next Development Phase
1. Implementation of permanent art and audio assets
2. Enhanced collision detection system
3. Expanded character and enemy variety

## License

This project is licensed under the [MIT License](LICENSE).

## Contribution Guidelines
We welcome issue submissions and development contributions through our forking system. Current maintainer: @Joeyeahyeah  

Key improvements made:
- More professional section headers
- Consistent capitalization
- Better organized feature descriptions
- More formal language throughout
- Cleaner roadmap presentation
- Restructured project directory for clarity
- Standardized status indicators
- Professionalized contribution section