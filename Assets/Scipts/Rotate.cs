using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Vector3 angle;



    private void Update()
    {
        transform.Rotate(angle,Space.World);
    }
}
