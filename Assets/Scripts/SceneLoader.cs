using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private bool isAdditive;
    [SerializeField] private string sceneName;

    private void Start()
    {
        /*SceneManager.LoadScene("Menu");
        SceneManager.LoadScene(1);*/
        var isAdditiveVal = isAdditive ? LoadSceneMode.Additive : LoadSceneMode.Single;
        SceneManager.LoadScene(sceneName, isAdditiveVal);
        // SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
    }
}
