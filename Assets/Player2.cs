using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public GameObject Potal1;
    public GameObject Potal2;
    float posx, posy, posz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "potal1")
        {
            posx = Potal2.transform.position.x;
            posy = Potal2.transform.position.y;
            posz = Potal2.transform.position.z;
            transform.position = new Vector3(posx - 5, posy + 10, posz);
        }
        if (col.gameObject.tag == "potal2")
        {
            posx = Potal1.transform.position.x;
            posy = Potal1.transform.position.y;
            posz = Potal1.transform.position.z;
            transform.position = new Vector3(posx + 5, posy + 10, posz);
        }

    }
}
