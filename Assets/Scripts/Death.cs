using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject pinball;



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Pinball Prefab")
        {
            LiveCounter.lives--;
            pinball.transform.position= new Vector3(0.01f, 0.67f, 0.976f);
        }
    }
}
