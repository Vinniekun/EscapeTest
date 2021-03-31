using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    public static SceneManagement Instance;
    private AssetBundle loadedAB;
    public string[] scenePaths;

    void Start()
    {
        loadedAB = AssetBundle.LoadFromFile("Assets/FurnishedCabin/Scenes");
        scenePaths = loadedAB.GetAllScenePaths();

    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

}
