using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionControl : MonoBehaviour
{
    GroundFallControl groundFallControl;
    private void Start()
    {
        groundFallControl = GetComponent<GroundFallControl>();
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           StartCoroutine(groundFallControl.SetRigidBodyValue());
            DataTransmiter.Instance.GetScoreControl().Score = 1;
        }
    }
}
