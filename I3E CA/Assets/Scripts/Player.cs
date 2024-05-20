using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Collectible collectible;

    public void UpdateCollectible(Collectible newCollectible)
    {
        collectible = newCollectible;
    }

    void OnInteract()
    {
        if (collectible != null)
        {
            collectible.Collected(this);
            collectible = null;
        }
    }
}
