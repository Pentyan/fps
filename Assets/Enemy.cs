using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    GameObject player;
    HPScript hpscript;
    Text text;
    public int hit;

    // Start is called before the first frame update
    void Start()
    {
        hit = 0;
        player=GameObject.FindGameObjectWithTag("Player");
        text = GameObject.FindGameObjectWithTag("gameover").GetComponent<Text>();
        hpscript = player.GetComponent<HPScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);

        transform.position += transform.forward * 3.0f * Time.deltaTime;

        if (hpscript.HP < 1)
        {
            text.enabled = true;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            hit = 1;
            // text.enabled = true;
            print("Hit");
            hit = 0;
        }
        
    }
}
