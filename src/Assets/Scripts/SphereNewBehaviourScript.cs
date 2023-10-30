using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereNewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform transform =this.transform;
        transform.Rotate(0, 0, 3);
    }
}
