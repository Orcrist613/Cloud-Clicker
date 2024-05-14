using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geceGunduz : MonoBehaviour
{
    public Material mt;
    public Color32[] colors;

   
    void Start()
    {
        mt = transform.GetComponent<Renderer>().material;

        colors = new Color32[11]
        {
            new Color32(176, 224, 230, 255), // Açýk Mavi (Gündüz)
            new Color32(200, 230, 255, 255), // Açýk Mavi (Gece)
            new Color32(230, 255, 255, 255), // Açýk Mavi (Þafak)
            new Color32(255, 242, 0, 255),   // Sarý (Gündüz)
            new Color32(255, 242, 150, 255), // Sarý (Gece)
            new Color32(255, 210, 0, 255),   // Sarý (Þafak)
            new Color32(255, 196, 100, 255), // Hafif Turuncu (Gündüz)
            new Color32(255, 160, 100, 255), // Hafif Turuncu (Gece)
            new Color32(255, 130, 0, 255),   // Hafif Turuncu (Þafak)
            new Color32(30, 60, 90, 255),    // Gece Mavisi (Gece)
            new Color32(70, 100, 130, 255),  // Gece Mavisi (Þafak)
        };

        StartCoroutine(Cycle());
    }

    
    void Update()
    {
       
    }

    public IEnumerator Cycle()
    {
        int i = 0;
        while (true)
        {
            for (float t = 0f; t < 1f; t += Time.deltaTime / 10f) 
            {
                mt.color = Color.Lerp(colors[i % 11], colors[(i + 1) % 11], t);
                yield return null;
            }

            i++;
        }
    }
}
