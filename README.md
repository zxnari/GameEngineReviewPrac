# GameEngineReviewPrac

Contributions:
Ethan Mesina - 50%
Andrew Oster - 50%

 
Solution: Walk Through Walls Functionality / Invincibility

The solution that we implemented for the DLL part of this project is a plugin that, when used, allows the player to move through colliders. The player can activate this by pressing "Q" on their keyboard and they can deactivate this by pressing "E" on their keyboard. This was achieved by creating a DLL in visual studio that references Unity's DLL then has a variable for a GameObject (in the start function this gets set to a GameObject with the name of "Player") and a boolean for tracking the state. This DLL has two main methods, one for setting and another for getting the boolean. In the update method of the DLL, it checks the state of the boolean and if it's true it disables the player's collision and if it's false it enables the player's collision. This solution acts as a mod or cheatcode for the game that allows the player to bypass obstacles and enemies once injected.


Diagram:
DLL (Get/SetInvinc) -> Unity2D -> Player

![alt text](https://github.com/zxnari/GameEngineReviewPrac/blob/main/DLLSolutionDiagram.png)


Solution: Singleton


Diagram:

