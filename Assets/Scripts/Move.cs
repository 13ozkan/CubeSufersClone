using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] private float forwardSpeed;
    [SerializeField] private float directionSpeed;

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * directionSpeed * Time.deltaTime;
        this.transform.Translate(horizontalAxis, 0, forwardSpeed * Time.deltaTime);  
    }
}
