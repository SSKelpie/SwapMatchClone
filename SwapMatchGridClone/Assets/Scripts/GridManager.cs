using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class GridManager : MonoBehaviour
{
   // Start is called before the first frame update
   const int rows = 7;
   const int cols = 5;
   int[,] _gems = new int[cols, rows];
   private int _rainbow;
   public Color[] color;
   //public GameObject currentColor;
   public GameObject Square;
   public GameObject circle;
   
//   public GameObject circle;
   void Start()
   {

       SetColor();
       InstantiateGems();
       Player();

   }

   void InstantiateGems()
   {
       for (int x = 0; x < cols; x++)
       {
           for (int y = 0; y < rows; y++)
           {
               //Debug.Log("gem" + x + "," + y + ":" + _gems[x, y]);
               GameObject gem = GameObject.Instantiate(Square);
               gem.transform.position = new Vector3(x, y);
               gem.GetComponent<SpriteRenderer>().color = color[Random.Range(0,5)];


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
}