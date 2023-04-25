using System.Collections;
using UnityEngine;

public class DiscoLightController : MonoBehaviour
{
    private Dance1 dance1;
    public float minTimeBetweenColorChanges = 1f;
    public float maxTimeBetweenColorChanges = 5f;
    private float timer = 0f;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        dance1 = FindObjectOfType<Dance1>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        // Only change the color of the lights if dancemove4 is not being performed
        if (dance1.isPerformingDanceMove4 == false && timer >= 1f)
        {
            float waitTime = Random.Range(minTimeBetweenColorChanges, maxTimeBetweenColorChanges);
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value, 1f);
            timer = 0f;
        }      
    }

}