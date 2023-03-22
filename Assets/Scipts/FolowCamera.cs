using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowCamera : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        
    }
    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y);
    }
}
