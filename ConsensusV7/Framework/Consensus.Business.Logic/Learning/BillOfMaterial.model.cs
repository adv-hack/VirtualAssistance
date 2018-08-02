using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="BillOfMaterialRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalBillOfMaterialModel
    {
        private LocalCollection<LocalTemplateTrainerModel, ITemplateTrainerModel> _trainers;
        private LocalCollection<LocalTemplateResourceModel, ITemplateResourceModel> _resources;
        private LocalCollection<LocalTemplateRoomModel, ITemplateRoomModel> _rooms;

        /// <summary>
        ///     Gets the collection of <see cref="ITemplateTrainerModel" /> instances that reference this <see cref="BillOfMaterialModel" />.
        /// </summary>
        public LocalCollection<LocalTemplateTrainerModel, ITemplateTrainerModel> Trainers
        {
            get
            {
                if (_trainers == null)
                    _trainers = new LocalCollection<LocalTemplateTrainerModel, ITemplateTrainerModel>(this.Templates.OfType<LocalTemplateTrainerModel>());

                return _trainers;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ITemplateTrainerModel" /> instances that reference this <see cref="BillOfMaterialModel" />.
        /// </summary>
        public LocalCollection<LocalTemplateResourceModel, ITemplateResourceModel> Resources
        {
            get
            {
                if (_resources == null)
                    _resources = new LocalCollection<LocalTemplateResourceModel, ITemplateResourceModel>(this.Templates.OfType<LocalTemplateResourceModel>());

                return _resources;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ITemplateTrainerModel" /> instances that reference this <see cref="BillOfMaterialModel" />.
        /// </summary>
        public LocalCollection<LocalTemplateRoomModel, ITemplateRoomModel> Rooms
        {
            get
            {
                if (_rooms == null)
                    _rooms = new LocalCollection<LocalTemplateRoomModel, ITemplateRoomModel>(this.Templates.OfType<LocalTemplateRoomModel>());

                return _rooms;
            }
        }

        /// <summary>
        ///     Sets the denormalised data
        /// </summary>
        protected internal override void Denormalise()
        {
            // Reconstruct the collection of templates from the concrete types
            _templates = new LocalCollection<LocalTemplateModel, ITemplateModel>(
                this.Trainers.OfType<LocalTemplateModel>().Concat(
                    this.Resources.OfType<LocalTemplateModel>().Concat(
                        this.Rooms.OfType<LocalTemplateModel>()
                    )
                )
            );

            if (this.Id == null && string.IsNullOrWhiteSpace(this.ChildProductId))
            {
                this.ChildProductId = this.MasterProductId;
                this.MainSession = 1;
                if (this.MasterProduct.SyProduct == 1)
                    this.Type = "Syllabus";
                if (this.StartDay == null)
                    this.StartDay = 0;

                if (this.EndDay == null)
                {
                    if (this.MasterProduct.CourseLen > 0)
                    {
                        if (Convert.ToDecimal(this.MasterProduct.CourseLen) == Math.Round(Convert.ToDecimal(this.MasterProduct.CourseLen)))
                        {
                            this.EndDay = Convert.ToDouble(this.MasterProduct.CourseLen) - 1;
                        }
                        else
                        {
                            this.EndDay = this.MasterProduct.CourseLen;
                        }
                    }
                    else
                    {
                        this.EndDay = 0;
                    }
                }


            }
        }

        /// <summary>
        ///     Updates the dates for the gift aid records
        /// </summary>
        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if (this.MainSession ==  1)
            {
                LocalBillOfMaterialModel[] otherBOMs = this.MasterProduct.BillOfMaterials.Where(BillOfMaterial => BillOfMaterial.Id != this.Id && (BillOfMaterial.MainSession == 1)).ToArray();
                otherBOMs.Execute(BillOfMaterial => BillOfMaterial.MainSession = 0).Execute(BillOfMaterial => BillOfMaterial.Save());
            }

        }

    }
}
