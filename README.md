## Practical 1.2: Scripting the Controls for a Maze Game

In the last lecture, you learned how to write scripts that manipulate Game Objects and Components in Unity. In this practical, you are going to write a script that controls a rolling ball maze game.

By the end of this practical you will:

-	Be able to create a new C# script and add it to a Game Object
-	Be able to read input data from a keyboard and control pad and use it in a script
-	Be able to manipulate a Game Object’s transform from a script

## Task 1: Download and Run the Base Project

To get started, make a copy of this repository on your GitHub account and clone it onto your local computer. You can do this by:

Clicking the "Use this template" button at the top-right on the page
Following the instructions in the week 1 section of the VLE to clone a repository onto your local computer

The project contains a ready-made scene for a rolling ball maze game, which comprises a textured model of a maze and a physics-enabled ball. The object of the game is to roll the ball into the hole by ‘tilting’ the maze.  

Press the play button to see the game in action. You’ll notice that it’s not possible to play the game yet, because the controls that tilt the maze haven’t been implemented yet. 

## Task 2: Implement the Control Mechanism Using a Script

In this practical, you will write a script that implements the control mechanism for the maze game. As mentioned above, the ball should be moved through the maze by tilting the maze (i.e. rotating it around its x and z axes). The video below demonstrates this form of interaction:

https://www.youtube.com/watch?v=4gN5gCQO_g8

The tilting should be controlled using Horizontal and Vertical axes of the Unity input system, which by default is mapped to the allow keys and, e.g., the analogue stick of a game pad. You should make your script so that movement on the horizontal axis (left / right) controls tilting around the z-axis and movement on the vertical axis (up / down) controls tilting around the x-axis.

To implement this control mechanism you should write a C# script that manipulates the transform of the “Maze” Game Object. This script should have at least one public variable, which limits the amount that the maze can tilt along each axis in degrees (beware, you may introduce an annoying bug if this number is too large).

When implementing your script, you may wish to consult the following pages in the script reference:

-	Input.GetAxis - http://docs.unity3d.com/ScriptReference/Input.GetAxis.html 
-	Quaternion.Euler – http://docs.unity3d.com/ScriptReference/Quaternion.Euler.html

You may also find it useful to consult the following code snippet, which demonstrates how to set the rotation component of a Game Object’s transform in degrees:

```
transform.rotation = Quaternion.Euler(xRotation, yRotation, zRotation);
```

## Task 3: Optional Extensions

If you complete task 2 before the end of the practical, or would like to improve your work in your free study time, then you should consider implementing scripts that add the following extensions to the rolling ball maze game:

-	Restart the level when the ball falls down the hole. See the following link for how to restart the current level: https://gist.github.com/NovaSurfer/e96f3777ca7a4c46f391634ec65dc695
-	Play a sound when the ball is rolling, where the volume of the sound increases with the velocity of the ball. This sound might be a good asset to use, after some quick editing in Audition: https://www.freesound.org/people/scotru/sounds/34732/
- We've used Unity's classic input system in the practical because it's a bit easier to get started with. However, why not try out their new input system, which is a bit more complex but also more powerful: https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/QuickStartGuide.html

