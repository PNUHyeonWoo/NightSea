using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static GameObject Player;
    [SerializeField]
    private float Acceleration = 10;
    [SerializeField]
    private float maxSpeed = 10;

    private void Awake()
    {
        Player = gameObject;
    }
    void Start()
    {
        
    }

    void Update()
    {          
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0).normalized;
        GetComponent<Rigidbody2D>().AddForce(direction * Acceleration);

        float nowSpeed = GetComponent<Rigidbody2D>().velocity.magnitude;

        if (nowSpeed >= maxSpeed)
            GetComponent<Rigidbody2D>().velocity = (GetComponent<Rigidbody2D>().velocity / nowSpeed)*maxSpeed;

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        else if(GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);


        fishing();

    }

    void fishing() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GetComponent<Animator>().GetBool("fishing"))
        {
            GetComponent<Animator>().SetBool("fishing", true);
            GetComponent<AudioSource>().Play();
        }
    }

    public void setFishing(int b) 
    {
            GetComponent<Animator>().SetBool("fishing", b == 1);
    }
}
