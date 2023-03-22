using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject ObjetoMover;

    public Transform FinalePoint;

    public float Velocidad;

    private Vector3 MoverHacia;
    // Start is called before the first frame update
    void Start()
    {
        MoverHacia = FinalePoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoMover.transform.position = Vector3.MoveTowards(ObjetoMover.transform.position, MoverHacia, Velocidad * Time.deltaTime);


        if (ObjetoMover.transform.position == FinalePoint.position)
        {
            MoverHacia = FinalePoint.position;
        }
    }
}
