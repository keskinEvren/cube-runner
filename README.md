# 🏃 Cube Runner 2D

[![Unity](https://img.shields.io/badge/Unity-2022.3_LTS-000000?logo=unity&logoColor=white)](https://unity.com/)
[![C#](https://img.shields.io/badge/Language-C%23-239120?logo=c-sharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Genre](https://img.shields.io/badge/Genre-2D_Endless_Runner-blueviolet)](https://itch.io)
[![Play on Itch.io](https://img.shields.io/badge/Play_Live-itch.io-FA5C5C?logo=itchdotio&logoColor=white)](https://evren-keskin.itch.io/cube-runner-2d)

A fast-paced **2D Endless Runner** built with the **Unity Game Engine (2022.3 LTS)** and **C#**. Players dodge procedural obstacles, navigate dynamic speeds, and experience smooth parallax background environments.

🎮 **[Click here to play Cube Runner 2D directly in your browser on itch.io!](https://evren-keskin.itch.io/cube-runner-2d)**

---

## 🎮 Gameplay & Core Features

- 🌄 **Parallax 2D Multi-Layer Background:** Multi-depth scrolling background simulating depth and velocity.
- ⚡ **Procedural Obstacle Spawning:** Randomized obstacle generator creating dynamic difficulty and endless gameplay loops.
- 🎭 **Character Selection:** Multi-character selection system allowing players to choose different cube avatars before starting.
- 💥 **Responsive Physics & Collision Detection:** Smooth jumping, ground checking, and game-over triggers on collision.
- 🎵 **Audio & Sound FX:** Integrated background soundtrack and sound effects for jumps, collisions, and menu interactions.
- ♻️ **Object Recycling / Cleanup:** Auto-destroyer triggers to clean off-screen objects and maintain high frame rates.

---

## 🏗️ Architecture & Scripts

`
Assets/Scripts/
├── playerMovement.cs      # Player physics controller, input handling (jump, movement), ground detection
├── Parallax.cs            # Multi-layer parallax background scrolling logic relative to camera/time
├── spawnObstacle.cs       # Procedural obstacle spawning algorithm with randomized delays and positions
├── Obstacle.cs            # Obstacle behaviors, speeds, and trigger collisions
├── EnemyDestroyer.cs      # Boundary cleanup to optimize memory and object lifecycle
├── Selection.cs           # Character select menu UI and player preference persistence
└── CharacterSpawner.cs    # Spawns chosen avatar into the active gameplay scene
`

---

## 🛠️ How to Open & Run in Unity Editor

### Prerequisites
- [Unity Hub](https://unity.com/download)
- **Unity 2022.3.x LTS** (e.g. 2022.3.32f1)

### Steps:
1. **Clone the repository:**
   `ash
   git clone https://github.com/keskinEvren/cube-runner.git
   `
2. Open **Unity Hub**.
3. Click **Add project from disk** and select the cloned cube-runner directory.
4. Select Unity version **2022.3 LTS**.
5. Once loaded, open Assets/Scenes/ and load the main menu or gameplay scene.
6. Press the **Play (▶️)** button in the Unity Editor toolbar.

---

## 🕹️ Controls

| Action | Keyboard / Input |
| :--- | :--- |
| **Jump** | Spacebar / Up Arrow / W |
| **Restart / Select** | Mouse Click / UI Buttons |

---

## 🎨 Asset Credits & Acknowledgments

- Sprites: [Kenney Shape Characters](https://kenney.nl/)
- Backgrounds: Free 2D Cartoon Parallax Background Assets
- UI / Typography: TextMesh Pro
- Audio: CasualGameSounds & Chosic Audio Library