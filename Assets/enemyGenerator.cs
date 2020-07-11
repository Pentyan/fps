using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Generate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(5.0f);
            GameObject obj;
            obj = GameObject.Instantiate(enemy);

            obj.transform.position = transform.position;
            
        }
        


    }
}
