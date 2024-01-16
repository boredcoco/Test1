# Test1
This game is made using 2021.3.9 as I do not have the space to download another version of Unity of my laptop

## 3d
The concept of the game revolves around a geometric terrain (500 x 500), with a couple of platforms that the player can jump on and collect "coins". All assets in the 3D game are in black and white. The terrain is painted in black and platforms and enemies are coloured white. The distinction between colours draws attention to platforms and enemies.

### Coins
Coins are translucent circles shown below. Collecting them will increase the score by 1. The coins will disappear after being collected.
<img width="652" alt="Screenshot 2024-01-15 at 23 48 52" src="https://github.com/boredcoco/Test1/assets/75612806/2778fcc4-6e56-4f49-b701-8f160664b6bd">

### Enemy cubes
Enemy cubes are white cubes that move back and forth within a fixed distance, colliding into them will result in the loss of player health. When a player dies, they will be redirected to the main menu directly, where they can choose a game. Generally this game does not end until the player dies, hence there is no way to enter the main menu from here unless the player dies.
<img width="651" alt="Screenshot 2024-01-15 at 23 51 21" src="https://github.com/boredcoco/Test1/assets/75612806/b6bd4adc-33e3-4177-8a92-7b85271a9023">

## 2d
The 2D game uses the asset pack and an additional pixel asset pack (for the player sprite) to create a platformer. Player is redirected to main menu when they die or pass the level.

### Coins
The coins are depicted below and disappear when a player collects them by coming into contact with them, the coins collected increase the player's score.

<img width="626" alt="Screenshot 2024-01-15 at 23 56 15" src="https://github.com/boredcoco/Test1/assets/75612806/b0b5fd5d-48fb-4d29-b02e-9b416f87b07c">

### Spikes
Spikes are stationary obstacles that are permanent, coming into contact with them will cause the player to lose health. When the player has no health left and dies, the pleyr is redirected to the main menu
<img width="677" alt="Screenshot 2024-01-15 at 23 56 04" src="https://github.com/boredcoco/Test1/assets/75612806/68ada3b3-e993-47b7-bd35-91c182bd3407">
