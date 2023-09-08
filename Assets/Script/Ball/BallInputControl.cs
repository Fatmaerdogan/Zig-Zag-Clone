using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputControl : MonoBehaviour
{
    [HideInInspector] public Vector3 ballDirection;
    void Start()
    {
        ballDirection = Vector3.left;
    }

    void Update()
    {
        HandleBallInput();
    }
    private void HandleBallInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ChangeBallDirection();
        }
    }
    private void ChangeBallDirection()
    {
        ballDirection = (ballDirection.x == -1) ? Vector3.forward : Vector3.left;
    }
}
