using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPointBehaviour : MonoBehaviour
{

    private void Awake()
    {
        References.patrolPoints.Add(this);
    }
    private void OnDisable()
    {
        References.patrolPoints.Remove(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
