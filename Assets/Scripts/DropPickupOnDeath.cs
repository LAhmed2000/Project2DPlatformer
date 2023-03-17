using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When object dies, drop the pickup
/// </summary>
public class DropPickupOnDeath : MonoBehaviour
{
    [Header("Pickup Object Settings")]
    [Tooltip("Place an object to be dropped")]
    public GameObject drop;

    /// <summary>
    /// Descrtiption:
    /// Function is called when object is destroyed
    /// drops item
    /// Input:
    /// None
    /// return:
    /// void (no return)
    void OnDestroy()
    {
        if (drop)
        {
        Instantiate(drop, transform.position, drop.transform.rotation);
        }
    }
}
