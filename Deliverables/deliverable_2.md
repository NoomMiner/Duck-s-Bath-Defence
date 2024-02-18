# Deliverable 2
## 1. Positioning

### Problem statement
The problem of heavyweight, complicated computer games affects casual gamers; the impact of which is unnecessary time and money spent just to enjoy a video game.
### Product position statement
For casual gamers who are looking for quick and easy entertainment, Duck's Bath Defense is a tower defense game that is short, simple, and can be played in your browser; unlike Bloons Tower Defense, our product offers variety in gameplay as the player progresses through the game while still keeping it simple.
### Value proposition and customer segment
**Value proposition:** Duck's Bath Defense is a web-based tower defense game that provides casual gamers with a game they can play anytime, anywhere, while still delivering an interesting and compelling gameplay experience.<br>
**Consumer segment:** Casual gamers who want a fun, relaxing, and lightweight gaming experience.
## 2. Stakeholders
**Casual gamers:** They will be the main user base for our product, and we will rely on their feedback to improve our project.<br>
**Mobile game developers:** They have a similar user base to us, so they will serve as both a standard to follow and something we make sure we stand out from.<br>
**Developers:** We will be responsible for delivering content to our user base, who we will keep in contact with to ensure we create a product they want to use.
## 3. Functional requirements

## 4. Non-Functional requirements

## 5. MVP
In order to complete a vision for our minimum viable product, it must be understood that the final product will be split into three separate key areas of requirement. These areas being the game itself, the website it will be hosted on, and finally, the database meant for tracking scores. With this understanding, we can securely state the vision of our MVP.

**The Game** will be created using the Unity game engine. Using this engine, we can test our game's functionality every step of the way, easily collaborate on code using the Git support found within, and work on an engine that allows ease of access from what we need to have for our project. As for the game itself, only the bare essentials are required to complete the requirements of the game. Firstly, we need a single basic enemy type and defense unit type to be able to combat and interact with one another. Afterwards, we need a wave system that ramps the amount of enemies that spawn and allows a brief grace period for purchasing and placing defense units. There needs to be a playable grid that clearly shows where enemies travel through and where placing defense units is allowed. Additionally, there needs to be a way to differentiate enemies and defensive units in an easily identifiable way. The enemies defeated need to generate both currency and score where currency is used to purchase more defensive units and score is used to be stored in the record database. Finally, there needs to be a defending point that the enemies need to attack where the game ends once the defending point is destroyed.

**The Database** is where the scores of players will be saved and displayed. The requirements of this area is not too complicated. In essence, scores from the game need to be sent to the scoreboard where the player can insert a three character "username" to have associated with their score. A basic profanity filtering system will be applied to ensure hateful and inappropriate language is not permitted. After which, it will be displayed for all users of the website.

**The Website** is the place where all elements will be incorporated for player use. Using AWS, the website will be remotely hosted and accessible by anyone with the URL. We can test its' functionality by implementing HTML files as placeholders and experimenting with it to see what works. The elements of the game and database can then be implemented to the website after thorough testing. Additionally, basic UI elements will be added to format visually and allow a window for the Unity game program to be hosted and played from. This allows the playing of the game without requirement of downloading (a major element in our product's uniqueness and ease of access) and the viewing of the leaderboard for scores.

## 6. Use cases
**Use Case 1:** Add score to leaderboard<br>
**Actor:** User<br>
**Trigger:** The user loses the game<br>
**Pre-Condition:** The user has played a full game<br>
**Post-Condition:** A new entry will be added to the leaderboard<br>
**Success Scenario:**

1) The user loses the game
2) The user is prompted for a name to go on the leaderboard
3) The system approves the entered name
4) The system creates a new entry on the leaderboard

**Alternate Scenario:**

3) The system finds that the name is inappropriate or is otherwise invalid
4) The system notifies the user of the requirements for a name
5) The user may try again

**Interface Sketch:**<br>
<img src = "image.png" width = "450" height = "300">

**Use Case 2:** Add weekly modes<br>
**Actor:** Developer<br>
**Trigger:** Developer decides to add new mode<br>
**Pre-Condition:** Previous weekly mode is over<br>
**Post-Condition:** New weekly mode is added<br>
**Success Scenario:** <br>

1) The developer designs the weekly mode.
2) The developer attempts to add it to game.
3) The game validates the mode.
4) Informs developer mode is valid
5) Developer activates mode for week

**Alternate Scenario:**<br>

3) The game does not validate the mode
4) Informs developer that an error occured
5) Ask developer to try again<be>

**Interface Sketch:**<br>
<img src = "UseCase2Sketch.png" width = "450" height = "300">

## 7. User stories

## 8. Issue tracker






