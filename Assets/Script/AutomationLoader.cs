using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomationLoader : MonoBehaviour
{
    public SceneHandler sh;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SceneLoad", 10f);  
    }

    void SceneLoad()
    {
        sh.ChangeSceneNow(sceneName);
    }
}
