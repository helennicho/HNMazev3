# A Maze Starter Project

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

## Versions
- Unity 2017.13
- GVR Unity SDK v1.70.0

Version 1 : 
Working copy - wchange day of month to diff wall - due to lighting or add spot lighty point all work & main door opening
need to add canvases / signposts for way points/ coins/ temple
need to change blue particles on all colectibles to gold
need to remove old chest on oiutside area
on open temple chest  need particles and change in sound

Version 2 :
above altered
but click on canvas temple not working
also null point error on waypoints
abandon and go back to version1

Version 3:
ammendments on version 1 - had to aboandon version2
redo alterations using prefabs for canvasse designed in version 2


* Audio
* 3D spatial positioning audio placed on Chest inside Temple - plays on awake at start of game - soundtrack barely audible at start of scene bu uncreases as user moves nearer to Temple Chest
* Audio setting set for gvr spatializer and using Oculus to set for 3D sound - logarithmic curve altered in 3D audio source settings positione on audio source on chest game object
* Other sounds such door opening, door closed, waypoints, collecting the key are placed via audio sources directly onto gameobjects and controlled by scripts - audio sounds set as public vars so can easily be changed
* 

Designing & Building the Maze
I decided to build the maze manually rather than using an algorithm to explore to get greater insight into the complexities of maze design. The problem solving challenges enable me to further understand the complexities of creating & using a maze algorithm.
The advantages of a manual design is that the layout and positioning of walls & objects can be better controlled thus allowing the maze design to be more approperiate for the target user type.
Also it means that lights and the maze layout are part of the static design to optimise performance.
I found it a fascinating learning experience though quite time consuming.
I used the complex set of prefabs (as provided) as a block design that I duplicated, re-positioned & rotated to create a grid. Then I deleted blocks to create a route through the maze to the Temple. Finally more blocks were created to create cul-de-sac routes around the maze.
I had to create end pillars as extra blocks to give a finished edge to some walls.
The main problem was it is difficult to get the lines of walls & cross pillars to line up exactly by hand but in the end I thought it gave a more rustic look and I made various "wall repairs" as I went along!
