using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{




    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        if (collision.gameObject.tag=="Player")
        {
            FindObjectOfType<TimeManager>().gameOver = true;
        }
    }
}
