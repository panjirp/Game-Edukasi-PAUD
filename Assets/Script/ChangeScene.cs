using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{

    public void ChangeScenes(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

}