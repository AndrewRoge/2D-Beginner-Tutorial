using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthCollectible : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null && controller.health < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
            //While this isnt working in the game, this should add 1hp to the current and "destroy" the fruit. 
            //There isn't a respawn code here for regenerating fruit, but I'm guessing that will come next in the project. 
        }
    }
}
