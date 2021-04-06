using UnityEngine;

public class PrefabInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject prefabInstance;
    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;
        if (_time < 2) return;
        _time = 0;
        //Instantiate
        Random.Range(0, 5);
        var newGo = Instantiate(prefabInstance, new Vector3(0, Random.Range(-4f, 4f), 0), Quaternion.Euler(10, 0, 50), transform);
        var moveComponent = newGo.GetComponent<Move>();
        moveComponent.enabled = false;
        
        /*Destroy(GameObject.Find("Main Camera"));
        Destroy(newGo.GetComponent<Move>());*/
    }
}
