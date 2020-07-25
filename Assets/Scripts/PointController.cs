using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
	GameObject pointText;
	int points = 0;

	public int pointAdd(int p){
		return points += p;
		}

	// Use this for initialization
	void Start()
	{
		//シーン中のPointオブジェクトを取得
		this.pointText = GameObject.Find("PointText");
		//初期ポイントを表示
		this.pointText.GetComponent<Text>().text = "Point:" + points;
	}

	// Update is called once per frame
	void Update()
	{

	}

	//衝突時にタグに応じて加点しPointTextに得点を表示
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "SmallStarTag")
		{
			pointAdd(10);
			this.pointText.GetComponent<Text>().text = "Point:" + points;
		}
		else if (other.gameObject.tag == "LargeStarTag")
		{
			pointAdd(20);
			this.pointText.GetComponent<Text>().text = "Point:" + points;
		}
		else if (other.gameObject.tag == "SmallCloudTag" || tag == "LargeCloudTag")
		{
			pointAdd(30);
			this.pointText.GetComponent<Text>().text = "Point:" + points;
		}
	}
}
