using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//changed mass of blue cube
public class MoveObject02 : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        ApplyInstantForce();
    }
    
 void ApplyInstantForce()
    {
    GetComponent<Rigidbody>().AddForce(moveDirection, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
     GetComponent<Rigidbody>().AddForce(moveDirection, ForceMode.Acceleration);
    }

}
