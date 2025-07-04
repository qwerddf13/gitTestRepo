using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float AxisRaw_H = Input.GetAxisRaw("Horizontal");
        float AxisRaw_V = Input.GetAxisRaw("Vertical");
        Vector2 moveImpulse = new Vector2(AxisRaw_H * moveSpeed, AxisRaw_V * moveSpeed);
        transform.Translate(moveImpulse);

        if (Math.Abs(transform.position.x) > 10 || Math.Abs(transform.position.y) > 5)
        {
            transform.position = new Vector2(0, 0);
        }
    }
}
