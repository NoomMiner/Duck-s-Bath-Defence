# Description
Within our project, we wanted to appeal to the casual gamer market who are looking for a quick, fun, and easily accesible webpage-based game.
Without the hassle of long downloads or microtransactions, its as simple as entering the website page and playing away!
We achieved this goal by adhering to our value proposition and researching the best features to implement that would best line up with our vision.
<br>
<br>
Gamers can expect to land on our website's homepage with a link to the game and leaderboard. 
The leaderboard is a simple database that shows a user's username, the score they achieved when playing, and the date it was achieved on in order to showcase high scores.
On the game page, the unity game itself is loaded in a window without the requirement of downloading anything or making an account.
The game is a relatively simple and easy to understand bath-themed tower defense game.
Players will be expected to defend their drain in the center of the map from an increasingly harder swarm of enemies coming from both ends of the map.
Defeating enemies with strategically placed towers will generate score and currency.
The currency is spent to purchase more towers and place them on the board from the shop UI which accurately displays price and places towers on the grid board.
Lastly, the score itself is to be submitted to the leaderboard page after the drain is defeated: prompting the user to insert a username.
<br>
<br>
All in all, the game is easy to understand and even easier to play.
The purpose of a simplistic gaming experience without any hassle of downloading long-winded learning curves that are easily accessible has been thoroughly achieved.
Gamers of all skill levels can look forward to having fun in Ducks Bath Defense!
<br>
<br>

# Verification

## Unit Test
For unit testing in our project, we used the Unity Test Framework.
One test we developed using mock objects is one to ensure that the [game manager](/Assets/Scripts/GameManager.cs) is handling the "Drain" tower properly, ending the game and interacting with the Tower class and the game grid appropriately. This ensures that the game is able to end properly, allowing the player to complete a full gameplay loop. This test mocks both the [Tower](/Assets/Scripts/Tower.cs) class and the [PlacementTiles](/Assets/Scripts/PlacementTiles.cs) class to create a fully isolated test environment to verify correct behavior of the game manager. [Link to test here.](/Assets/Tests/DrainTest.cs)<br><br>
**Results of this test, as seen on Unity:**
<br><br>
![Print screen of drain test](./draintest.png)
<br>

## Acceptance Test
For acceptance testing, we used the Automated QA package for Unity. This package allows you to "record" specific interactions in your game and play them back, allowing you to observe the behavior in real time. It also offers a Game Crawler feature, which randomly interacts with objects in the game and checks for errors, which our game uses in addition to set interactions. These recordings are stored in the form of JSON files, and are stored [here](/Assets/Recordings).<br>
This is an example of an acceptance test developed for our project, which ensures that the basic interaction of placing and deleting towers works properly. The test file can be found [here](/Assets/Recordings/PlaceAndDeleteTower.json)<br><br>
**Link to video of test execution:** https://www.youtube.com/watch?v=_8zSfQpurac

# Validation
**Interviewer:** Hunter Kilgore
<br>
<br>
**Individual Interviewed:** Tyler Lucas
<br>
<br>
**Questions Asked:**
<br>
**Q.** *What are your initial thoughts of our webpage?*
<br>
**A.** *I thought the webpage was simplistic but easy to navigate and understand.*
<br>
**Q.** *Do you like being able to view the highscores of other players?*
<br>
**A.** *Yeah, I think it makes the whole thing more connected and competetitive in a fun way.*
<br>
**Q.** *What do you prefer, downloading games or having them remote hosted? Why?*
<br>
**A.** *I'd prefer to not have to download a game if I can help it since I don't have that much disk space.*
<br>
**Q.** *What are your initial thoughts of the game itself?*
<br>
**A.** *I liked the sprite work and the enemies coming from two different dirctions were cool. I wish there was music and sound effects though.*
<br>
**Q.** *Is there any features you wish were included? If so, which features?*
<br>
**A.** *Probably just some sound effects and maybe an attack animation. Extra towers would be cool too.*
<br>
**Q.** *How would you rate your skill in gaming?*
<br>
**A.** *I'd say I'm pretty good at games since I've been playing them for a while.*
<br>
**Q.** *Does the game seem too difficult, easy, or just right for your level of skill?*
<br>
**A.** *It seems a bit too easy for me, but that's fine if its supposed to be laid back.*
<br>
**Q.** *Do you have any closing thoughts or remarks?*
<br>
**A.** *Overall, I thought the bath theme was pretty funny and the enemies attacking towers as well was cool.*
<br>
<br>
**Summary of Interview:** The user thought the game was a bit easy and lacked some sound effects, music, and animation. However, he still enjoyed the experience.
<br>
<br>
**Interviewer:** Daniel Austin
<be>
<br>
**Individual Interviewed:** Alex Mintz
<br>
<br>
**Questions Asked:**
<br>
**Q.** What are your initial thoughts of our webpage?
<br>
**A.** Very simple, but it gets the point across that it is a game.
<br>
**Q.** Do you like being able to view the highscores of other players?
<br>
**A.** Yes, it is very nice, well organized
<br>
**Q.** What do you prefer, downloading games or having them web hosted? Why?
<br>
**A.** I don’t mind either or, just depends on the game itself
<br>
**Q.** What are your initial thoughts of the game itself?
<br>
**A.** Slightly confusing initially, took a bit to figure out what to do, since I thought I should put the towers on the water. Other than that, I enjoy it, it's silly and reminds me of older games.
<br>
**Q.** Is there any features you wish were included? If so, which features?
<br>
**A.** Something that would be nice is instructions on how to play the game whether that be a new text box or maybe a little intro before the game progresses. This could be easily put on the front of the webpage. The other is just the character box since it didn’t work with mobile, but that’s okay. I think another little stylistic edit would be to make the water move instead of the outside area because it made it look like the land was the water and the blue was the trail. Another thing I would add is where you can or can’t place items. It’s hard to tell.
<br>
**Q.** How would you rate your skill in gaming?
<br>
**A.** Within the game, I was a little lost at first, but I think I was able to figure it out and create a defense system. Could be better, but this is just the first time playing it. 
<br>
**Q.** Does the game seem too difficult, easy, or just right for your level of skill?
<br>
**A.** I think this game is right if not a little easy which isn’t bad at all. I’ve played a tower defense game in the past thus why it is a little easy for me. 
<br>
**Q.** Do you have any closing thoughts or remarks?
<br>
**A.** Great game! I loved the little sprites of ducks and frogs fighting each other. Fun to play and it is just a relaxing game. I could see the potential of this game becoming something more. I also love that the ducks move around after they defeat you. 
<br>
<br>
**Summary of Interview:**
It seems that the game itself works fine and is pretty easy, however, it seems there are some glitches on certain platforms such as buttons not being pressed or the keyboard not popping up. It seems to be enjoyable to the user despite these things.

**Interviewer:** Risa Walles
<br>
<br>
**Individual Interviewed:** Samantha Dell
<br>
<br>
**Questions Asked:**
<br>
**Q.** *What are your initial thoughts of our webpage?*
<br>
**A.** It looks like a coolmathgames game. The title and colors make it very nostalgic. It's also very clear what I press to play the game.
<br>
**Q.** *Do you like being able to view the highscores of other players?*
<br>
**A.** It's fun, because I can see who I did better than. (She then started comparing her score to some others on the leaderboard.)
<br>
**Q.** *What do you prefer, downloading games or having them remote hosted? Why?*
<br>
**A.** I see the goodness in both, but hosted games have such a nostalgia to me. They remind me of coolmathgames, and I like them because of that.
<br>
**Q.** *What are your initial thoughts of the game itself?*
<br>
**A.** It's good! Just a classic tower defense game.
<br>
**Q.** *Is there any features you wish were included? If so, which features?*
<br>
**A.** Maybe more different towers that do more different things. Bomb tower maybe, bomb tower would be fun. It would also be cool if there was an animation of the towers shooting things.
<br>
**Q.** *How would you rate your skill in gaming?*
<br>
**A.** I'd give myself about a 6 or 7 out of 10. I'm not great at gaming, but if you give me a minute I can figure it out.
<br>
**Q.** *Does the game seem too difficult, easy, or just right for your level of skill?*
<br>
**A.** It seems a little easy, but I've also played a lot of tower defense games in my day.
<br>
**Q.** *Do you have any closing thoughts or remarks?*
<br>
**A.** I think it's good, I really like the colors. I could see myself just idle gaming this instead of doing my homework.
<br>
<br>
**Summary of Interview:** It took her a bit to figure out how exactly to play the game, since the UI (score and currency) text was quite small when she played due to a bug, and there weren't any attack animations. However, she did enjoy the game once she figured it out, and had fun playing and trying to beat high scores even after we finished the interview.
<br>
