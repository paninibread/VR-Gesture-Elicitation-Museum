using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMan : MonoBehaviour
{
    
    public Material torii;
    public Material mountain;
    public Material country;
    public Material space;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setTorii()
    {
        RenderSettings.skybox = torii;
    }

    public void setMountain()
    {
        RenderSettings.skybox = mountain;
    }

    public void setCountry()
    {
        RenderSettings.skybox = country;
    }

    public void setSpace()
    {
        RenderSettings.skybox = space;
    }

}
