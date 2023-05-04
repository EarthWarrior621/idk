using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStrikes : MonoBehaviour
{
    private Light light;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        InvokeRepeating("Lighting", 10f, 10f);
    }

       
    
    // Update is called once per frame
    void Update()
    {
       
    }

    void Lighting() 
    {
        foreach (GameObject enemy in enemies) { enemy.SetActive(true); }
        light.intensity = 5;
        Invoke("NoLighting", 0.69f);
         
    }

    void NoLighting()
    {
        foreach (GameObject enemy in enemies) { enemy.SetActive(false); }
        light.intensity = 0.08f;
       

    }
}
