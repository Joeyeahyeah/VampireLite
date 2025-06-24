# VampireTutorial 
原作者是bilibiliUP@NeoWeng1214，跟着教程制作

**Unity 2D吸血鬼角色基础控制原型**
当前为早期开发版本，仅包含基础玩家移动和简单攻击动画。

## 🔨 当前已实现功能
- 🕹️ 基础2D玩家移动（WASD上下左右移动）

- 👊 简单攻击动画触发

- 🦇 敌人随机生成并追踪玩家

- 🎞️ 基础动画状态机（Idle/Run/Attack）

- 🖼️ 临时美术资源占位


## 🚧 计划中功能（未实现）
| 功能 | 状态 |
|------|------|
| 吸血机制 | ❌ 未开发 |
| 得分系统 | ❌ 未开发 |
| 关卡设置 | ❌ 未开发 |
| 经验等级 | ❌ 未开发 |


## 🛠️ 项目结构

```bash
Assets
├── 2D Zombie
├── 2D_Background_SunshineForest
├── Casual Game Sounds U6
├── Dragon Warrior Files
├── Fantasy Wooden GUI  Free
├── MusicTracks
├── Plugins
├── Prefabs
├── Resources
├── Scenes
├── Scripts
│   ├── Attack.cs
│   ├── AudioSFX.cs
│   ├── Damageable.cs
│   ├── Death.cs
│   ├── EnemyAnimationController.cs
│   ├── EnemyMovement.cs
│   ├── GameOver.cs
│   ├── Health.cs
│   ├── MagicMissile.cs
│   ├── MagicMissileMovement.cs
│   ├── MissileCreator.cs
│   ├── Player.controller
│   ├── PlayerAnimationController.cs
│   ├── PlayerHealthUI.cs
│   ├── PlayerManager.cs
│   ├── PlayerMovement.cs
│   ├── SelfDestroy.cs
│   ├── TimeManager.cs
│   ├── attack.anim
│   ├── idle.anim
│   └── walk.anim
├── Settings
├── SmartTimersManager
├── SpawnMega
├── TextMesh Pro
├── UniversalRenderPipelineGlobalSettings.asset
└── player.inputactions
```

## 💻 如何测试
1. 使用Unity 2022.3+打开项目

2. 运行`Scenes/SampleScene.unity`

3. 控制方式：
   - WASD 移动

## ❓ 已知问题
⚠️ 玩家角色和敌人移动均没有边界碰撞检测

⚠️ 所有美术资源为临时占位


## 🌱 后续计划
1. 优先实现攻击命中检测

2. 添加简单敌人原型

3. 替换正式美术资源


## 📮 参与贡献
欢迎提交Issue或Fork开发，当前维护者：@Joeyeahyeah