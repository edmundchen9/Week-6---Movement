using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 forceDirection;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        ApplyInstantForce();
    }

    void ApplyInstantForce()
    {
    rigidbody.AddForce(forceDirection, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
     rigidbody.AddForce(forceDirection, ForceMode.Acceleration);
    }
}
