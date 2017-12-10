using UnityEngine;
using System.Collections;

		/*発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう

		余力がある方、さらに理解を深めたい方は発展課題もチャレンジしましょう！
		Lesson4で作成したプロジェクトScriptTestに追記しましょう。

		Bossクラスについて下記の条件を満たしてください

		Lesson4で作成したBossクラスをもとに作成してください

		int型の変数mpを宣言し、53で初期化してください
		mpを消費して魔法攻撃をするMagic関数を作ってください
		Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
		Start関数で下記の条件を満たしてください

		Magic関数を呼び出して、魔法を使ってください
		Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
		*/

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53;  // 魔力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}
	// Magic
	public  void Magic() {
		if (mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		}else{
			Debug.Log ("MPが足りないため魔法が使えない。");
			// 残りhpを減らす
		}
	}
}

public class BossTest : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
		// 魔法用の関数を呼び出す
		lastboss.Magic();

		//１０回魔法攻撃確認
		for (int i = 0; i <= 9; i++) {
			lastboss.Magic ();
		}

	}

	// Update is called once per frame
	void Update () {

	}
}


