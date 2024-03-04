# System Description
The game keeps track of the **player** as they play. The **player** has a score, which measures their overall success in their current game, and is used when they **_create_** a **leaderboard entry**.
They also have _money_, which is spent to **_manage_** their **towers**. The game also keeps track of what wave they have reached, as well as the current _game mode_ they are playing.
<br>
<br>
The action of the game is mainly carried out by **entities**. All **entities** in the game must have a _name_, as well as _health_ and _maximum health_.
They also deal a certain amount of _damage_ within a certain _range_ on an interval determined by a _cooldown_.
They also have a certain attack _type_ that determines what kind of attacks they carry out, such as attacking a single target or affecting a large area.
**Entities** only _target certain types_ of **entities**, either **towers** or **enemies**.
<br>
<br>
**Towers** are a certain type of **entity** that the **player** can **_buy_** from the **shop** for a certain _cost_, which can then be **_placed_** on the **game grid** to **_attack_ enemies**.
The **game grid** contains information about the _enemies’_ path and _where towers can be placed_ to ensure that the **player** can only perform valid actions.
To **_place_** their **towers**, the **player** needs to **_access_** their **inventory**, which shows the _**towers** they have bought_.
The **inventory** also has a certain _capacity_ to avoid spam.
For another _cost_, the **player** can **_upgrade_** a **tower** that has already been placed on the map, progressing its _level_ up to a certain _maximum_, making it more powerful.
The game starts with a main **tower** already placed in the map, which the player must defend from the **enemies**, or else they lose the game.
<br>
<br>
**Enemies** are another type of **entity** in the game, which **_attack_** the **towers**.
**Enemies** move on a set path at a certain _speed_, and are **generated** in waves by the game’s **wave controller**.
The **wave controller** keeps track of the _current wave number_, and should be **_connected_** to the **player** for scoring purposes.
The **wave controller** also keeps track of _how many **enemies** are left_ in the current wave, and also _which **enemies** appear_ in the current wave.
<br>
<br>
The **home page** allows **_access_** to the **game** and the **leaderboard** through a series of _linked buttons_.
Each **page** allows the **user** to **_view_** the _content_ within the pages as well as the ability to **_access_** any other part of the **website** they’re currently not in via the _linked buttons_.
<br>
<br>
When the **player** **_loses_** the **game**, they are prompted to **_enter_** a name so their _score_ can be stored on the **leaderboard**.
The **leaderboard** will store the **user's** _name, score, wave reached, game mode_, and the _date_ this **game** was played with a specific _entry id_.
If the **score** is high enough, it will be added to the **all-time high score table**.
<br>
<br>
When the **user** **_navigates_** to the **leaderboard page** of the **website**, the **leaderboard page _gets_** the **leaderboard data** and **_displays_** the top _scores_ for the week and for all-time.
<br>
<br>
# System Model
![classDiagram drawio](https://github.com/NoomMiner/Ducks-Bath-Defense/assets/145489308/c19440cf-5c8d-4257-8504-fd82fcb93e75)

