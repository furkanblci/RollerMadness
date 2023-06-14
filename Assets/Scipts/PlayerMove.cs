using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 movement; // temel hareket i�in olu�turmu� oldu�um vector3
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

        movement = new Vector3(x, 0f, z);  // �st sat�rda getaxis kullanarak olu�turdu�um x ve y y�n� hareketlerini yeni bir vector3 tan�mlay�p movementa e�itliyorum.

        rb.AddForce(movement); // playerin rigidbodysini kullanarak addforce �zelli�ini kullan�yoruz ve addforce i�ine movement� yazarak temel hareketi sa�l�yoruz.

    }
    #endregion

  

    private void OnDisable()
    {
        Instantiate(deadEffect, transform.position, transform.rotation);

    }
}
