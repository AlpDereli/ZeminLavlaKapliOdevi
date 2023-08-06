using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topunkodu : MonoBehaviour
{
    public Vector3 sayi;
    public Vector3 pos;
    public Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += sayi;
        transform.position += pos;
        transform.Rotate (rot);
    }
}
