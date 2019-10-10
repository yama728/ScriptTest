using UnityEngine;
using System.Collections;

public class Boss {

	int mp = 53; //魔力

	//魔法用の関数
	public void Magic(int needMp) {

			if (mp >= 5) {
				this.mp -= needMp;
				Debug.Log ("ファイヤーボールの呪文を詠唱中・・・残りのMPは" + this.mp);
			} else {
				Debug.Log ("MPが足りない！！");
			}

	}
}
		
public class Test : MonoBehaviour {

	void Start () {

		// 要素数5の配列を初期化する
		int[] array = new int[5];

		// 配列の各要素に値を代入する
		array [0] = 30;
		array [1] = 20;
		array [2] = 50;
		array [3] = 10;
		array [4] = 80;

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

		//配列の要素を逆順に表示する
		for (int i = array.Length - 1; 0 <= i; i--) {
			Debug.Log (array [i]);
		}

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		for (int i = 0; i < 11; i++) {
		
			//魔法用の関数を呼び出す
			lastboss.Magic (5);

		}

}

	// Update is called once per frame
	void Update () {

	}
}