WELCOME TO 'ROBOT HORROR GAME'

CONTENTS OF THIS FILE
---------------------

 - Introduction to Project
 - Solution
 - How to Use
 - How to Manipulate Sound Conditions

 

Introduction
------------
Does sound play a role in how a player navigates a video game? Does this differ for background sounds or sounds from game objects?
We want to be able to test whether or not gameplay and decision making is affected by sounds within the game. As the Unity Experiements group, it is our job to develop 3D models/games/visuals to test human computer interaction. For our semseter project, we decided to look into video game play and the effect of video game sound. 



Solution
--------
We used Unity and various audio (prosody, text to speech, background music) to create a video game that can be used to test 
the effect of sound and gestures on decision making in a stressful situation. We focused on implementing background sound and sound that comes from the robot. For the background sound we selected two options: horror music and happy music. Typically with horror games, you find that they are almost always accompanied by daunting music and jump scares. You rarely find a "horror" game that comes with gleeful or jovial sounds. Of course these sounds are open to change as you can manipulate the audio files easily. This will be explained in the 'How to Manipulate Sound Conditions' section. The same applies to the sounds from the robot. We have added prosody and text to speech (using the GCP Text-to-Speech technology). Each of theses sounds can be changed to best fit the current study.



How to Use
-----------
Once you clone this repository, you will have a folder called 'RobotHorrorGame' in your directory. You will then want to open up Unity and 'Open' the folder titled 'RobotHorrorGame'. You should then click the 'Assets' folder and click "Reimport All" to avoid issues with the assets in the game. 


How to Manipulate Sound Conditions
----------------------------------
For the background sound manipulation, you must change the sound in the initial scene and then go into each of the 'Bad' scenes ('Bad1', 'Bad2'..) and change the sound for wrong decisions as well. There is sound that plays while the player navigates through the whole game as well as sound that is triggered when the user makes a wrong decision. There should be an audio gameobject towards the bottom of the heirarchy where you can change this.

For the robot sound manipulation, you must change the sound in all of the 'Good' scenes ('Good1', 'Good2'..) where the good robot appears. You must also mute the background sound in the initial scene. This will only require you to go into the intial scene and mute one audio gameobject. After this, you will have to go into the bad scenes and remove the sound from the bad decisions as well. 

All of these sound mannipulation tips go along with our original design for the game and study to observe the effect of background sound vs sound from the robot. Once you are able to get a hang of navigating the game, you are more than welcome to take the sound manipulation in a different direction.








