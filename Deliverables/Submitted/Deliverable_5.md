# Description
Within our system, we have our game hosted on the Unity engine which allows players to survive waves of enemies in a tower defense game for as long as possible while increasing their scores to be uploaded.
Additionally, we have a remote database used for saving, storing, and displaying the high scores that players receive while playing the game.
Finally, all of these elements will be accessed through the website where users can view the leaderboard and play the game.

# Architecture
![image](https://github.com/NoomMiner/Ducks-Bath-Defense/assets/145489308/e8e0d992-814f-4f5f-86b9-227fa1f920a7)

Within the diagram, the layers within our system can be seen. To begin, we have the layers of our Home page, game page, and leaderboard page which holds important info within.
The user initially accesses the home page (entering the page's URL) and can navigate to any of the other pages to either view the leaderboard, access the game, or simply move between.
<br>
<br>
After which, we have the game which house many different qualities that contribute to the overall gameplay. 
This layer connects to the game manager which deals in the backend work that supports the games function.
This can be seen as managing the waves, the current gamemode, determining when the end condition was met, score submission, etc.
As the game layer is dependent on the manager, the two are linked together.
<br>
<br>
Returning to the database, we can see that the data is stored within pertaining to highscores.
The user is able to access the page to view the leaderboard via the webpage to see what kind of information related to gamescores they wish to view.
Lastly, this section is required to be tied to the game manager as the game manager is what submits the score from the game directly to the database to be stored.

# Class Diagram

# Sequence Diagram

# Design Patterns

# Design Principles
