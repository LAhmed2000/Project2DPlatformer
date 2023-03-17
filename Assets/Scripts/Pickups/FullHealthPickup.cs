using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class inherits from the Pickup class and will fully heal the player upon being picked up
/// </summary>
public class FullHealthPickup : Pickup
{
 //   public GameObject pickupEffect;

    /// <summary>
    /// Description:
    /// Function that is called upon being picked up
    /// Fully heals the player health back to max
    /// Input:
    /// Collider2D other
    /// Return:
    /// void (no return)
    /// </summary>
    /// <param name="other">The object that picks this up</param>

    /// This function overrides the parent function.
    /// The player health is compared to the player's max health, and refills it if it's less than max.
    /// The parent function is called to destroy the FullHealthPickup object and play the pickup effect

    public override void DoOnPickup(Collider2D other) 
    {
        if (other.tag == "Player" && other.gameObject.GetComponent<Health>()) 
        {
            Health playerHealth = other.gameObject.GetComponent<Health>();
            if (playerHealth.currentHealth < playerHealth.maximumHealth) 
            {
                playerHealth.ReceiveHealing(playerHealth.maximumHealth);
                base.DoOnPickup(other);
            }
        }
    }

    /// The following code is the original version of the FullHealthPickup class:

    /*
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player" && other.gameObject.GetComponent<Health>()) 
        {
            Health playerHealth = other.gameObject.GetComponent<Health>();
            if (playerHealth.currentHealth < playerHealth.maximumHealth) 
            {
                playerHealth.ReceiveHealing(playerHealth.maximumHealth);
            }
            if (pickupEffect)
            {
                Instantiate(pickupEffect, transform.position, Quaternion.identity);
            } 
            Destroy(this.gameObject);
        }
    }
    */
}
