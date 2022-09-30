using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//i changed the mass of blue cube
public class MoveObjectWM : MonoBehaviour
{
    [SerializeField] Quaternion moveDirection;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddTorque(transform.up * 50);
        rigidbody.AddTorque(transform.right * 50);
    }
}
