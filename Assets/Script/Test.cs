using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);
        Application.LoadLevel("Splashscreen");
    }
}