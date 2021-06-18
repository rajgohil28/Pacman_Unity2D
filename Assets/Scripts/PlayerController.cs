using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed;

	private Rigidbody2D rb;
	public GameObject gameoverCanvas;
	public GameObject[] EndLine;
	public GameObject[] LazyEnemies;
	public GameObject[] ActiveEnemies;
	public int randomEnemyNum;
	public GameObject WonPanel;
	public LazyEnemyAi LazyEnemy;
	public GameObject Controls;
	public Transform playertransform;
	public int gemscount;
	public int EndLineNum;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		EndLineNum = Random.Range(1, 12);
		randomEnemyNum = Random.Range(0, 3);
		gemscount = 0;
		LazyEnemies[randomEnemyNum].SetActive(true);
		ActiveEnemies[randomEnemyNum].SetActive(true);
	}
	void Update()
	{

		playertransform.Rotate(0, 0, 0);
		if (Input.GetKey(KeyCode.W))
		{
			rb.velocity = transform.up * speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			rb.velocity = -transform.up * speed;
		}
		if (Input.GetKey(KeyCode.D))
		{
			rb.velocity = transform.right * speed;
		}
		if (Input.GetKey(KeyCode.A))
		{
			rb.velocity = -transform.right * speed;

		}
		if (gemscount == 23)
		{
			EndLine[EndLineNum].SetActive(true);
		}

	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Collectible")
		{

			Destroy(collision.gameObject);
			gemscount++;

		}
		if (collision.tag == "Enemy")
		{
			gameoverCanvas.SetActive(true);
			Controls.SetActive(false);

		}
		if(collision.tag == "LazyEnemyRaidar")
        {
			LazyEnemy.activated = true;

        }
		if(collision.tag == "EndLine")
        {
			WonPanel.SetActive(true);	
        }

	}
    private void OnTriggerExit2D(Collider2D collision)
    {
		if (collision.tag == "LazyEnemyRaidar")
		{
			LazyEnemy.activated = false;

		}
	}
    public void MoveLeft()
	{
		rb.velocity = -transform.right * speed;
	}
	public void MoveRight()
	{
		rb.velocity = transform.right * speed;
	}
	public void MoveUp()
    {
		rb.velocity = transform.up * speed;
	}
	public void MoveDown()
    {
		rb.velocity = -transform.up * speed;
	}
}