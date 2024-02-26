using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item3Behavior : MonoBehaviour
{
    public GameBehavior gameManager;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Med Kit Acquired!");
            gameManager.HP += 1;
        }
        
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Item Collected!");
            gameManager.Items += 1;
        }
    }
    void Start ()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }

}