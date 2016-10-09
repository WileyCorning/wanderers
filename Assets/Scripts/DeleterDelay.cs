using UnityEngine;
using System.Collections;

public class DeleterDelay : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(Timer());
        ResetColor();
    }

    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(4);
    }
    void ResetColor()
    {
        Color temp = GetComponent<SpriteRenderer>().color;
        temp.a = 1f;
        GetComponent<SpriteRenderer>().color = temp;
    }

}
