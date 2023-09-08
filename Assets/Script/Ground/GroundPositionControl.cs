using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionControl : MonoBehaviour
{
    private GroundSpawnControl groundSpawnControl;

    private Rigidbody rigidbody;

    [SerializeField] private float endYValue;

    private int groundDirection;

    private void Start()
    {
        groundSpawnControl =GameObject.Find("Ground Spawn Control").GetComponent<GroundSpawnControl>();
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        CheckGroundVerticalPosition();
    }
    private void CheckGroundVerticalPosition()
    {
        if(transform.position.y <= endYValue) {
            SetRigidBodyValue();
            SetGroundNewPosition();
        }
    }

    private void SetGroundNewPosition()
    {
        groundDirection = Random.Range(0, 2);
        Vector3 pos = (groundDirection == 0) ? Vector3.left : Vector3.forward;
        transform.position = groundSpawnControl.GroundObject.transform.position + pos;
        transform.localScale = Vector3.one;
        groundSpawnControl.GroundObject = gameObject;
    }
    public void SetRigidBodyValue()
    {
        rigidbody.useGravity = !rigidbody.useGravity;
        rigidbody.isKinematic = !rigidbody.isKinematic;
    }
}
