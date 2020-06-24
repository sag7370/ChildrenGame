using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicTest : MonoBehaviour {
	AudioSource As;
	Button btn;
	GameObject father;
	// Use this for initialization
	void Start () {
		As = GetComponent<AudioSource>();
		btn = GetComponent<Button>();
		btn.onClick.AddListener(OnBtnClick);//绑定按钮事件
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnBtnClick()
	{
		father = transform.parent.gameObject;
		//获取父节点的MusicPause脚本
		var fa = father.GetComponent<MusicPause>();
		fa.musicPause();
		As.Play();
    }
}
