using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private GameObject unitychan;
    float it;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.it = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (unitychan.transform.position.z > it + 7.0f )
        {
            Destroy(this.gameObject);
        }
    }
}
