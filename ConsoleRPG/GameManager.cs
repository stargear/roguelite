﻿using System.Collections.Generic;

namespace rogueLike
{
    class GameManager
    {
        public static GameManager Instance;

        public Player player;
        public List<Enemy> enemies;

        public GameManager()
        {
            if (Instance == null)
                Instance = this;



        }

        //
        public void GameLoop()
        {
            // make timer. Update enemy position after time, and other updates.. 
            //while loop for game logic - counts time, etc..

        }

    }
}
