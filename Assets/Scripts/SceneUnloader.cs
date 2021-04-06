using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUnloader : MonoBehaviour
{
    [SerializeField] private string sceneName;
    private void Start()
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }
}
