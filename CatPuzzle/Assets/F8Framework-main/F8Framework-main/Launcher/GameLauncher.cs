using System.Collections;
using F8Framework.Core;
using F8Framework.F8ExcelDataClass;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace F8Framework.Launcher
{
    public class GameLauncher : MonoBehaviour
    {
        IEnumerator Start()
        {
            // 初始化模块中心
            ModuleCenter.Initialize(this);

            // 初始化版本
            FF8.HotUpdate = ModuleCenter.CreateModule<HotUpdateManager>();

            // 按顺序创建模块，可按需添加
            FF8.Message = ModuleCenter.CreateModule<MessageManager>();
            FF8.Input = ModuleCenter.CreateModule<InputManager>(new DefaultInputHelper());
            FF8.Storage = ModuleCenter.CreateModule<StorageManager>();
            FF8.Timer = ModuleCenter.CreateModule<TimerManager>();
            FF8.Procedure = ModuleCenter.CreateModule<ProcedureManager>();
            FF8.Network = ModuleCenter.CreateModule<NetworkManager>();
            FF8.FSM = ModuleCenter.CreateModule<FSMManager>();
            FF8.GameObjectPool = ModuleCenter.CreateModule<GameObjectPool>();
            FF8.Asset = ModuleCenter.CreateModule<AssetManager>();
            FF8.Config = ModuleCenter.CreateModule<F8DataManager>();
            FF8.Audio = ModuleCenter.CreateModule<AudioManager>();
            FF8.Tween = ModuleCenter.CreateModule<Tween>();
            FF8.UI = ModuleCenter.CreateModule<UIManager>();
            // FF8.Local = ModuleCenter.CreateModule<Localization>(); //本地化表打不开 暂时应该也用不到本地化
            // FF8.SDK = ModuleCenter.CreateModule<SDKManager>(); //SDK用不到
            // FF8.Download = ModuleCenter.CreateModule<DownloadManager>(); //资源下载用不到
            FF8.LogWriter = ModuleCenter.CreateModule<F8LogWriter>();

            StartGame();
            yield break;
        }

        // 开始游戏
        public void StartGame()
        {
            //start
            
            //init
            //FF8.UI.Initialize();
            
            //加载游戏主界面
            FF8.Asset.LoadAsync<GameObject>("MainMenu", (mainMenu) =>
            {
                GameObject obj = Instantiate(mainMenu);
            });
        }

        void Update()
        {
            // 更新模块
            ModuleCenter.Update();
        }

        void LateUpdate()
        {
            // 更新模块
            ModuleCenter.LateUpdate();
        }

        void FixedUpdate()
        {
            // 更新模块
            ModuleCenter.FixedUpdate();
        }
    }
}
