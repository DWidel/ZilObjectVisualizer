# ZilObjectVisualizer
Object Visualizer for Infocom ZIL Files


When I saw that the source code for ZORK was online I was very excited, but it was a little hard to read, so I wrote this to help visualize the objects and rlationships.  It can parse the main ZIL file and load the objects into memory.  This is another late night hack. I had no idea how the parsing worked so I just did something that worked.  Now that I have a better idea how it works, I might have done it completely differently, but it does load most of the games I tried.  

This code is not very good. No comments, error handling, lots of repetition etc.  Sorry, it's VB.Net/Winforms.  I can use other tools, but I can't write an app like this in one night with them.  Ordinarily, I wouldn't post it, but I'm trying to learn github. 


So the idea is you can see an object, in this case a room called "FOREST-2".  Most listboxes and grids can be double clicked on to move to the next room or open the object.
![Alt text](/Zork//ss0.jpg?raw=true "ss0")
In this case I double clicked on TREE, an object in the room.
![Alt text](/Zork/ss1.jpg?raw=true "ss1")
Then I clicked "CLIMBBIT" which opened a reference screen and I can see what things have the CLIMBBIT.
![Alt text](/Zork/ss2.jpg?raw=true "ss2")
