using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    [SerializeField] private string transitionName;
    [SerializeField] private string sceneTrasitionName;
    private void Start()
    {
        if (transitionName == SceneManagment.Instance.SceneTransitionName)
        {
            Player.Instance.transform.position = this.transform.position;
        }
    }
}
