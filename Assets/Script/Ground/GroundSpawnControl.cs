using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnControl : MonoBehaviour
{
    public GameObject GroundObject;
    public GameObject GroundParentObject;
    [SerializeField] private GameObject GroundPrefab;
    private GameObject newGroundObject;
    private int groundDirection;
    void Start()
    {
        GenerateRandomNewGrounds();
    }


    void Update()
    {
        
    }

    private void GenerateRandomNewGrounds()
    {
        for (int i = 0; i < 100; i++) { CreatNewGround(); }
    }
    private void CreatNewGround()
    {
        groundDirection = Random.Range(0,2);
        Vector3 pos = (groundDirection == 0) ? Vector3.left : Vector3.forward;
        newGroundObject = Instantiate(GroundPrefab,GroundObject.transform.position+pos, Quaternion.identity) as GameObject;
        GroundObject = newGroundObject;
        GroundObject.transform.parent = GroundParentObject.transform;
    }
}
