using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private float time = 3f;

    private void Awake()
    {
        Destroy(gameObject, time);
    }
    void Start()
    {
       

    }

    //performans d�zeltmesi yapmak i�in 3 saniye sonra eklenilen partik�lleri destroy ettim
   
    void Update()
    {
        
    }
}
