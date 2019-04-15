using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class GridManager : MonoBehaviour
{
   // Start is called before the first frame update
   const int rows = 7;
   const int cols = 5;
   int[,] _gems = new int[cols, rows];
   private int _rainbow;
   public Color[] color;
   public List<Tile> gemObjects;
   public GameObject Square;
   public GameObject circle;
   public PlayerMove pm;
   
//   public GameObject circle;
   void Start()
   {
           gemObjects = new List<Tile>();

       SetColor();
       InstantiateGems();
       Player();
       pm = FindObjectOfType<PlayerMove>();
       match();

   }

   void InstantiateGems()
   {
       for (int x = 0; x < cols; x++)
       {
           for (int y = 0; y < rows; y++)
           {
               Tile newtile = new Tile();
               //Debug.Log("gem" + x + "," + y + ":" + _gems[x, y]);
               GameObject gem = GameObject.Instantiate(Square);
               newtile.prettygems = gem;
               gem.transform.position = new Vector3(x, y);
               newtile.location = gem.transform.position;
               gem.GetComponent<SpriteRenderer>().color = color[Random.Range(0,5)];
               gemObjects.Add(newtile);

           }
           
       }
       
       
   }

   void SetColor()
   {
       color[0] = UnityEngine.Color.red;
       color[1] = UnityEngine.Color.yellow;
       color[2] = UnityEngine.Color.blue;
       color[3] = UnityEngine.Color.green;
       color[4] = UnityEngine.Color.magenta;
   }

   void Player()
   {
       GameObject player = GameObject.Instantiate(circle);
       player.transform.position = new Vector3(2, 3);
   }


   public GameObject Check4gameObject(Vector3 nextpos)
   {
       for (int i = 0; i < gemObjects.Count; i++)
       {
           if (nextpos == gemObjects[i].location)
           {
              
               return gemObjects[i].prettygems;
               
           }
           
       }

       return null;
   }
   

   public void switchgem (GameObject switchObjects, Vector3 oldpos, Vector3 newpos)
   {
       switchObjects.transform.position = oldpos;
       pm.transform.position = newpos;
   }
   // newpos = player stuff
   //oldpos = gameObjects

   void match()
   {
       
       for (int x = 0; x < cols; x++)
       {
           for (int y = 0; y < rows; y++)
           {
               if ((Vector2)gemObjects[x].location == new Vector2(x, y))
               {
                   SpriteRenderer checkColor = gemObjects[x].prettygems.GetComponent<SpriteRenderer>();
                   checkColor.color = Color.red;
                   
                   Debug.Log("wtfman");
               }
           }

       }
   }
}

public class Tile
{
    public Vector3 location;
    public GameObject prettygems;
}