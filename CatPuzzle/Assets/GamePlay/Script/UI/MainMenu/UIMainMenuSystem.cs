using F8Framework.Launcher;
using UnityEngine;

namespace GamePlay.Script.UI.MainMenu
{
    public partial class UIMainMenu
    {
        private void OnBeginGame()
        {
            //跳转到游戏场景
            this.UnLoad();
            //游戏主场景 关卡选择
            FF8.Asset.LoadAsync<GameObject>("MainMenu", (mainMenu) =>
            {
                GameObject obj = Instantiate(mainMenu);
            });
        }
        
        private void OnAc()
        {
            //跳转到游戏场景
        }
        
        private void OnExit()
        {
            //退出游戏
        }

        private void UnLoad()
        {
            FF8.Asset.UnloadAsync("MainMenu",false,null);
        }
    }
}