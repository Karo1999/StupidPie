﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    //GameMode, GameState
    public enum GameMode
    { 
        Gameplay, Cutscene, SceneLoading
    }
}
