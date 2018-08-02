using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedInjector : Task
    {
        #region fields

        /// <summary>
        ///     The task responsible for compiling the class library.
        /// </summary>
        private GeneratedInjectorTaskList _buildInjectorList;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the task responsible for compiling the class library.
        /// </summary>
        public GeneratedInjectorTaskList BuildInjectorList
        {
            get { return _buildInjectorList; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedInjector(GeneratedInjectorTaskList buildInjectorList)
        {
            _buildInjectorList = buildInjectorList;
        }

        #endregion
    }

    public class GeneratedInjector<TypeI, TypeC> : GeneratedInjector where TypeI : GeneratedInterface where TypeC : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The runtime type injected into the interface and class generators.
        /// </summary>
        private Type _runtimeType;

        /// <summary>
        ///     The generated interface, into which the runtime type is injected.
        /// </summary>
        private TypeI _generatedTypeI;

        /// <summary>
        ///     The generated class, into which the runtime type is injected.
        /// </summary>
        private TypeC _generatedTypeC;

        /// <summary>
        ///     The parameters used to instantiate the generated interface and class.
        /// </summary>
        private Object[] _parameters;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the generated interface, into which the runtime type is injected.
        /// </summary>
        public TypeI GeneratedTypeI
        {
            get
            {
                if (_generatedTypeI == null)
                {
                    Object[] parameters = { this.BuildInjectorList.IfaceLibrary };
                    parameters = parameters.Concat(this.Parameters).ToArray();
                    _generatedTypeI = Activator.CreateInstance(typeof(TypeI), parameters) as TypeI;
                }

                return _generatedTypeI;
            }
        }

        /// <summary>
        ///     Gets the generated class, into which the runtime type is injected.
        /// </summary>
        public TypeC GeneratedTypeC
        {
            get
            {
                if (_generatedTypeC == null)
                {
                    Object[] parameters = { this.BuildInjectorList.ClassLibrary };
                    parameters = parameters.Concat(this.Parameters).ToArray();
                    _generatedTypeC = Activator.CreateInstance(typeof(TypeC), parameters) as TypeC;
                }

                return _generatedTypeC;
            }
        }

        /// <summary>
        ///     Gets the runtime type injected into the interface and class generators.
        /// </summary>
        public Type RuntimeType
        {
            get
            {
                if (_runtimeType == null)
                    _runtimeType = this.BuildInjectorList.BuildTask.ProjectTypes.FirstOrDefault(type => GeneratedRuntimeType.GetTypeName(type).Split('.').Last() == this.GeneratedTypeC.DeclarationName);
                if (_runtimeType == null)
                    throw new TypeLoadException("Could not find runtime type - " + this.GeneratedTypeC.TypeName);

                return _runtimeType;
            }
        }

        /// <summary>
        ///     Gets the name of the task
        /// </summary>
        public override String Name
        {
            get { return String.Format("Inserting public exposed members into interface for injection: {0} -> {1}", this.GeneratedTypeC.DeclarationName, this.GeneratedTypeI.DeclarationName); }
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
        public GeneratedInjector(GeneratedInjectorTaskList buildInjectorList) : base(buildInjectorList)
        {
            _parameters = new Object[0];
        }

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedInjector(GeneratedInjectorTaskList buildInjectorList, Object parameter1) : base(buildInjectorList)
        {
            _parameters = new Object[] { parameter1 };
        }

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedInjector(GeneratedInjectorTaskList buildInjectorList, Object parameter1, Object parameter2) : base(buildInjectorList)
        {
            _parameters = new Object[] { parameter1, parameter2 };
        }

        /// <summary>
        ///     Initialises a new build injector.
        /// </summary>
        public GeneratedInjector(GeneratedInjectorTaskList buildInjectorList, Object parameter1, Object parameter2, Object parameter3) : base(buildInjectorList)
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

            GeneratedInjectorInterface injectorI = new GeneratedInjectorInterface(this.GeneratedTypeI, this.RuntimeType);
            injectorI.OnMessage += this.Message;
            injectorI.Execute();
            injectorI.OnMessage -= this.Message;

            GeneratedInjectorClass injectorC = new GeneratedInjectorClass(this.GeneratedTypeC, this.RuntimeType, this.GeneratedTypeI.DeclarationName);
            injectorC.OnMessage += this.Message;
            injectorC.Execute();
            injectorC.OnMessage -= this.Message;
        }

        #endregion
    }
}
