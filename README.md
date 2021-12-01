# Unity week 5: Two-dimensional scene-building and path-finding

A project with step-by-step scenes illustrating how to construct a 2D scene using tilemaps,
and how to do path-finding using the BFS algorithm.

Text explanations are available 
# HwTileMap .
[Visit us on itch.io](https://victoku1.itch.io/hwtilemap)


![](https://github.com/VictoKuGame/05-tilemap-pathfinding/blob/master/Media/1.png)
![](https://github.com/VictoKuGame/05-tilemap-pathfinding/blob/master/Media/GifMaker_20211129230337802.gif)

Use A,D to move , SPACE to jump.

Was made as one a weekly task in a unity game development course.

By VictoKu1 .

למטלה השבועית השינויים שבוצעו הם עבור :




סעיף ד' :

השינוי שבוצע הוא שינוי בוקטור לתלת מימדי כך שיחזיק פרמטר נוסף עבור סוג האריח הנוסף, כמו כן נוספה פונקציה שמשנה בכל סביבה את האריח לאריח הפופולרי ביותר.
##### [Tilemap Cave Generator Script .](https://github.com/VictoKuGame/05-tilemap-pathfinding/blob/master/Assets/Scripts/4-generation/TilemapCaveGenerator.cs)
##### [Cave Generator Script.](https://github.com/VictoKuGame/05-tilemap-pathfinding/blob/master/Assets/Scripts/4-generation/CaveGenerator.cs)

סעיף ה' :

כאשר נלחץ על X בסביבה של  הר עם לחיצה על מקח הכיוון הרלווונטי, נוכל לחצוב בהר .
##### [Keyboard Mover By Tile Script](https://github.com/VictoKuGame/05-tilemap-pathfinding/blob/master/Assets/Scripts/2-player/KeyboardMoverByTile.cs)

## Credits

Graphics:
* [Ultima 4 Graphics](https://github.com/jahshuwaa/u4graphics) by Joshua Steele.

Online course:
* [Unity 2D](https://www.udemy.com/course/unitycourse/learn/lecture/10246496), a Udemy course by Gamedev.tv.
* [Unity RPG](https://www.gamedev.tv/p/unity-rpg/?product_id=1503859&coupon_code=JOINUS).

Procedural generation:
* [Habrador - Unity Programming Patterns](https://github.com/Habrador/Unity-Programming-Patterns#7-double-buffer)

Programming:
* Erel Segal-Halevi
