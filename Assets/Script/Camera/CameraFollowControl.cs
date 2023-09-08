using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CameraFollowControl : MonoBehaviour
{
    private Transform ballTransform;
    private Vector3 offset;
    private Vector3 newPosition;
    [SerializeField] [Range(0,3)] private float lerpValue;
    void Start()
    {
        ballTransform = GameObject.Find("Ball").transform;
        offset=transform.position- ballTransform.position;
    }

    private void LateUpdate()
    {
        CameraFollowGameObject();
    }

    private void CameraFollowGameObject()
    {
        newPosition=Vector3.Lerp(transform.position, ballTransform.position+ offset,lerpValue* Time.deltaTime);
        transform.position=newPosition;
    }
}
