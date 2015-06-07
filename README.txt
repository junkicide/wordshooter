*****
WORD SHOOTER

*****

GAME PLAN

scene 1:

3 cubes with renderers coloured red, blue and green.

clicking on any one saves colour to static variable in bgcolor object

load next scene




scene 2:

3 spheres coloured yellow, 3 text meshes coloured black, 1 pointer object (shooter)

- spheres are initialized

- when one sphere is clicked on, its text mesh is sent to a letter collecting function in wordcontrol, and sphere is destroyed

- new spheres are initialized from the controller object one of which contains correct next letter[not fully implemented]

-cycle continues until all letters of the word are exhausted
 
- at the end of the word, the string obtained in wordcontrol is checked against the question string[not yet implemented], and returns a "well done!" or "oh no, you've got it wrong!"

- checking is done only after all the letters of the word have been played, and not after each letter.





