using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2Behavior : MonoBehaviour
{
    public GameBehavior gameManager;
    public float JumpMultiplier = 2f;
    public float JumpSeconds = 10.0f;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("You just got a jump boost!");

            PlayerBehavior Player = collision.gameObject.GetComponent<PlayerBehavior>();
            Player.JumpSpeed(JumpMultiplier, JumpSeconds);
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