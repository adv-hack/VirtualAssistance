using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalProductModel
    {
        /// <summary>
        ///     The active product event for product
        /// </summary>
        private LocalProductEventModel _activeProductEvent;

        /// <summary>
        ///     The main session
        /// </summary>
        private LocalBillOfMaterialModel _mainSession;

        /// <summary>
        ///    Gets or sets the academic code
        /// </summary>
        public LocalProductEventModel ActiveProductEvent
        {
            get
            {
                // Get the product event
                if (_activeProductEvent == null)
                    _activeProductEvent = this.ProductEvents.Where(ProductEvent => ProductEvent.Instance == 0).LastOrDefault();

                // If a product event doesn't exist yet
                if (_activeProductEvent == null)
                    this.ProductEvents.Add(_activeProductEvent = this.Provider.Learning.ProductEvent.Create());

                return _activeProductEvent;
            }
        }


        /// <summary>
        ///    Gets or sets the main session
        /// </summary>
        public LocalBillOfMaterialModel MainSession
        {
            get
            {
                // Get the main session
                if (_mainSession == null)
                    _mainSession = this.BillOfMaterials.Where(BillOfMaterial => BillOfMaterial.MainSession == 1).LastOrDefault();

                // If a product event doesn't exist yet
                if (_mainSession == null)
                {
                    _mainSession = this.Provider.Learning.BillOfMaterial.Create();
                    // NFPCCB-18478 Field 'Free places' is not updated as per 'Max Places'
                    _mainSession.Real = 1;
                    _mainSession.Element = 1;
                    _mainSession.Session = 1;
                    this.BillOfMaterials.Add(_mainSession);
                }

                return _mainSession;
            }
        }

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveDependency()
        {
            base.ResolveDependency();

            // If we are saving a product, and the product has an academic year, add this to the list of productevents for the product so that it will save when the product is saved.
            if (!this.ProductEvents.Contains(this.ActiveProductEvent) && this.ActiveProductEvent.AcadyCodeCode != null)
                this.ProductEvents.Add(this.ActiveProductEvent);

            // If we are saving a product, and there is a main session
            if (!this.BillOfMaterials.Contains(this.MainSession))
                this.BillOfMaterials.Add(this.MainSession);
        }
    }
}
