using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    const int rows = 7;
    const int cols = 5;
    public int _moves;
    private float Movespeed = 1f;
    private GridManager gm;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GridManager>();
    }



    void Move()
    {
                if (Input.GetKeyDown(KeyCode.A)&& transform.position.x < 5 && transform.position.y < 7)  //Left
                {
                  
                   Vector3 newpos = new Vector3(transform.position.x - Movespeed,transform.position.y);
                   gm.switchgem(gm.Check4gameObject(newpos),transform.position, newpos);
                    _moves++;
                }
                if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 5 && transform.position.y < 7) //Right
                {
                    Vector3 newpos = new Vector3(transform.position.x + Movespeed,transform.position.y);
                    gm.switchgem(gm.Check4gameObject(newpos),transform.position, newpos);
                    _moves++;
                }
                if (Input.GetKeyDown(KeyCode.W) && transform.position.x < 5 && transform.position.y < 7) //Up
                {
                    Vector3 newpos = new Vector3(transform.position.x, transform.position.y + Movespeed);
                    gm.switchgem(gm.Check4gameObject(newpos),transform.position, newpos);
                    _moves++;
                }

                if (Input.GetKeyDown(KeyCode.S) && transform.position.x < 5 && transform.position.y < 7) //Down
                {
                    Vector3 newpos = new Vector3(transform.position.x,transform.position.y - Movespeed);
                    gm.switchgem(gm.Check4gameObject(newpos),transform.position, newpos);
                    _moves++;
                }

    }

    void Counter()
    {
        if (_moves == 6)
        {
            SceneManager.LoadScene("EndScene");
        }
      
    }


   //  Update is called once per frame
    void Update()
    {
        Move();
        Counter();
    }
}
