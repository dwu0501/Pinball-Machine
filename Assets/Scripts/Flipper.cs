using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{

    public float restPosition=0;
    public float activePosition=45;
    public float hitStrenght=10000;
    public float FlipDamper=150;
    HingeJoint hinge;
    public string nameInput ="";

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = FlipDamper;

        if (Input.GetAxis(nameInput) ==1)
        {
            spring.targetPosition = activePosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;

    }
}
