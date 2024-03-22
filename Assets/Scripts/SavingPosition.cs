using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPosition : MonoBehaviour
{
    private void Start()
    {
        transform.position=new Vector2(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"));
    }

    void Update()
    {
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat ("y", transform.position.y);
    }
}
