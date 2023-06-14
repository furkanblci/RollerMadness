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

    //performans düzeltmesi yapmak için 3 saniye sonra eklenilen partikülleri destroy ettim
   
    void Update()
    {
        
    }
}
