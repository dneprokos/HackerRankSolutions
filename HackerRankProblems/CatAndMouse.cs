namespace HackerRankProblems
{
    public class CatAndMouse
    {
        //Two cats and a mouse are at various positions on a line.
        //You will be given their starting positions.
        //Your task is to determine which cat will reach the mouse first,
        //assuming the mouse does not move and the cats travel at equal speed.
        //If the cats arrive at the same time, the mouse will be allowed to move and
        //it will escape while they fight.
        //You are given queries in the form of , , and representing the respective positions for cats and, and for mouse.Complete the function to return the appropriate answer to each query, which will be printed on a new line.
        //If cat catches the mouse first, print Cat A.
        //If cat catches the mouse first, print Cat B.
        //If both cats reach the mouse at the same time, print Mouse C as the two cats fight and
        //mouse escapes.
        //Example
        //x = 2
        //y = 5
        //z = 4
        //The cats are at positions  (Cat A) and  (Cat B), and the mouse is at position .
        //Cat B, at position  will arrive first since it is only unit away while the other is
        //units away. Return 'Cat B'.

        // Complete the catAndMouse function below.

        /// <summary>
        /// Function returns value of who wins
        /// </summary>
        /// <param name="x">Cat A position</param>
        /// <param name="y">Cat B position</param>
        /// <param name="z">Mouse position</param>
        /// <returns>string: Either 'Cat A', 'Cat B', or 'Mouse C'</returns>
        public static string CatAndMouseResult(int x, int y, int z)
        {
            int catADistanceToMouse = z > x ? z - x : x - z;
            int catBDistanceToMouse = z > y ? z - y : y - z;

            string value;
            if (catADistanceToMouse > catBDistanceToMouse)
                value = "Cat B";
            else if (catADistanceToMouse < catBDistanceToMouse)
                value = "Cat A";
            else value = "Mouse C";

            return value;
        }
    }
}
