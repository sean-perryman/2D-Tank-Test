# Unity 2D Tank Test

Just messing around with a 2D tank game in Unity, something I've been wanting to do for a while.

* Unity 5 on PC, scripting in C#
* Using https://github.com/JISyed/Unity-XboxCtrlrInput for XBox 360 controller input
* Left and right triggers for tread control. No backward movement just yet.
* Left and right bumpers to rotate turret
* A-button to shoot
* ~~Still figuring out the tank movement~~, inspiration from here: http://gamedev.stackexchange.com/questions/97765/move-2d-tank-with-independently-controlled-treads
* Emphasizes the fact that I need to learn more advanced math
* Background art: http://opengameart.org/content/tower-defense-grass-background
* Tank Art: http://opengameart.org/content/simple-2d-tank
* Smooth Camera 2D Follow: http://answers.unity3d.com/questions/29183/2d-camera-smooth-follow.html
* Target House: http://opengameart.org/content/drawn-comic-house-144px-square
* Explosion: http://opengameart.org/content/simple-explosion-bleeds-game-art
* Added in some quickly made controls, not functional yet. They also keep disappearing when I destroy things.
---
- [ ] Fix intro and gameover scenes to reflect the state of the game
 - [ ] Implement buttons to start the game, instructions, quit
 - [ ] Implement a scoring system, and have the gameover screen display that
 - [ ] Button on gameover scene to restart game, button to quit
- [x] Collision between bullet and house
- [x] House explodes 
- [x] Fix collider issue with tank and bullet
 * Changed collider on tank to a trigger, added in OnTriggerEnter2D function to House script.
- [ ] Find out why controls disappear when destroying houses with bullets, or crashing tank into house.
- [ ] House turns into pile of rubble?
- [ ] Find a non-Xbox control scheme
- [ ] Backward tank movement
- [ ] Tank tread animation
- [ ] Sounds
- [ ] Opening screen
 - [ ] Start game option
 - [ ] Credits option
 - [ ] Options option?
- [ ] Game-over screen
 - [ ] Restart game option
 - [ ] Quit game option
- [ ] Multiplayer Option
 - [ ] Figure out how start button on XBox controller will instantiate a copy of the tank, and be controlled by that controller only.
 - [ ] Figure out how to potentially do cell phone controller for tanks