using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeChildObjectClass : SomeParentObjectClass, IDraggable3D
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;

    }
}
