﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class SystemMain : MonoBehaviour {

	//Enemy Prefabs
	public GameObject tank;
	
    //tang
    public struct StageInfo
    {
        public StageInfo( bool s, int idx ) { single = s; stageIndex = idx; }
        public bool single;
        public int  stageIndex;
    }
    public GameObject[] prefabEnemies;
    public StageInfo    currentStageInfo;
    public StageManager stageManager;
    public WaveManager  waveManager;
    public enum EnemyType
    {
        A,
        B,
        C,
        D,
        E
    };




	void Start () {
		GameStatics.waves = 1;
		GameStatics.cash = 100;
		GameStatics.gameScore = 0;
		GameStatics.lives = 20;
		GameStatics.waveTime = 1f;


        currentStageInfo = new StageInfo( true, 0 );  // 永遠的第一關
        stageManager = GetComponent<StageManager>();
        waveManager = GetComponent<WaveManager>();
	}
	
	// Update is called once per frame
	void Update () {

	}



	//public function for manipulating GameStatics
	void AddScore(int i){GameStatics.gameScore += i;}
	void AddCash(int i) {GameStatics.cash += i;}
	void AddLives(int i){GameStatics.lives+= i;}
	void AddWaves(int i){GameStatics.waves += i;}


    /*-----------------------------Start By Tang: Waves--------------------*/



   
    public void SendWave(){
		//SetNextWave ();
		//StartCoroutine("WaveCoroutine");
        List<Wave> waveList = stageManager.GetWaveList( currentStageInfo.single, currentStageInfo.stageIndex );
        GameObject route    = stageManager.GetRoute( currentStageInfo.single, currentStageInfo.stageIndex );
        waveManager.SendWave( waveList, route );
	}




    public static Enemy GetEnemyInstanceByType( EnemyType type )
    {
        Enemy enemy = null;
        switch ( type ) {
            case EnemyType.A: enemy = new Tank(); break;
            case EnemyType.B: enemy = new TankB(); break;
            case EnemyType.C: break;
            case EnemyType.D: break;
            case EnemyType.E: break;
        }

        return enemy;
    }

    /*--------------------------End------------------------*/
    













    //這段我整個複寫ㄏㄏ  by Tang
    /*
    // Use this for initialization
    void SetNextWave(){
        //GameStatics.waveTime += 10;
        GameStatics.waves++;
        if (GameStatics.waveTime > 0.001f)
                        GameStatics.waveTime *= 0.9f;
    }


    IEnumerator WaveCoroutine(){
        //生成
        //yield return new WaitForEndOfFrame ();
        //Debug.Log ("Coroutine");
            for (int i = 0; i < GameStatics.waves + 5; i++){
                //Tank tt;
                //tt = (Tank)
                Instantiate (tank, beginPoint.transform.position, Quaternion.identity);
				
                yield return new WaitForSeconds (GameStatics.waveTime);
            }
        SetNextWave ();
    }
    */
	
}
