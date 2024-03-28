using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour
{
    [SerializeField]
    private SceneAsset sceneToSwitchTo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SwitchScene();
    }

    private void OnMouseDown()
    {
        SwitchScene();
    }

    public void SwitchScene()
    {
        if (sceneToSwitchTo != null)
        {
            SceneManager.LoadScene(sceneToSwitchTo.name);
        }
        else
        {
            Debug.LogWarning("SceneToSwitchTo не выбрана.");
        }
    }
}
