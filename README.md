# Ball Hero

### Teammates
* Christian Perez @Tsukuyomiiii
* Jonathan Kaneshiro @jkane002
* Marvin Dela Cruz @KipGank
* Sabrina Chen @schen091

## Video Demo Link
https://youtu.be/utbGed9lw78
## Overview
You, the user as a human, are summoned into another dimension where you transform
into a ball, becoming a member of the Bola society. A great catastrophe occurs in which
the evil Angulars rise from the planet’s core and plant obstacles in the Bola society’s
cities. The Angulars envy the balls for their lack of angles and social status. The
Bolations, permanent members of the Bola society, have summoned you, the legendary
ball hero, to save the day as the legends have stated. The Angulars propose that if you
pass through all the obstacles proving your worthiness, then they will return the society
back to normal. If you fail, the Angulars will create a new society where no curves will
ever exist.

## Game Description

__Characters__ ​:
* __Hero__ ​: Spherical ball maneuvering around obstacles using the arrow keys to
    move, spacebar to jump.
* __Villains__ ​: The main villain entities are called the Angulars. The Angulars are any
    type of 3-Dimensional shapes with angles and a huge despise for curves. Some
    shapes can include 3-Dimensional prisms, cubes, staircases, triangles, cylinders,
    and many more.
* __Game Play__ ​: There are five levels and a final “boss” stage that the ball must get through
in order to win the game. The levels become more difficult as the game progresses. <br />

__Level 1__: The first level begins with an introduction to one of the bosses where he traps
the user in between objects from his own world. The player’s goal is to successfully
jump across to the other platform, dodge other cube-shaped creatures, and pass
through the door to go on to level 2. This is the boss’ first test where enemies are not
firing any objects to the player and the player simply has to dodge them.
<img width="767" alt="Screen Shot 2019-06-07 at 6 55 29 PM" src="https://user-images.githubusercontent.com/22971646/59312146-dcc29700-8c60-11e9-8fb1-a38ad94049d3.png">
<br />
__Level 2__: In this level the villains which are the triangles have taken over the park. Some
triangles are stuck in trees trying to kill the player by shooting at them. Others are
patrolling areas to make sure that the player cannot get the key and proceed to the next
level. Finally by the key there are hybrid enemies which both shoot and patrol.
![Screen Shot 2019-06-07 at 6 40 09 PM](https://user-images.githubusercontent.com/22971646/59312148-dfbd8780-8c60-11e9-809a-ad9e6782fb21.png)<br />
__Level 3__: In this level, cubes randomly spawn around the ball as it moves, making it more
difficult to get past the obstacles. Twenty hearts have been dispersed all throughout the
scene. The ball must collect all of the hearts in order to move onto the next level. There
are also a few jewels that the user can pick up, which should give the ball a powerup. 
<img width="455" alt="Screen Shot 2019-06-07 at 6 57 22 PM" src="https://user-images.githubusercontent.com/22971646/59312153-e21fe180-8c60-11e9-8df7-aa6ba5acdc74.png"><br />
__Level 4__: This level consists of 4 sections. In the unity scene, they are labeled as
“beginning room”, “second room”, “third room”, and the rest of the objects in the scene
are outside of those sections. In the first room, you are shown the powerups that you
will be able to pick up and a bridge to start going through the course. When you
approach a certain hitbox, a door opens and you start by dodging projectiles, then
moving through some tubes, and going off of a ramp. Next the character jumps over
some lava as to not die and go up some ramps above lava as well. The last obstacle
requires the player to dodge electricity poles to reach the door that leads to the next
level. 
<img width="503" alt="Screen Shot 2019-06-07 at 6 58 29 PM" src="https://user-images.githubusercontent.com/22971646/59312415-eac4e780-8c61-11e9-81a8-7f9fdac60a80.png">
<br />
__Level 5__: This level consist of three scenes: the entrance to the main stage, the main
stage, and the entrance to the boss fight. The two entrance main purpose was to
transition the theme of the level to what was coming next in the scene. The main stage
has a variety of platforms and dynamic obstacles to give the players an immersive
experience. This level has the most amounts of obstacles and enemies in order to give
the players a difficult, yet enjoyable experience. Checkpoints are provided within the
game so the players do not get too frustrated when they respawn. 
<img width="433" alt="Screen Shot 2019-06-07 at 6 34 19 PM" src="https://user-images.githubusercontent.com/22971646/59312162-f1069400-8c60-11e9-9ffc-ab520105aa19.png">
<img width="544" alt="Screen Shot 2019-06-07 at 6 36 57 PM" src="https://user-images.githubusercontent.com/22971646/59312168-f532b180-8c60-11e9-89fe-f8dbd75db562.png">
<img width="278" alt="Screen Shot 2019-06-07 at 6 41 39 PM" src="https://user-images.githubusercontent.com/22971646/59312175-fa8ffc00-8c60-11e9-889c-76fac36fbd45.png">
<br />


__Level 5-1 (Entrance 1)__ <br />
__Level 5-2 (Main stage)__ <br />


__Level 5-3 (Entrance to boss/Exit)__ <br />
__Boss__: The boss level starts off with the player facing the boss character. Electricity
starts to spawn around the player and the player needs to avoid touching any of the
electricity and avoid touching the boss as well. Upon successfully dodging the boss and
the boss’s projectiles, platforms, a doorway, and arrows appear visible to the player so
that the player can reach the end of the game, which just displays a game completion
screen.

## Implementation (e.g., game engine, scripts, algorithms, tools)

We used Unity 3D to create our game. We also used Blender to create some of our 3D
models, such as our triangle villain. We created each level design ourselves, but we
used assets found online.
In order for our game to run smoothly, we implemented many different scripts in C#.
__Overall Game__:

* __MainMenu.cs__ ​ allows the user to click the play button to start the game and the
    quit button to exit the application. There is also an instructions button which leads
    to another canvas, displaying the background of our game, objective, and user
    controls.
* __SwitchScene.cs__ ​ creates a smooth transition between scenes once the user
    reaches the end of one level and enters the next one.
* __Timer.cs__ ​ keeps track of the time.
* __PlayerManager.cs__ ​ allows the user to pause/resume the game at any time. It
    also keeps track of the score and health of the player. This script was attached to
    a gameobject that had a DontDestroy attribute. This allowed the game object to
    live throughout each scene in the game.
__Ball Movement__:
* __BallMove.cs__ ​ allows the user to move smoothly at a specified speed throughout
the game using WASD or arrow keys.
* __BallJump.cs__ ​ allows the user to jump using the spacebar.
* __ThirdPerson.cs__ ​ is attached to the camera, ensuring that the camera follows the
ball at all times.

We also have scripts specific to each level.

__Level 1__:
* __enemyCube.cs__ ​is attached to the player where if the player touches any enemy
cubes, the player restarts that level
* __Script_leftattack.cs__ ​ and ​ __script_rightattack.cs__ ​ both control the movement of
the enemy cubes as the go left and right across the platform
* __Levitation.cs__ ​allows any object to levitate given a sine wave where the
developer can control the object’s amplitude, frequency, and rotation while
levitating

__Level 2__:
* __EnemyController.cs__ ​is attached to the enemies in level 2. It added player
detection and more precise shooting for the enemies once the player was in
range.
* __rotateObj.cs__ ​is used for the coins to detect when the player picks them up. Also
for how to rotate them in the scene.

__Level 3__:
* __RandomSpawner.cs__ ​ repeatedly spawns cubes around the ball randomly.
* __Destroyer.cs__ ​ destroys the cubes 10 seconds after they are spawned.
* __ScoreManager.cs__ ​ keeps track of the number of hearts collected. It displays a
message in the beginning of the level so the user knows that all twenty hearts must be collected. When all the hearts are collected, another message is
displayed that the user has completed the task and can move onto the next level.

__Level 4__:
* __timeAlive.cs__ ​was for making sure projectiles fired would not stay in the scene for
    longer than a certain amount of time.
* __projectileMovement.cs__ ​was for the projectiles being shot out of the enemies in level 5. It helped control the speed of the projectiles and the firing rate.
* Various animations were made specific to the level such as an elevator
    animation and swinging animation.

__Level 5__:
* __Respawn.cs__ ​Used to respawn the player in various checkpoints depending on
where they are on the map for all the stages. The player will respawn only if they
fall off the map, get hit by an enemy, or a combination of both.
* __ThirdPersonMode.cs__ ​A modified third person controller that enables the player
to move forward with respect to where they are facing, as opposed to the world
view.
* __CamPivoter.cs__ ​A scripts used to complement the ThirdPersonMode.cs script.
This scripts main purpose is to pivot the camera around the the player within a
fixed distance and view clamp.
Boss:
* The boss level used variations of different scripts such as __projectileMovement.cs*__ ​to have slightly different functionalities than the original
scripts.
* Various animations were made that were specific to the boss. A state machine
layout was used to predetermine the animations for the boss character.
* __rotateBoss.cs__
