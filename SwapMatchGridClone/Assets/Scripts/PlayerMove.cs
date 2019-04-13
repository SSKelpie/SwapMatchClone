using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    const int rows = 7;
    const int cols = 5;
    public int _moves;
    private float Movespeed = 1f;
    private 
    // Start is called before the first frame update
    void Start()
    {

    }



    void Move()
    {
                if (Input.GetKeyDown(KeyCode.A)) //Left
                {
                    
                    transform.position = new Vector3(transform.position.x - Movespeed,transform.position.y);
                    _moves++;
                }
                if (Input.GetKeyDown(KeyCode.D)) //Right
                {
                    transform.position = new Vector3(transform.position.x + Movespeed,transform.position.y);
                    _moves++;
                }
                if (Input.GetKeyDown(KeyCode.W)) //Up
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + Movespeed);
                    _moves++;
                }

                if (Input.GetKeyDown(KeyCode.S)) //Down
                {
                    transform.position = new Vector3(transform.position.x,transform.position.y - Movespeed);
                    _moves++;
//                    Debug.Log("ahhhh");
//                    Movespeed =  Mathf.Clamp(1, 0, 3);
                }

    }

    void Counter()
    {
        if (_moves == 6)
        {
            SceneManager.LoadScene("EndScene");
        }
      
    }
    void Boundaries()
    {
//        Debug.Log("wtf");
//        if (transform.position.x > 7 || transform.position.x < -7 || transform.position.y > 5 ||
//            transform.position.y < -5)
//        {
//            Movespeed = 0;
//        }
        
    }
    

   



   //  Update is called once per frame
    void Update()
    {
        Move();
        Counter();
        //Boundaries();
    }
}
