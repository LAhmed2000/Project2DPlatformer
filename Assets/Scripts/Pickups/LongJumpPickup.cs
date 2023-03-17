using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pickup object that grants a longer jump when picked up
/// </summary>
public class LongJumpPickup : Pickup
{
    [Header("Settings")]
    [Tooltip("Increase jump power when picked up")]
    public int jumpPowerIncrease = 20;

    /// <summary>
    /// Description:
    /// When picked up, increase the player's jump height
    /// Input:
    /// Collider2D collision
    /// Returns:
    /// void (no return)
    /// </summary>
    /// <param name="collision">The collision that touched the pickup</param>
    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.jumpPower += jumpPowerIncrease;
        }
        base.DoOnPickup(collision);
    }

}
