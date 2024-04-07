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
Website Diagram:
<br>
![image](https://github.com/NoomMiner/Ducks-Bath-Defense/blob/D5/Deliverables/Submitted/websiteClassDiagram.png)
<br>
<br>
This is the class diagram for the website. The website is simple, just hosting the leaderboard visual, homepage, and page that loads the game builds. Also has supporting functions for both the game and web pages hosted on the server itself. The folder holds the build for the game build generated from Unity which are loaded onto the websiteGamePage.

# Sequence Diagram
Website sequence diagram: 
<br>
![image](https://github.com/NoomMiner/Ducks-Bath-Defense/blob/D5/Deliverables/Submitted/websiteSequence.png)
<br>
<br>
This sequence diagram represents the use case of the game being available on the website. It shows how the website functions on the website, navigating between pages as well as loading the page contents.

# Design Patterns
Creational Design Pattern: Object Pool
<br>
By Hunter Kilgore

![image](https://github.com/NoomMiner/Ducks-Bath-Defense/assets/145489308/278f6d70-24d3-4d89-88b2-da769f3c2487)


# Design Principles
S - Single-responsiblity Principle  
An example of this principle is with the "game manager". This is an entity that handles the score, currency, etc. so that the game entities (towers and enemies) are not affecting it directly. The enemies, for example, don't increase the score themselves when they die - this is done by the game manager class.

O - Open-closed Principle  
The "drain", the tower that ends the game when it dies, is a subclass of "tower". This way, we don't need to have methods that could end the game in the normal "tower" class, so we can avoid bugs.

L - Liskov Substitution Principle  
- should be able to replace an instance of a class with an instance of one of its subclasses without breaking everything (i.e. return values should have the same data type, functions should have the same parameters, even if they do and return different things.)

I - Interface Segregation Principle  
Enemies and towers share a lot of the same features, but they have some different capabilities (such as enemies moving, or towers being placed in a specific spot). To avoid having entities with methods they wouldn't use, the towers and enemies are both subclasses of "entity" - the methods they share are implemented in the "entity" class, and their specific methods are implemented in the subclasses.

D - Dependency Inversion Principle  
- entities depend on abstractions, not concretions.
- idk if we have anything this applies to?
