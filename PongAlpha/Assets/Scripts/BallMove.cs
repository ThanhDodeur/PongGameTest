using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour {

    public float movementSpeed;
    public float speedPerHit;
    public float maxSpeed;

    int hitCounter = 0;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(this.StartBall());
	}

    void PositionBall(bool isStartingPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.PositionBall(isStartingPlayer1);

        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float speed = this.movementSpeed + this.hitCounter * this.speedPerHit;

        Rigidbody2D physicalBody = this.gameObject.GetComponent<Rigidbody2D>();

        physicalBody.velocity = direction * speed * Time.deltaTime * 50;
    }

    public void IncreaseHitCounter()
    {
        if(this.hitCounter * this.speedPerHit <= this.maxSpeed)
        {
            this.hitCounter++;
        }
    }
	
}
