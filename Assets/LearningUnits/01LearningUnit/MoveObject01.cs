using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//changed move_direction to -1x
public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        //new code
        transform.position = transform.position + moveDirection;
    }
}
