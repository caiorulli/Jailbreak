using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    class GameState
    {
        private static GameState _instance;
        public static GameState Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameState();
                }
                return _instance;
            }
        }

        public static readonly string START_SCREEN = "StartScreen";
        public static readonly string GAME_OVER = "Game Over";
        public static readonly string VICTORY = "Victory";
        public static readonly string LOADING = "Loading";
        public static readonly string TUTORIAL = "Tutorial";
        public static readonly string STAGE_ONE = "StageOne";
        public static readonly string STAGE_TWO = "StageTwo";
        public static readonly string STAGE_THREE = "StageThree";

        private string[] _stageSequence;
        private int _currentStage = 0;

        public GameState()
        {
            _stageSequence = new string[]
            {
                TUTORIAL, STAGE_ONE, STAGE_TWO, STAGE_THREE
            };
        }

        public void HandleStageCompletion(string scene)
        {
            if (scene == "StartScreen")
            {
                _currentStage = 0;
            } else {
                _currentStage++;
            }
        }
        
        public string GetNextScene()
        {
            if (_currentStage == _stageSequence.Length)
            {
                _currentStage = 0;
                return VICTORY;
            }
            return _stageSequence[_currentStage];
        }
    }
}
