using UnityEngine;
using UnityEngine.UI;

public class FlushController : MonoBehaviour
{
    Image img;
    Enemy enemy;
    public GameObject ENEMY;

    void Start()
    {
        img = GetComponent<Image>();

        img.color = Color.clear;
        enemy = ENEMY.GetComponent<Enemy>();
    }

    void Update()
    {
        if (enemy.hit == 1)
        {
            this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
        }
        else
        {
            this.img.color = Color.Lerp(this.img.color, Color.clear, Time.deltaTime);
        }
    }
}
