using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementControl : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    private void Update()
    {
        SetBallMovement();
    }
    private void SetBallMovement()
    {
        transform.position+=DataTransmiter.Instance.GetBallDirection() *ballSpeed*Time.deltaTime;
    }
}
