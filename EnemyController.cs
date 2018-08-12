using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform fpsTarget;
    Rigidbody theRigidbody;
    Renderer myRender;


    // Use this for initialization
    void Start() {
        myRender = GetComponent<Renderer>();
        theRigidbody = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update() {
        fpsTargetDistance = Vector3.Distance(fpsTarget.position, transform.position);
        if (fpsTargetDistance < enemyLookDistance) {
            myRender.material.color = Color.red;
            lookAtPlayer();
            print("Look at Player Please!");
        }
        if (fpsTargetDistance < attackDistance)
        {
            attackPlease();
            print("ATTACK");
        }
        else
        {
            myRender.material.color = Color.yellow;


        }
    }
    void lookAtPlayer() {
        Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }


    void attackPlease(){
        theRigidbody.AddForce(transform.forward*enemyMovementSpeed);

    }
 }
