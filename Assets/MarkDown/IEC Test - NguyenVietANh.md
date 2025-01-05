
# Advantage: 
- The project using Strategy Pattern to Implement different type of ```Item : NormalItem, BonusItem , LevelCondition : LevelMoves, LevelTime ``` to deploy feature in the game => this will be easy to expand and adding new feature to project
-  Separate between Cell object to handle physics, Item object to handle movement and image Sprite representation => better at maintain and upgrade project
- Not using MonoBehaviour class in Item
- Does not violate the Law of Demeter
- 

# Disadvante:
 - The initial project was not optimized 
-  There are some circular dependencies between classes ( ```Cell ,Item ; GameManager ,BoardController ``` ) =>hard to reuse in other project
- Using Resource.Load reduces RAM by not referencing prefabs but also makes it difficult to trace bugs from gameObjects 
- 
# Suggestion :
 - Using ECS systems like Entitas or Unity ECS, Sprite Atlas, Object Pooling System for better performance
-  Using Observer Pattern in coding for Low Coupling ,reusability  and avoid circular dependencies (Signal, Action )
-  Some code can be group all line of code of related aspect in 1 Method for high cohesion
- There should be a ```GameManager ,GameSettings`...classes `` Singleton for easier to management 
- ```BoardController``` should act on its own , control Board and Cell while ```GameManager ``` only manages the state of the game

