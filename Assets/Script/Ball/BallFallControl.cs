using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFallControl : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField] private float endYValue;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        CheckGroundVerticalPosition();
    }
    private void CheckGroundVerticalPosition()
    {
        if (transform.position.y <= endYValue)
        {
            SetRigidBodyValue();
        }
    }

    public void SetRigidBodyValue()
    {
        rigidbody.useGravity = !rigidbody.useGravity;
        rigidbody.isKinematic = !rigidbody.isKinematic;
        DataTransmiter.Instance.GetFailPanelControl().Enable();
    }
}
