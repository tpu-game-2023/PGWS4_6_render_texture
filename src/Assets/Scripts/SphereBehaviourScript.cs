using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0.7f * Mathf.Sin(0.2f * Time.time), 0.0f, 0.8f);
    }
}
