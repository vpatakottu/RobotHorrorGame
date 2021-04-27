WELCOME TO 'ROBOT HORROR GAME'

CONTENTS OF THIS FILE
---------------------

 - Introduction to Project
 - Solution
 - About the Video Game
 - How to Use
 - Structure of Game
 - How to Manipulate Sound Conditions

 

Introduction
------------
Does sound play a role in how a player navigates a video game? Does this differ for background sounds or sounds from game objects?
We want to be able to test whether or not gameplay and decision making is affected by sounds within the game. As the Unity Experiements group, it is our job to develop 3D models/games/visuals to test human computer interaction. For our semseter project, we decided to look into video game play and the effect of video game sound on human interaction with robots.



Solution
--------
We used Unity and various audio (prosody, text to speech, background music) to create a video game that can be used to test 
the effect of sound and gestures on decision making in a stressful situation. We focused on implementing background sound and sound that comes from the robot. For the background sound we selected two options: horror music and happy music. Typically with horror games, you find that they are almost always accompanied by daunting music and jump scares. You rarely find a "horror" game that comes with gleeful or jovial sounds. Of course these sounds are open to change as you can manipulate the audio files easily. This will be explained in the 'How to Manipulate Sound Conditions' section. The same applies to the sounds from the robot. We have added prosody and text to speech (using the GCP Text-to-Speech technology). Each of theses sounds can be changed to best fit the current study.


About the Video Game
--------------------
The main plot of this game involves the user getting kidnapped by a "bad" robot (Dave). The user must escape without losing all three of their lives, and there will be a "good" robot (Kyle) helping the user escape along the way. To successfully escape, the user will be presented with five decisions, each timed for eight seconds, and they must pick at least two correct choices. Picking a wrong choice or not picking at all will lead them to getting caught by Dave, which causes them to lose a life. Losing all three lives will result in an automatic failure to escape. During each of these five decision scenes, Kyle will perform a gesture (audio can be played as well) pointing to the choice it suggests. Kyle will always suggest the correct choice, but the user does not know this. It is ultimately up to the user to decide whether to trust Kyle or make their own choice. 

How to Use
-----------
Once you clone this repository, you will have a folder called 'RobotHorrorGame' in your directory. You will then want to open up Unity and 'Open' the folder titled 'RobotHorrorGame'. You should then click the 'Assets' folder and click "Reimport All" to avoid issues with the assets in the game. 

Structure of Video Game
----------------------
Scenes:
 - After opening this project in Unity, there should be 13 scenes under Assets -> Scenes. Each scene represents a choice made by the user; therefore, we have labeled the scenes associated with the bad choices as "Bad[x]" and good choices as "Good[x]". There is also a initial, success, and failure screen. 
 - All scenes (except for the success and failure screens) contain a copy of the decision screens, cabin, and associated assets. 
 - Each bad scene will contain Dave while each good scene will contain Kyle, and we have included the associated gestures for each robot under the Animation folder in Assets -> Animation, and each scene will trigger a different animation for Kyle and Dave. 

Decision Screens:
 - Decisions are displayed using a script called `textOnScreen.cs`, and this script is attached to a `D[x]_TextSpace` object, where the `x` represents which decision (1-5). 
 - As parameters to the script, we must pass in a `Canvas` object (in our case, this is labeled as `D[x]_Canvas`, the character object, and the number of seconds we want the decision screen to display for. 
 - As a result, when the player collides with the `D[x]_TextSpace` object, it will display the associated `D[x]_Canvas` containing the choices.
 - Kyle is also placed within the `D[x]_Canvas` so that it shows up when the user triggers the decision screen. 

Scene Transitions:
 - Scene transitions are taken care of by a script called `Transition.cs`. 
 - Within each decision canvas, there are two buttons each user can click. Both buttons will call the `FadeToLevel()` method within `Transition.cs` when clicked, and the scene level to transition to must be specified within those buttons. You can find scene levels under File -> Build Settings.


How to Manipulate Sound Conditions
----------------------------------
For the background sound manipulation, you must change the sound in the initial scene and then go into each of the 'Bad' scenes ('Bad1', 'Bad2'..) and change the sound for wrong decisions as well. **(maybe we can be a bit more detailed here)**

For the robot sound manipulation, you must change the sound in all of the 'Good' scenes ('Good1', 'Good2'..) where the good robot appears. You must also mute the background sound in the initial scene. **(maybe we can be a bit more detailed here)**





