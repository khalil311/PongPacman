using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blocks : MonoBehaviour
{
    public int reward;
    public int health;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {

            health--;

            if (health<=0)
            {
                collision.gameObject.GetComponent<Ball>().IncreaseScore(reward);
                Destroy(gameObject);
            }
        }

    }
}
