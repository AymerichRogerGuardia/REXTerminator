using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Jump : MonoBehaviour
{
    //declaro el objecte y li posu la variable i li indico un valor
    [SerializeField] float jumpForce = 7;
    [SerializeField] private LayerMask groundlayerMask;
    public float timer = 0f;

    DetectorGround detector;
    
    //declaro el objecte del cos y li posu un nom perque entengui que es el cos
    Rigidbody2D rb;

    private void Start()
    {
      timer = 0;
      //en el primer frame li indico que la palaula rb es igual al component de rigidbody que es el cos del objecte
      rb = GetComponent<Rigidbody2D>();
      detector = GetComponent<DetectorGround>();
    }

    private void Update()
    {
        //aqui faig que mentre la tecla estigui presionada lo que primer fara es pujar el objecte, despues multiplicara la força del objecte amb un valor , y per ultim lo que fa el ForceMode2D es canviar de força a impuls fent que l'objecte puji cap a d'alt
        if (Input.GetKeyDown(KeyCode.Space) && detector.grounded) 
        {
            detector.grounded = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            timer = 0;
        }

    }
    

}


