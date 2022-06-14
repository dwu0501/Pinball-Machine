using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collsion : MonoBehaviour
{
    public GameObject coin;
  
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Pinball Prefab")
        {
            CoinCounter.countercoin++;
            Destroy(coin);
        }
    }
}
