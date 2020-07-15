/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IOfflineProvider { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IOfflineProviderCachedEntity : CachedEntityObject, IOfflineProvider
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public bool enableSceneOffline
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enableSceneOffline"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enableSceneOffline",
                    value
                );
            }
        }

        
        public bool enableTexturesOffline
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enableTexturesOffline"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enableTexturesOffline",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IOfflineProviderCachedEntity() : base() { }

        public IOfflineProviderCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region open TODO: Get Comments as metadata identification
        private bool _isOpenEnabled = false;
        private readonly IDictionary<string, Func<Task>> _openActionMap = new Dictionary<string, Func<Task>>();

        public string open(
            Func<Task> callback
        )
        {
            SetupOpenLoop();

            var handle = Guid.NewGuid().ToString();
            _openActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupOpenLoop()
        {
            if (_isOpenEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "open",
                "CallOpenActions",
                _invokableReference
            );
            _isOpenEnabled = true;
        }

        [JSInvokable]
        public async Task CallOpenActions()
        {
            foreach (var action in _openActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void loadImage(string url, HTMLImageElement image)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "loadImage" }, url, image
                }
            );
        }

        #region loadFile TODO: Get Comments as metadata identification
        private bool _isLoadFileEnabled = false;
        private readonly IDictionary<string, Func<Task>> _loadFileActionMap = new Dictionary<string, Func<Task>>();

        public string loadFile(
            Func<Task> callback
        )
        {
            SetupLoadFileLoop();

            var handle = Guid.NewGuid().ToString();
            _loadFileActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupLoadFileLoop()
        {
            if (_isLoadFileEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "loadFile",
                "CallLoadFileActions",
                _invokableReference
            );
            _isLoadFileEnabled = true;
        }

        [JSInvokable]
        public async Task CallLoadFileActions()
        {
            foreach (var action in _loadFileActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}