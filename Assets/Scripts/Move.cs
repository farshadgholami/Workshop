using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int sampleField;
    [SerializeField] private float speed;
    [SerializeField] private float speedRotation;
    [SerializeField] private float speedScale;
    
    private Transform _transform;

    private void Awake()
    {
        /*_transform = gameObject.GetComponent<Transform>();
        _transform = GetComponent<Transform>();*/
        _transform = transform;
        
        print("Awake");
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }

    private void OnEnable()
    {
        print("OnEnable");
    }

    private void Start()
    {
        print("Start");
        // CreateNewGo();
    }

    private void CreateNewGo()
    {
        var newGo = new GameObject("Sample");
        var moveComp = newGo.AddComponent<Move>();
        newGo.AddComponent<Collider>();
        moveComp.sampleField = 3;
    }

    private void Update()
    {
        //print("Update");
        /*Vector3 pos = _transform.position;
        pos.x = pos.x + speed * Time.deltaTime;
        _transform.position = pos;*/
        _transform.localPosition = _transform.localPosition + new Vector3(speed * Time.deltaTime, 0, 0);
        _transform.localScale += Vector3.right * speedScale * Time.deltaTime;
        _transform.Rotate(Vector3.right * speedRotation * Time.deltaTime);
    }/*

    private void FixedUpdate()
    {
        print("FixedUpdate");
    }

    private void LateUpdate()
    {
        print("LateUpdate");
    }*/

    private void OnDisable()
    {
        print("Disable");
    }

    private void OnDestroy()
    {
        print("Destroy");
    }

    private void OnApplicationQuit()
    {
        print("Quit");
    }

    public void A()
    {
        
    }
}
