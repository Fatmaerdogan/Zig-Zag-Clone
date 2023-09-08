using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallControl : MonoBehaviour
{
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    public IEnumerator SetRigidBodyValue()
    {
        yield return new WaitForSeconds(0.75f);
        rigidbody.useGravity = !rigidbody.useGravity;
        rigidbody.isKinematic = !rigidbody.isKinematic;
    }
   
}
