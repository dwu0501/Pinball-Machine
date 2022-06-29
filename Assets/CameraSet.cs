using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSet : MonoBehaviour
{
    public float angle;
    bool ActiveCamera = false;
    public Transform rotacion;
    public static string TF;
    void Start()
    {

    }
    void Update()
    {
        transform.RotateAround(rotacion.position, Vector3.up, angle * UnityEngine.Time.deltaTime);
        while(ActiveCamera)
        {
            Flipper.hitStrenght = 20000;
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Pinball Prefab")
        {
            if(ActiveCamera)
            {
                ActiveCamera = false;
                TF = "false";
            }
            else if (!ActiveCamera)
            {
                ActiveCamera = true;
                TF = "true";
            }
        }
    }
}