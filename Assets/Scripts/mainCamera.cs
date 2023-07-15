using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamera : MonoBehaviour
{
    [SerializeField]
    private float CameraSpeed = 1;
    void Start()
    {
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        float playerX = player.Player.transform.position.x;
        float speed = CameraSpeed * (playerX - transform.position.x);

        transform.Translate(new Vector3(Mathf.Floor(speed) * Time.deltaTime, 0, 0));
        //transform.position = new Vector3 (playerX, transform.position.y, transform.position.z);


        if (transform.position.x < 0)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        if (transform.position.x > 254)
            transform.position = new Vector3(254, transform.position.y, transform.position.z);



    }
}
