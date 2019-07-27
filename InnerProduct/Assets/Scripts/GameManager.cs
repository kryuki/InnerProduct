using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject edgePrefab;
    GameObject go;

    float innerProduct;  //内積
    float angle;  //角度

    public Text angleText;

    bool trigger = false;
    public AudioSource audioSource;
    public GameObject bikkuri;

    // Use this for initialization
    void Start() {
        go = Instantiate(edgePrefab);
    }

    // Update is called once per frame
    void Update() {
        go.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

        //内積を求める
        innerProduct = Vector3.Dot(new Vector3(1, 0, 0), go.transform.position);
        //角度を求める
        angle = Mathf.Acos(innerProduct / (1 * go.transform.position.magnitude)) * Mathf.Rad2Deg;

        //角度を表示する
        angleText.text = angle.ToString();

        //角度が20度以下かどうか
        if (angle < 20) {
            if (trigger) {
                trigger = false;
                //音を鳴らす
                audioSource.Play();
            }
            bikkuri.SetActive(true);
        } else {
            trigger = true;
            bikkuri.SetActive(false);
        }
    }
}
