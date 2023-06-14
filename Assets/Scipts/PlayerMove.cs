using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 movement; // temel hareket için oluþturmuþ olduðum vector3
    [SerializeField] float speed;
     private Rigidbody rb;
    private TimeManager timeManager;
    [SerializeField] private GameObject deadEffect;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        timeManager = FindObjectOfType<TimeManager>();
    }
    private void Update()
    {
        if (timeManager.gameOver==false && timeManager.gameFinished==false)
        {
            MoveThePlayer();

        }

        if (timeManager.gameOver || timeManager.gameFinished)
        {
            rb.isKinematic = true;
        }

    }

    #region Temel hareket sistemi
    private void MoveThePlayer()  
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        movement = new Vector3(x, 0f, z);  // Üst satýrda getaxis kullanarak oluþturduðum x ve y yönü hareketlerini yeni bir vector3 tanýmlayýp movementa eþitliyorum.

        rb.AddForce(movement); // playerin rigidbodysini kullanarak addforce özelliðini kullanýyoruz ve addforce içine movementý yazarak temel hareketi saðlýyoruz.

    }
    #endregion

  

    private void OnDisable()
    {
        Instantiate(deadEffect, transform.position, transform.rotation);

    }
}
