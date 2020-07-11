using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_generater : MonoBehaviour
{
    public GameObject water;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void syoukan()
    {
        /*
        GameObject obj;
        obj = GameObject.Instantiate(water);

        obj.transform.position = transform.position;
        */
        gameObject.SetActive(true);
    }
}
