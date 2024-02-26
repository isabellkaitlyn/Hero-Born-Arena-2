using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public float BoostMultiplier = 2f;
    public float BoostSeconds = 10.0f;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("You now have super speed!");

            PlayerBehavior Player = collision.gameObject.GetComponent<PlayerBehavior>();
            Player.BoostSpeed(BoostMultiplier, BoostSeconds);

            Debug.Log("Item Collected!");
            gameManager.Items += 1;
        }

    }
    public GameBehavior gameManager;
    void Start ()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }
}
