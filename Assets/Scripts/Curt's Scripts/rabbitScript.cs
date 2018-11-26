using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]

public class rabbitScript : MonoBehaviour {

    Vector3 currentPos, randomPos;
    public GameObject obj;
    Rigidbody rb;
    [SerializeField] float grazeTimer, acceptRange, wanderRadius;
    float timerReset;
    bool isActive = false;
    NavMeshAgent smith;

    // Use this for initialization
    void Start()
    {
        smith = GetComponent<NavMeshAgent>();
        timerReset = grazeTimer;
        currentPos = gameObject.transform.position;
        randomPos = GetNewLocal();
        rb = GetComponent<Rigidbody>();

    }



    private void FixedUpdate()
    {
        jump();
        currentPos = gameObject.transform.position;
        GetNewLocal();
        Roam();

    }

    Vector3 GetNewLocal()
    {
        //Vector3 position = new Vector3(Random.Range(0, 500), 0.5f, Random.Range(0, 500));
        Vector3 position = new Vector3(currentPos.x + Random.Range(-wanderRadius, wanderRadius), 1f, currentPos.z + Random.Range(-wanderRadius, wanderRadius));

        return position;
    }

    void Roam()
    {
        if (Vector3.Distance(currentPos, randomPos) >= acceptRange)
        {
            isActive = true;
            smith.SetDestination(randomPos);

        }
        else isActive = false;
        Grazing();
    }



    void Grazing()
    {
        if (!isActive)
        {
            if (grazeTimer <= 0)
            {
                grazeTimer = timerReset;
                randomPos = GetNewLocal();
            }
            else
            {
                grazeTimer -= Time.deltaTime;
            }

        }
    }
    void jump()
    {
        float jumpPower = 2;
        float jumptimer = 4;
        do
        {

            jumptimer -= Time.deltaTime;

        } while (jumptimer > 0);
        if (jumptimer == 0)
        {
            rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
            
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("weapon"))
        {
            Destroy(gameObject);
        }
    }
}
