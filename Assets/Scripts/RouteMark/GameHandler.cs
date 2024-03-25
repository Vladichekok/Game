using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Window_QuestPointer windowQuestPointer;
    private void Start()
    {
        windowQuestPointer.Show(new Vector3(-1, -40, 0));

        int state = 0;
        FunctionUpdater.Create(() =>
        {
            switch (state)
            {
                case 0:
                    if (Vector3.Distance(Camera.main.transform.position, new Vector3(-1, -40, 0)) < 50)
                    {
                        windowQuestPointer.Show(new Vector3(200, -100));
                        state = 1;
                    }
                        break;
                        case 1:
                            if (Vector3.Distance(Camera.main.transform.position, new Vector3(200, -100)) < 50)
                    {
                        windowQuestPointer.Hide();
                                state = 2;
                            }
                            break;
                        }
                });
    }
}
