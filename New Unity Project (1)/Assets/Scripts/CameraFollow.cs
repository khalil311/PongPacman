using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform birdtransform;
    Vector3 range;
    // Start is called before the first frame update
    void Awake()
    {
        range = transform.position - birdtransform.position;         // lets say that the transform position is (5 , 3 ,3 ) and the birdtransform is (3 , 2 , 2 ) the range between both of them will be (2 , 1 , 1 )  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(birdtransform.position.x + range.x, transform.position.y, range.z + birdtransform.position.z);   // in this we declare that the position of the X axis would be the same as the birdtransform one however the range would be the one that we picked up earlier 
    }
}
