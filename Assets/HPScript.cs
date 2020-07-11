using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPScript : MonoBehaviour
{
    private Slider setSlider;
    public GameObject slider;
    public float flashspeed = 5f;
    public Color flashColor = new Color(1f, 0, 0, 0.1f);
    bool damage;

        [SerializeField]
    public float HP = 10f;
    public bool hit;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        setSlider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (damage == true)
        {
            Image.color = flashColor;

        }

        else
        { Image.color = Color.Lerp(image.color, Color.clear, flashspeed * Time.deltaTime);
        } 

         setSlider.value = HP;

      if(HP <= 0)
        {
            
        }
        damage = false;

}
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "enemy")
        {
            HP--;
            image = Color.Lerp(image.color, Color.clear, 10f * Time.deltaTime);
        }

        if (other.gameObject.tag == "enemy")
        {
            hit = true;
            // text.enabled = true;
            print("Hit");
            //hit = ture
        }

    }
}
