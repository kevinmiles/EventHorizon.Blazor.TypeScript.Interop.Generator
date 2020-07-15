/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IEasingFunction { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IEasingFunctionCachedEntity : CachedEntityObject, IEasingFunction
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

        #endregion
        
        #region Constructor
        public IEasingFunctionCachedEntity() : base() { }

        public IEasingFunctionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public decimal ease(decimal gradient)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "ease" }, gradient
                }
            );
        }
        #endregion
    }
}