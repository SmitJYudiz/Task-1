using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    //player should move when mouse button 1 is down, and move smoothly, when it's UP then do not move
    public float playerSpeed = 5;

    public int nextPatrolPointIndex;

    int totalPatrolPoints;

    // Start is called before the first frame update
    void Start()
    {
        nextPatrolPointIndex = 0;

        totalPatrolPoints = References.patrolPoints.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Debug.Log("Right mouse button pressed");
            //transform.position += Vector3.forward*playerSpeed*Time.deltaTime;

            //travel to the patrol points
            //direction to travel, for now not using the index i, take that in for loop
            Vector3 directionToNextPetrolPoint = References.patrolPoints[nextPatrolPointIndex].transform.position - transform.position;
            if(directionToNextPetrolPoint.magnitude<0.1f)
            {
                //we should now go to the next patrol point, and if all are visited, then we should go to the first one
                nextPatrolPointIndex++;
                if(nextPatrolPointIndex>=totalPatrolPoints)
                {
                    nextPatrolPointIndex = 0;
                }
                

            }
            directionToNextPetrolPoint.Normalize();
            transform.position += directionToNextPetrolPoint * Time.deltaTime * playerSpeed;
        }
    }
}
