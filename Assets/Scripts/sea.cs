using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sea : MonoBehaviour
{
    [SerializeField]
    private Vector4 start;
    [SerializeField]
    private Vector4 end;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector4 colorVector = Vector4.Lerp(new Vector4(start.x/255, start.y / 255, start.z / 255, start.w / 255), new Vector4(end.x/255, end.y / 255, end.z / 255,end.w/255), Camera.main.transform.position.x / 254);
        GetComponent<SpriteRenderer>().color = new Color(colorVector.x,colorVector.y,colorVector.z,colorVector.w);
    }
}
