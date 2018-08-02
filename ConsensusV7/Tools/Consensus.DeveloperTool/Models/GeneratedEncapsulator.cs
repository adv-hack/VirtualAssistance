using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedEncapsulator : Task
    {
        #region fields

        /// <summary>
        ///     The task responsible for compiling the model library.
        /// </summary>
        private GeneratedEncapsulatorTaskList _buildEncapsulatorList;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the task responsible for compiling the model library.
        /// </summary>
        public GeneratedEncapsulatorTaskList BuildEncapsulatorList
        {
            get { return _buildEncapsulatorList; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedEncapsulator(GeneratedEncapsulatorTaskList buildEncapsulatorList)
        {
            _buildEncapsulatorList = buildEncapsulatorList;
        }

        #endregion
    }

    public class GeneratedEncapsulator<TModel, TFactory, TProxy> : GeneratedEncapsulator where TModel : GeneratedClass where TFactory : GeneratedClass where TProxy : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The generated class for the model.
        /// </summary>
        private TModel _generatedModel;

        /// <summary>
        ///     The runtime type for the model.
        /// </summary>
        private Type _runtimeModel;

        /// <summary>
        ///     The generated class for the factory.
        /// </summary>
        private TFactory _generatedFactory;

        /// <summary>
        ///     The runtime type for the model.
        /// </summary>
        private Type _runtimeFactory;

        /// <summary>
        ///     The generated class for the proxy.
        /// </summary>
        private TProxy _generatedProxy;

        /// <summary>
        ///     The parameters used to instantiate the generated interface and class.
        /// </summary>
        private Object[] _parameters;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the generated class for the model.
        /// </summary>
        public TModel GeneratedModel
        {
            get
            {
                if (_generatedModel == null)
                {
                    Object[] parameters = { this.BuildEncapsulatorList.ModelLibrary };
                    parameters = parameters.Concat(this.Parameters).ToArray();
                    _generatedModel = Activator.CreateInstance(typeof(TModel), parameters) as TModel;
                }

                return _generatedModel;
            }
        }

        /// <summary>
        ///    Gets the generated class for the factory.
        /// </summary>
        public TFactory GeneratedFactory
        {
            get
            {
                if (_generatedFactory == null)
                {
                    Object[] parameters = { this.BuildEncapsulatorList.ModelLibrary };
                    parameters = parameters.Concat(this.Parameters).ToArray();
                    _generatedFactory = Activator.CreateInstance(typeof(TFactory), parameters) as TFactory;
                }

                return _generatedFactory;
            }
        }

        /// <summary>
        ///    Gets the generated class for the factory.
        /// </summary>
        public TProxy GeneratedProxy
        {
            get
            {
                if (_generatedProxy == null)
                {
                    Object[] parameters = { this.BuildEncapsulatorList.ProxyLibrary };
                    parameters = parameters.Concat(this.Parameters).ToArray();
                    _generatedProxy = Activator.CreateInstance(typeof(TProxy), parameters) as TProxy;
                }

                return _generatedProxy;
            }
        }

        /// <summary>
        ///     Gets the runtime type for the model.
        /// </summary>
        public Type RuntimeModel
        {
            get
            {
                if (_runtimeModel == null)
                    _runtimeModel = this.BuildEncapsulatorList.ModelBuilder.ProjectTypes.FirstOrDefault(type => GeneratedRuntimeType.GetTypeName(type).Split('.').Last() == this.GeneratedModel.DeclarationName);
                if (_runtimeModel == null)
                    throw new TypeLoadException("Could not find runtime type - " + this.GeneratedModel.TypeName);

                return _runtimeModel;
            }
        }

        /// <summary>
        ///     Gets the runtime type for the factory.
        /// </summary>
        public Type RuntimeFactory
        {
            get
            {
                if (_runtimeFactory == null)
                    _runtimeFactory = this.BuildEncapsulatorList.ModelBuilder.ProjectTypes.FirstOrDefault(type => GeneratedRuntimeType.GetTypeName(type).Split('.').Last() == this.GeneratedFactory.DeclarationName);
                if (_runtimeFactory == null)
                    throw new TypeLoadException("Could not find runtime type - " + this.GeneratedFactory.TypeName);

                return _runtimeFactory;
            }
        }

        /// <summary>
        ///     Gets the name of the task
        /// </summary>
        public override String Name
        {
            get { return String.Format("Inserting public exposed members into interface for injection: {0}/{1} -> {2}", this.GeneratedModel.DeclarationName, this.GeneratedFactory.DeclarationName, this.GeneratedProxy.DeclarationName); }
        }

        /// <summary>
        ///     Gets the parameters used to instantiate the generated interface and class.
        /// </summary>
        public Object[] Parameters
        {
            get { return _parameters; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedEncapsulator(GeneratedEncapsulatorTaskList buildEncapsulatorList) : base(buildEncapsulatorList)
        {
            _parameters = new Object[0];
        }

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedEncapsulator(GeneratedEncapsulatorTaskList buildEncapsulatorList, Object parameter1) : base(buildEncapsulatorList)
        {
            _parameters = new Object[] { parameter1 };
        }

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedEncapsulator(GeneratedEncapsulatorTaskList buildEncapsulatorList, Object parameter1, Object parameter2) : base(buildEncapsulatorList)
        {
            _parameters = new Object[] { parameter1, parameter2 };
        }

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedEncapsulator(GeneratedEncapsulatorTaskList buildEncapsulatorList, Object parameter1, Object parameter2, Object parameter3) : base(buildEncapsulatorList)
        {
            _parameters = new Object[] { parameter1, parameter2, parameter3 };
        }

        #endregion

        #region methods

        /// <summary>
        ///     Executes the injection task.
        /// </summary>
        protected override void ExecuteTask()
        {
            if (MainForm.Runtime != null && MainForm.Runtime.CancelToken != null)
                MainForm.Runtime.CancelToken.ThrowIfCancellationRequested();

            GeneratedEncapsulatorClass injector = new GeneratedEncapsulatorClass(this.GeneratedProxy, this.RuntimeModel, this.RuntimeFactory);
            injector.OnMessage += this.Message;
            injector.Execute();
            injector.OnMessage -= this.Message;
        }

        #endregion
    }
}
