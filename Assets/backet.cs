using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backet : MonoBehaviour
{
    public GameObject water;

    public GameObject water_particle;
    private water_generater water_g;

    // Start is called before the first frame update
    void Start()
    {
        water_g = water_particle.GetComponent<water_generater>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        //water_g.syoukan();
        if (collision.gameObject.tag == "bullet") {
            GameObject obj;
            obj = GameObject.Instantiate(water);

            obj.transform.position = new Vector3(234, 1, 225);
        }
    }

}
