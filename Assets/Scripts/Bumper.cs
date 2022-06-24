using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float Recoil;

    void OnCollisionEnter(Collision col)
    {
        
            Rigidbody otro = col.rigidbody;
            otro.AddExplosionForce(Recoil, col.contacts[0].point, 5);
        
    }
}
