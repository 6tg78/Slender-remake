using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class FixMovement : MonoBehaviour
{
    public FixedJoystick MoveJoystick;
    public FixedTouchField TouchField;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var Fps = GetComponent<RigidbodyFirstPersonController>();

        Fps.RunAxis = MoveJoystick.Direction;
        Fps.mouseLook.LookAxis = TouchField.TouchDist;
    }
}
