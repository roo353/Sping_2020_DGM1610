using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelay : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Object.Destroy(gameObject, 1.25f);
    }
}
