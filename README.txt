*****
WORD SHOOTER

*****

Optimized for 640 x 480 resolution


GAME PLAN

scene 1:

*objects: 3 cubes, one cursor pointer
- a holder script contains the new game parameter and the color of next scene's background

- on clicking one of the cubes, background for next scene is set via the next scene's camera and next scene is loaded




scene 2:

*objects: one cursor pointer


- spheres are instantiated

- letters are assigned to two spheres random, and one is given the first letter of the qword. the sphere that gets the first letter is picked randomly.


- on clicking the sphere, the letter gets added to the string aword
 

- when the length of aword become equals to qword, game switches to the previous scene.



scene 1:

- if aword and qword are equal, displays "YOU WON!"

- if they aren't, displays "YOU LOST"

- new game starts upon clicking ones of the background selection cubes again



