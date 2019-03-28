using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
   // Start is called before the first frame update
   const int rows = 3;
   const int cols = 5;
   int[,] _gems = new int[cols, rows];
   public GameObject _gemprefab;
   void Start()
   {
//
//        _gems[0, 0] = Random.Range(0, 9);
//        _gems[0, 1] = Random.Range(0, 9);
//        _gems[0, 2] = Random.Range(0, 9);
//        _gems[1, 0] = Random.Range(0, 9);
//        _gems[1, 0] = Random.Range(0, 9);
//
//        _gems[0] = 0;
//        _gems[1] = 0;
//        _gems[2] = 0;
//        _gems[3] = 0;
//        _gems[4] = 0;

       for (int x = 0; x < cols; x++)
       {
           for (int y = 0; y < rows; y++)
           {
               int color = Random.Range(0, 9);
              _gems[x, y] = color;
           }
       }





       InstantiateGems();

   }

   void InstantiateGems()
   {
       for (int x = 0; x < cols; x++)
       {
           for (int y = 0; y < rows; y++)
           {
               Debug.Log("gem" + x + "," + y + ":" + _gems[x, y]);
               GameObject gem = GameObject.Instantiate(new GameObject());
               gem.transform.position = new Vector3(x * 3, y * 3);
           }

       }
   }

   // Update is called once per frame
   void Update()
   {

   }
}