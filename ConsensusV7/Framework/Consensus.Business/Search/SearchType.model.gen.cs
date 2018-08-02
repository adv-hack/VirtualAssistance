using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents provides the definition for each type of search that is available within the application.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchTypeModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "SYSS_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_PAGE_TITLE" field.
        /// </summary>
        System.String PageTitle
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_DB_VIEW_NAME" field.
        /// </summary>
        System.String DatabaseView
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_NEW_BUTTON" field.
        /// </summary>
        System.String NewButton
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_SAVE_JSON" field.
        /// </summary>
        System.String SaveJson
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SearchColumnModel" /> instances that reference this <see cref="!:SearchTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Search.ISearchColumnModel> Columns
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SearchParameterModel" /> instances that reference this <see cref="!:SearchTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Search.ISearchParameterModel> Parameters
        {
            get;
        }
    }
}
