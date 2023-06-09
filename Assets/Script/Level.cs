using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int BreakableBlock;
    SceneLoader sceneloader;
    void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void CountBlock()
    {
        BreakableBlock++;
    }
    public void BlockDestroyed()
    {
        BreakableBlock--;
        if(BreakableBlock <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
