﻿using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
	public GameObject[] SoundArray;//聲音陣列
	public string SoundArrayText;
	public float Timer;
	// Use this for initialization
	void Start () {
	DontDestroyOnLoad(transform.gameObject);
	SoundArray[0] = GameObject.Find("Chinese_SoundArray/SoundArray (1)");//1.請問，還有空位嗎?
    SoundArray[1] = GameObject.Find("Chinese_SoundArray/SoundArray (2)");//2.有的，請問，您們是兩位用餐嗎?
    SoundArray[2] = GameObject.Find("Chinese_SoundArray/SoundArray (3)");//4.好的，請往這邊。
    SoundArray[3] = GameObject.Find("Chinese_SoundArray/SoundArray (4)");//5.請問，你們有沒有套餐?
    SoundArray[4] = GameObject.Find("Chinese_SoundArray/SoundArray (5)");//6.我們目前有四種套餐。
    SoundArray[5] = GameObject.Find("Chinese_SoundArray/SoundArray (6)");//8.沒關係，稍後再為您服務。
    SoundArray[6] = GameObject.Find("Chinese_SoundArray/SoundArray (7)");//10.我要點一份A套餐。彼得你呢?
    SoundArray[7] = GameObject.Find("Chinese_SoundArray/SoundArray (8)");//12.OK，那就這樣決定了。
    SoundArray[8] = GameObject.Find("Chinese_SoundArray/SoundArray (9)");//14.好的，為您確認一下餐點。一份A餐和一份C餐。
    SoundArray[9] = GameObject.Find("Chinese_SoundArray/SoundArray (10)");//15.請問飲品要餐前上還是餐後上呢?
    SoundArray[10] = GameObject.Find("Chinese_SoundArray/SoundArray (11)");//16.我想先上飲料，彼得你呢?
    SoundArray[11] = GameObject.Find("Chinese_SoundArray/SoundArray (12)");//18.好的，稍後會為您上飲品
    SoundArray[12] = GameObject.Find("Chinese_SoundArray/SoundArray (13)");//20.不，我沒點這個套餐。
    SoundArray[13] = GameObject.Find("Chinese_SoundArray/SoundArray (14)");//21.請問有什麼需要呢?
    SoundArray[14] = GameObject.Find("Chinese_SoundArray/SoundArray (15)");//23.請稍後，我們確認一下餐點。
    SoundArray[15] = GameObject.Find("Chinese_SoundArray/SoundArray (16)");//24.您們在這兩種套餐打上Ｘ的記號。
    SoundArray[16] = GameObject.Find("Chinese_SoundArray/SoundArray (17)");//26.打差表示不要。打勾表示需要。
    SoundArray[17] = GameObject.Find("Chinese_SoundArray/SoundArray (18)");//28. 真的很抱歉，這是我們的疏失，我請廚師特別做了特餐，來補償你們。
    SoundArray[18] = GameObject.Find("Chinese_SoundArray/SoundArray (19)");//30. 但是提醒您，下次請不要將需要餐點做打差的記號。
    SoundArray[19] = GameObject.Find("Chinese_SoundArray/SoundArray (20)");//32.這間店服務真好
    SoundArray[20] = GameObject.Find("Chinese_SoundArray/SoundArray (21)");//34.不，我已經很飽了。
    SoundArray[21] = GameObject.Find("Chinese_SoundArray/SoundArray (22)");//36.我也很渴。
    SoundArray[22] = GameObject.Find("Chinese_SoundArray/SoundArray (23)");//38.我不想點飲料。我想加點一碗湯。
    SoundArray[23] = GameObject.Find("Chinese_SoundArray/SoundArray (24)");//40.老闆，結帳。
    SoundArray[24] = GameObject.Find("Chinese_SoundArray/SoundArray (25)");//43.請稍後，讓我為您結算。
    SoundArray[25] = GameObject.Find("Chinese_SoundArray/SoundArray (26)");//45.可以的。請給我你的信用卡。
    SoundArray[26] = GameObject.Find("Chinese_SoundArray/SoundArray (27)");//47.感謝您的惠顧，歡迎再次光臨。

    SoundArray[27] = GameObject.Find("German_SoundArray/SoundArray (1)");//1.請問，還有空位嗎?(德文版)
    SoundArray[28] = GameObject.Find("German_SoundArray/SoundArray (2)");//2.有的，請問，您們是兩位用餐嗎?(德文版)
    SoundArray[29] = GameObject.Find("German_SoundArray/SoundArray (3)");//4.好的，請往這邊。(德文版)
    SoundArray[30] = GameObject.Find("German_SoundArray/SoundArray (4)");//5.請問，你們有沒有套餐?(德文版)
    SoundArray[31] = GameObject.Find("German_SoundArray/SoundArray (5)");//6.我們目前有四種套餐。(德文版)
    SoundArray[32] = GameObject.Find("German_SoundArray/SoundArray (6)");//8.沒關係，稍後再為您服務。(德文版)
    SoundArray[33] = GameObject.Find("German_SoundArray/SoundArray (7)");//10.我要點一份A套餐。彼得你呢?(德文版)
    SoundArray[34] = GameObject.Find("German_SoundArray/SoundArray (8)");//12.OK，那就這樣決定了。(德文版)
    SoundArray[35] = GameObject.Find("German_SoundArray/SoundArray (9)");//14.好的，為您確認一下餐點。一份A餐和一份C餐。(德文版)
    SoundArray[36] = GameObject.Find("German_SoundArray/SoundArray (10)");//15.請問飲品要餐前上還是餐後上呢?(德文版)
    SoundArray[37] = GameObject.Find("German_SoundArray/SoundArray (11)");//16.我想先上飲料，彼得你呢?(德文版)
    SoundArray[38] = GameObject.Find("German_SoundArray/SoundArray (12)");//18.好的，稍後會為您上飲品(德文版)
    SoundArray[39] = GameObject.Find("German_SoundArray/SoundArray (13)");//20.不，我沒點這個套餐。(德文版)
    SoundArray[40] = GameObject.Find("German_SoundArray/SoundArray (14)");//21.請問有什麼需要呢?(德文版)
    SoundArray[41] = GameObject.Find("German_SoundArray/SoundArray (15)");//23.請稍後，我們確認一下餐點。(德文版)
    SoundArray[42] = GameObject.Find("German_SoundArray/SoundArray (16)");//24.您們在這兩種套餐打上Ｘ的記號。(德文版)
    SoundArray[43] = GameObject.Find("German_SoundArray/SoundArray (17)");//26.打差表示不要。打勾表示需要。(德文版)
    SoundArray[44] = GameObject.Find("German_SoundArray/SoundArray (18)");//28. 真的很抱歉，這是我們的疏失，我請廚師特別做了特餐，來補償你們。(德文版)
    SoundArray[45] = GameObject.Find("German_SoundArray/SoundArray (19)");//30. 但是提醒您，下次請不要將需要餐點做打差的記號。(德文版)
    SoundArray[46] = GameObject.Find("German_SoundArray/SoundArray (20)");//32.這間店服務真好(德文版)
    SoundArray[47] = GameObject.Find("German_SoundArray/SoundArray (21)");//34.不，我已經很飽了。(德文版)
    SoundArray[48] = GameObject.Find("German_SoundArray/SoundArray (22)");//36.我也很渴。(德文版)
    SoundArray[49] = GameObject.Find("German_SoundArray/SoundArray (23)");//38.我不想點飲料。我想加點一碗湯。(德文版)
    SoundArray[50] = GameObject.Find("German_SoundArray/SoundArray (24)");//40.老闆，結帳。(德文版)
    SoundArray[51] = GameObject.Find("German_SoundArray/SoundArray (25)");//43.請稍後，讓我為您結算。(德文版)
    SoundArray[52] = GameObject.Find("German_SoundArray/SoundArray (26)");//45.可以的。請給我你的信用卡。(德文版)
    SoundArray[53] = GameObject.Find("German_SoundArray/SoundArray (27)");//47.感謝您的惠顧，歡迎再次光臨。(德文版)

    closeAllMusic();
    Timer=0.0f;
	}


	void Update () {

	}


public void closeAllMusic()
{
	for (int i=0;i<54;i++)
	{
		SoundArray[i].gameObject.SetActive(false);//關閉所有聲音物件
	}
}

public void ChooseMusic(int i)//選擇播放之物件
{
	SoundArray[i].gameObject.SetActive(true);//設定要播放哪個物件
	Timer=0.0f;
	if (Timer>5)
	{
		SoundArray[i].gameObject.SetActive(false);//關閉要播放哪個物件
	}
}

}
