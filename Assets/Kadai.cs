using UnityEngine;
using System.Collections;

public class Kadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		int[] array = {3,7,13,17,28};  //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		for (int i = 0; i < array.Length; i++) {
			Debug.Log(array [i]); //配列の各要素の値を順番に表示してください
		}for(int i = array.Length - 1; i >= 0; i--){ 
			Debug.Log(array [i]); //for文を使い、配列の各要素の値を逆順に表示してください
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
