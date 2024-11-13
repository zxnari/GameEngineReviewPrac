# GameEngineReviewPrac

**Contributions:**

Ethan Mesina - 50%

Andrew Oster - 50%

**Why we Weren't Able to Finish in Class:** 

We weren't able to finish the project during the allocated class time; there were multiple reasons we were unable to do this. Time issues, gaps in knowledge, technology issues, etc. are some of the issues that we encountered. Despite being given around an hour to complete this, that seemed like too little of time for us to complete it. There were gaps in our knowledge so researching how to complete some of the deliverables took up most of our in class time. We also had some technology issues at the start, one of our laptops had issues with GitHub and putting the project into the repository. Another issue that took up a bit of time was traversing through GitHub desktop and the Repository in the browser verison of GitHub. All of these issues just took too much time for us to work through and solve, resulting in us not being able to finish within the hour given in class, however we had no problem in finishing outside of class.



**Solution: Walk Through Walls Functionality / Invincibility**

The solution that we implemented for the DLL part of this project is a plugin that, when used, allows the player to move through colliders. The player can activate this by pressing "Q" on their keyboard and they can deactivate this by pressing "E" on their keyboard. This was achieved by creating a DLL in visual studio that references Unity's DLL then has a variable for a GameObject (in the start function this gets set to a GameObject with the name of "Player") and a boolean for tracking the state. This DLL has two main methods, one for setting and another for getting the boolean. In the update method of the DLL, it checks the state of the boolean and if it's true it disables the player's collision and if it's false it enables the player's collision. This solution acts as a mod or cheatcode for the game that allows the player to bypass obstacles and enemies once injected.


**Diagram:**
DLL (Get/SetInvinc) -> Unity2D -> Player

![alt text](https://github.com/zxnari/GameEngineReviewPrac/blob/main/DLLSolutionDiagram.png)


**Solution: Singleton - AudioManager**

The solution that we implemented for the Design Pattern component of this project is a AudioManager Singleton that manages the SFX that can be called in the game world. It ensures that SFX played is done through an AudioSource, otherwise returns null and a debug.log is thrown. This can be used to play sounds from any script or class, in this case, the Invincibility Plugin. In our project, the PlaySFX() function from the AudioManager is called to play an SFX whenever the player is given or removed the ability to move through colliders. 

**Diagram:**

![image](https://github.com/user-attachments/assets/71c7a821-06c6-4a51-82fe-ba618f1e8ba5)

