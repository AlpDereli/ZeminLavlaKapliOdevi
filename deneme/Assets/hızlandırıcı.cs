using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hızlandırıcı : MonoBehaviour
{
    public Vector3 hiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += hiz;
    }
}
